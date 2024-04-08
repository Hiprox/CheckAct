using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CheckAct.Application.Utility;
using CheckAct.BusinessLogic.Dto;
using CheckAct.BusinessLogic.Interfaces;
using CheckAct.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using TemplateEngine.Docx;

namespace CheckAct.Application
{
    public partial class CheckAct : Form
    {
        private readonly IDocumentService _documentService = DIContainer.ServiceProvider.GetService<IDocumentService>();

        public CheckAct()
        {
            InitializeComponent();
            DirectoriesExists();

            companyTextBox.TextChanged += TextBox_TextChanged;
            addressTextBox.TextChanged += TextBox_TextChanged;
            bankTextBox.TextChanged += TextBox_TextChanged;
            payerContractNumberTextBox.TextChanged += TextBox_TextChanged;
            payerContractNumberTextBox.Leave += ContractNumber_Leave;
        }

        private void DirectoriesExists()
        {
            if (!Directory.Exists(DIR_TEMPLATE)) Directory.CreateDirectory(DIR_TEMPLATE);
            if (!Directory.Exists(DIR_RESULT)) Directory.CreateDirectory(DIR_RESULT);
        }

        /// <summary>
        /// Изменить кавычки на угловые в TextBox
        /// </summary>
        /// <param name="tb">Изменяемый TextBox</param>
        private void DoubleAngleQuotationMark(TextBox tb)
        {
            if (tb.Text.Contains("\""))
            {
                int cursor = tb.SelectionStart;
                tb.Text = Regex.Replace(tb.Text, "\"(\\w+)", "«$1");
                tb.Text = Regex.Replace(tb.Text, "(\\w+)\"", "$1»");
                tb.Select(cursor, 0);
            }
        }

