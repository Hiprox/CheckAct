using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using RSDN;
using TemplateEngine.Docx;
using DocumentFormat.OpenXml.Validation;
using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string DIR_TEMPLATE { get; } = "Template";
        private string DIR_RESULT { get; } = "Result";
        private string TEMPLATE_ACT { get; } = "template_act.docx";
        private string TEMPLATE_CHECK { get; } = "template_check.docx";
        private string RESULT_ACT { get; } = "output_act.docx";
        private string RESULT_CHECK { get; } = "output_check.docx";

        private void DirectoriesExists()
        {
            if (!Directory.Exists(DIR_TEMPLATE)) Directory.CreateDirectory(DIR_TEMPLATE);
            if (!Directory.Exists(DIR_RESULT)) Directory.CreateDirectory(DIR_RESULT);
        }

        public Form1()
        {
            InitializeComponent();
            DirectoriesExists();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static void IsDigitalInput(ref KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else if (Char.IsControl(e.KeyChar)) return;
            else e.Handled = true;
        }

        private void IsDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigitalInput(ref e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.tbox_code.Mask = "0 0 0 0 0 0 0 0 0 0 0 0 0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.tbox_code.Mask = "0 0 0 0 0 0 0 0 0 0 0 0 0 0 0";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.tbox_code.Mask = "0 0 0 0 0 0 0 0 0";
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

        // Получить разбитую дату на 3 части (день, месяц, год) в строковом представлении
        private Tuple<string, string, string> GetSplitDate(DateTimePicker date)
        {
            var result = date.Text.Split(' ', StringSplitOptions.TrimEntries);
            return new (result.First(), result[0], result.Last());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoriesExists();

            var FileResultAct = string.Format("{0}\\{1}",DIR_RESULT, RESULT_ACT);
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

            var codeType = rb_OGRN.Checked ? rb_OGRN.Text : (rb_OGRNIP.Checked ? rb_OGRNIP.Text : rb_KPP.Text);

            // Sum
            var number = tbox_price.Text.Split(',');
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
                fraction > 0 ?
                    string.Format(" {0}", RusNumber.Str(fraction, isUpper: false, currency: RusNumber.Currency.Penny))
                    : string.Empty
                );

            // Templates
            var valuesActToFill = new Content(
                new FieldContent("Company", tbox_company.Text),
                new FieldContent("Address", tbox_address.Text),
                new FieldContent("TIN", tbox_TIN.Text.Replace(" ", "")),
                new FieldContent("CodeType", codeType),
                new FieldContent("Code", tbox_code.Text.Replace(" ", "")),
                new FieldContent("ActNumber", tbox_act.Text),
                new FieldContent("ActDate", dateTime_act.Text),
                new FieldContent("ContractNumber", tbox_contractNumber.Text),
                new FieldContent("ContractDate", dateTime_Contract.Text),
                new FieldContent("From", tbox_from.Text),
                new FieldContent("Where", tbox_where.Text),
                new FieldContent("Price", priceAct),
                new FieldContent("PriceWords", priceWords)
                );
            var valuesCheckToFill = new Content(
                new FieldContent("Company", tbox_company.Text),
                new FieldContent("Address", tbox_address.Text),
                new FieldContent("TIN", tbox_TIN.Text.Replace(" ", "")),
                new FieldContent("CodeType", codeType),
                new FieldContent("Code", tbox_code.Text.Replace(" ", "")),
                new FieldContent("CurrentAccount", tbox_currentAccount.Text.Replace(" ", "")),
                new FieldContent("CorrespondentAccount", tbox_correspondentAccount.Text.Replace(" ", "")),
                new FieldContent("Bank", tbox_bank.Text),
                new FieldContent("BIC", tbox_BIC.Text.Replace(" ", "")),
                new FieldContent("CheckNumber", tbox_act.Text),
                new FieldContent("CheckDate", dateTime_check.Text),
                new FieldContent("ContractNumber", tbox_contractNumber.Text),
                new FieldContent("ContractDate", dateTime_Contract.Text),
                new FieldContent("From", tbox_from.Text),
                new FieldContent("Where", tbox_where.Text),
                new FieldContent("Price", priceCheck),
                new FieldContent("PriceWords", priceWords)
                );

            // Process
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

        private void tbox_contractapp_TextChanged(object sender, EventArgs e)
        {
            DoubleAngleQuotationMark(sender as TextBox);
        }

        private void tbox_contractapp_Leave(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb.Text.Length == 0)
            {
                tb.Text = "Б/Н";
                tb.Select(tb.Text.Length, 0);
            }
        }

        private void DoubleAngleQuotationMark(TextBox tb)
        {
            tb.Text = Regex.Replace(tb.Text, "\"(\\w+)", "«$1");
            tb.Text = Regex.Replace(tb.Text, "(\\w+)\"", "$1»");
            //tb.Text = Regex.Replace(tb.Text, "\"(.+?)\"", "«$1»");
            tb.Select(tb.Text.Length, 0);
        }

        private void tbox_company_TextChanged(object sender, EventArgs e)
        {
            DoubleAngleQuotationMark(sender as TextBox);
        }

        private void tbox_address_TextChanged(object sender, EventArgs e)
        {
            DoubleAngleQuotationMark(sender as TextBox);
        }

        private void tbox_bank_TextChanged(object sender, EventArgs e)
        {
            DoubleAngleQuotationMark(sender as TextBox);
        }
    }
}