        private static void IsDigitalInput(ref KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        /// <summary>
        /// Получить дату разбитую на 3 части - день, месяц, год
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Число, Месяц, Год в строком представлении</returns>
        private Tuple<string, string, string> GetSplitDate(DateTimePicker date)
        {
            var result = date.Text.Split(' ', StringSplitOptions.TrimEntries);
            return new(result.First(), result[0], result.Last());
        }

        private async void OnSubmitClick(object sender, EventArgs e)
        {
            DirectoriesExists();

            var FileResultAct = string.Format("{0}\\{1}", DIR_RESULT, RESULT_ACT);
            var FileResultCheck = string.Format("{0}\\{1}", DIR_RESULT, RESULT_CHECK);
            var FileTemplatetAct = string.Format("{0}\\{1}", DIR_TEMPLATE, TEMPLATE_ACT);
            var FileTemplateCheck = string.Format("{0}\\{1}", DIR_TEMPLATE, TEMPLATE_CHECK);

            File.Delete(FileResultAct);
            File.Delete(FileResultCheck);

            if (!File.Exists(FileTemplatetAct) || !File.Exists(FileTemplateCheck))
            {
                MessageBox.Show("Код ошибки 0х01");
                return;
            }

            File.Copy(FileTemplatetAct, FileResultAct);
            File.Copy(FileTemplateCheck, FileResultCheck);

            var codeType = ogrnRadioButton.Checked
                ? ogrnRadioButton.Text
                : (ogrnipRadioButton.Checked ? ogrnipRadioButton.Text : kppRadioButton.Text);

            // Sum
            var number = cost.Text.Split(',');
            var integer = int.Parse(number[0]);
            var fraction = int.Parse(number[1]);

            var priceAct = string.Format("{0} рублей{1}", integer.ToString("#,0", new CultureInfo("ru-RU")),
                fraction > 0 ? string.Format(" {0} копеек", fraction) : string.Empty);
            var priceCheck = string.Format("{0}-{1}",
                integer.ToString("#,0", new CultureInfo("ru-RU")),
                fraction.ToString("00", new CultureInfo("ru-RU"))
            );

            var priceWords = string.Format("{0}{1}",
                RusNumber.Str(integer, currency: RusNumber.Currency.Ruble),
                fraction > 0
                    ? string.Format(" {0}", RusNumber.Str(fraction, isUpper: false, currency: RusNumber.Currency.Penny))
                    : string.Empty
            );

            // Привязка значений к ключам шаблона DOCX документа
            var valuesActToFill = new Content(
                new FieldContent("Company", companyTextBox.Text),
                new FieldContent("Address", addressTextBox.Text),
                new FieldContent("TIN", innTextBox.Text.Replace(" ", "")),
                new FieldContent("CodeType", codeType),
                new FieldContent("Code", codeTextBox.Text.Replace(" ", "")),
                new FieldContent("ActNumber", actNumberTextBox.Text),
                new FieldContent("ActDate", actDate.Text),
                new FieldContent("ContractNumber", payerContractNumberTextBox.Text),
                new FieldContent("ContractDate", payerContractDate.Text),
                new FieldContent("From", srcRouteTextBox.Text),
                new FieldContent("Where", dstRouteTextBox.Text),
                new FieldContent("Price", priceAct),
                new FieldContent("PriceWords", priceWords)
            );
            var valuesCheckToFill = new Content(
                new FieldContent("Company", companyTextBox.Text),
                new FieldContent("Address", addressTextBox.Text),
                new FieldContent("TIN", innTextBox.Text.Replace(" ", "")),
                new FieldContent("CodeType", codeType),
                new FieldContent("Code", codeTextBox.Text.Replace(" ", "")),
                new FieldContent("CurrentAccount", settlementAccountTextBox.Text.Replace(" ", "")),
                new FieldContent("CorrespondentAccount", correspondentAccountTextBox.Text.Replace(" ", "")),
                new FieldContent("Bank", bankTextBox.Text),
                new FieldContent("BIC", bicTextBox.Text.Replace(" ", "")),
                new FieldContent("CheckNumber", checkNumberTextBox.Text),
                new FieldContent("CheckDate", checkDate.Text),
                new FieldContent("ContractNumber", payerContractNumberTextBox.Text),
                new FieldContent("ContractDate", payerContractDate.Text),
                new FieldContent("From", srcRouteTextBox.Text),
                new FieldContent("Where", dstRouteTextBox.Text),
                new FieldContent("Price", priceCheck),
                new FieldContent("PriceWords", priceWords)
            );

            // Обработка\
            try
            {
                var dto = new DocumentDto
                {
                    Act = new ActDto
                    {
                        Number = actNumberTextBox.Text,
                        Date = actDate.Value
                    },
                    Checks =
                    [
                        new CheckDto
                        {
                            Number = checkNumberTextBox.Text,
                            Date = checkDate.Value,
                            Cost = long.Parse($"{integer}{fraction}")
                        }
                    ],
                    PayerContractNumber = payerContractNumberTextBox.Text,
                    PayerContractDate = payerContractDate.Value,
                    RoadRoutes =
                    [
                        new RoadRouteDto
                        {
                            SourceRoute = srcRouteTextBox.Text,
                            SourceDate = DateTime.Today,
                            DestinationRoute = dstRouteTextBox.Text,
                            DestinationDate = DateTime.Today
                        }
                    ],
                    Payer = new PayerDto
                    {
                        Company = companyTextBox.Text,
                        Address = addressTextBox.Text,
                        Inn = innTextBox.Text.Replace(" ", ""),
                        CodeType = SelectedCodeType,
                        Code = codeTextBox.Text.Replace(" ", ""),
                        Bank = bankTextBox.Text,
                        SettlementAccount = settlementAccountTextBox.Text.Replace(" ", ""),
                        CorrespondentAccount = correspondentAccountTextBox.Text.Replace(" ", ""),
                        Bic = bicTextBox.Text.Replace(" ", "")
                    }
                };

                await _documentService.CreateAsync(dto);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка при построении отчёта");
                MessageBox.Show("Ошибка при построении отчёта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                DirectoriesExists();
                using (var outputDoc = new TemplateProcessor(FileResultAct).SetRemoveContentControls(true))
                {
                    outputDoc.FillContent(valuesActToFill);
                    outputDoc.SaveChanges();
                }

                DirectoriesExists();
                using (var outputDoc = new TemplateProcessor(FileResultCheck).SetRemoveContentControls(true))
                {
                    outputDoc.FillContent(valuesCheckToFill);
                    outputDoc.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Код ошибки 0х02");
            }

            MessageBox.Show(string.Format("Документы созданы!"));
        }

        private CodeType SelectedCodeType
        {
            get
            {
                if (ogrnRadioButton.Checked)
                {
                    return CodeType.Ogrn;
                }

                if (ogrnipRadioButton.Checked)
                {
                    return CodeType.Ogrnip;
                }

                return CodeType.Kpp;
            }
        }

        private void IsDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigitalInput(ref e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.codeTextBox.Mask = "0000000000000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.codeTextBox.Mask = "000000000000000";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.codeTextBox.Mask = "000000000";
        }

        private void tbox_price_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null)
            {
                if (Char.IsDigit(tb.Text[^1])
                    || Char.IsControl(tb.Text[^1]))
                {
                    string value = "";
                    if (tb != null)
                        value = tb.Text.Replace(".", "").Replace(",", "");
                    while (value.Length != 0 && value[0] == '0')
                    {
                        value = value.TrimStart('0');
                    }

                    if (value.Length == 0)
                    {
                        if (tb != null)
                            tb.Text = "0,00";
                    }
                    else
                    {
                        decimal ul;
                        if (decimal.TryParse(value, out ul))
                        {
                            ul /= 100;
                            if (tb != null)
                                tb.Text = string.Format("{0:0.00}", ul);
                        }
                    }

                    if (tb != null)
                        tb.Select(tb.Text.Length, 0);
                }
                else tb.Text = tb.Text.Remove(tb.Text.Length - 1);
            }
        }

        private void ContractNumber_Leave(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb.Text.Length == 0)
            {
                tb.Text = "Б/Н";
                tb.Select(tb.Text.Length, 0);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var obj = sender as TextBox;
            if (obj == null) return;
            DoubleAngleQuotationMark(obj);
        }

        private string DIR_TEMPLATE { get; } = "Template";
        private string DIR_RESULT { get; } = "Result";
        private string TEMPLATE_ACT { get; } = "template_act.docx";
        private string TEMPLATE_CHECK { get; } = "template_check.docx";
        private string RESULT_ACT { get; } = "output_act.docx";
        private string RESULT_CHECK { get; } = "output_check.docx";
    }
}