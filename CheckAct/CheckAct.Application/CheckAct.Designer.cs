using System.Windows.Forms;

namespace CheckAct.Application
{
    partial class CheckAct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bicTextBox = new MaskedTextBox();
            correspondentAccountTextBox = new MaskedTextBox();
            settlementAccountTextBox = new MaskedTextBox();
            bankTextBox = new TextBox();
            label8 = new Label();
            label10 = new Label();
            lable11 = new Label();
            label12 = new Label();
            label13 = new Label();
            dstRouteTextBox = new TextBox();
            srcRouteTextBox = new TextBox();
            addressTextBox = new TextBox();
            label4 = new Label();
            label7 = new Label();
            companyTextBox = new TextBox();
            label3 = new Label();
            payerContractNumberTextBox = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            checkDate = new DateTimePicker();
            actDate = new DateTimePicker();
            checkNumberTextBox = new TextBox();
            actNumberTextBox = new TextBox();
            panel1 = new Panel();
            submitButton = new Button();
            groupBox5 = new GroupBox();
            label5 = new Label();
            cost = new TextBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            label15 = new Label();
            innTextBox = new MaskedTextBox();
            groupBox1 = new GroupBox();
            codeTextBox = new MaskedTextBox();
            kppRadioButton = new RadioButton();
            ogrnipRadioButton = new RadioButton();
            ogrnRadioButton = new RadioButton();
            groupBox2 = new GroupBox();
            payerContractDate = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // bicTextBox
            // 
            bicTextBox.HidePromptOnLeave = true;
            bicTextBox.InsertKeyMode = InsertKeyMode.Overwrite;
            bicTextBox.Location = new System.Drawing.Point(62, 291);
            bicTextBox.Margin = new Padding(3, 2, 3, 2);
            bicTextBox.Mask = "0 0  0 0  0 0  0 0 0";
            bicTextBox.Name = "bicTextBox";
            bicTextBox.Size = new System.Drawing.Size(131, 25);
            bicTextBox.TabIndex = 22;
            bicTextBox.TextAlign = HorizontalAlignment.Center;
            bicTextBox.KeyPress += IsDigit_KeyPress;
            // 
            // correspondentAccountTextBox
            // 
            correspondentAccountTextBox.HidePromptOnLeave = true;
            correspondentAccountTextBox.InsertKeyMode = InsertKeyMode.Overwrite;
            correspondentAccountTextBox.Location = new System.Drawing.Point(62, 262);
            correspondentAccountTextBox.Margin = new Padding(3, 2, 3, 2);
            correspondentAccountTextBox.Mask = "0 0 0  0 0  0 0 0  0  0 0 0 0  0 0 0 0 0 0 0";
            correspondentAccountTextBox.Name = "correspondentAccountTextBox";
            correspondentAccountTextBox.Size = new System.Drawing.Size(250, 25);
            correspondentAccountTextBox.TabIndex = 21;
            correspondentAccountTextBox.TextAlign = HorizontalAlignment.Center;
            correspondentAccountTextBox.KeyPress += IsDigit_KeyPress;
            // 
            // settlementAccountTextBox
            // 
            settlementAccountTextBox.HidePromptOnLeave = true;
            settlementAccountTextBox.InsertKeyMode = InsertKeyMode.Overwrite;
            settlementAccountTextBox.Location = new System.Drawing.Point(62, 235);
            settlementAccountTextBox.Margin = new Padding(3, 2, 3, 2);
            settlementAccountTextBox.Mask = "0 0 0  0 0  0 0 0  0  0 0 0 0  0 0 0 0 0 0 0";
            settlementAccountTextBox.Name = "settlementAccountTextBox";
            settlementAccountTextBox.Size = new System.Drawing.Size(250, 25);
            settlementAccountTextBox.TabIndex = 20;
            settlementAccountTextBox.TextAlign = HorizontalAlignment.Center;
            settlementAccountTextBox.KeyPress += IsDigit_KeyPress;
            // 
            // bankTextBox
            // 
            bankTextBox.Location = new System.Drawing.Point(62, 206);
            bankTextBox.Margin = new Padding(3, 2, 3, 2);
            bankTextBox.Name = "bankTextBox";
            bankTextBox.Size = new System.Drawing.Size(363, 25);
            bankTextBox.TabIndex = 19;
            bankTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label8.Location = new System.Drawing.Point(19, 48);
            label8.Name = "label8";
            label8.Padding = new Padding(4);
            label8.Size = new System.Drawing.Size(52, 27);
            label8.TabIndex = 7;
            label8.Text = "Куда";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label10.Location = new System.Drawing.Point(20, 233);
            label10.Name = "label10";
            label10.Padding = new Padding(4);
            label10.Size = new System.Drawing.Size(41, 27);
            label10.TabIndex = 9;
            label10.Text = "Р/С";
            // 
            // lable11
            // 
            lable11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lable11.AutoSize = true;
            lable11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            lable11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lable11.Location = new System.Drawing.Point(19, 260);
            lable11.Name = "lable11";
            lable11.Padding = new Padding(4);
            lable11.Size = new System.Drawing.Size(44, 27);
            lable11.TabIndex = 10;
            lable11.Text = "К/С";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label12.Location = new System.Drawing.Point(5, 208);
            label12.Name = "label12";
            label12.Padding = new Padding(4);
            label12.Size = new System.Drawing.Size(54, 27);
            label12.TabIndex = 11;
            label12.Text = "Банк";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label13.Location = new System.Drawing.Point(9, 291);
            label13.Name = "label13";
            label13.Padding = new Padding(4);
            label13.Size = new System.Drawing.Size(52, 27);
            label13.TabIndex = 12;
            label13.Text = "БИК";
            // 
            // dstRouteTextBox
            // 
            dstRouteTextBox.Location = new System.Drawing.Point(77, 50);
            dstRouteTextBox.Margin = new Padding(3, 2, 3, 2);
            dstRouteTextBox.Name = "dstRouteTextBox";
            dstRouteTextBox.Size = new System.Drawing.Size(173, 25);
            dstRouteTextBox.TabIndex = 9;
            dstRouteTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // srcRouteTextBox
            // 
            srcRouteTextBox.Location = new System.Drawing.Point(77, 21);
            srcRouteTextBox.Margin = new Padding(3, 2, 3, 2);
            srcRouteTextBox.Name = "srcRouteTextBox";
            srcRouteTextBox.Size = new System.Drawing.Size(173, 25);
            srcRouteTextBox.TabIndex = 8;
            srcRouteTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new System.Drawing.Point(102, 59);
            addressTextBox.Margin = new Padding(3, 2, 3, 2);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new System.Drawing.Size(525, 25);
            addressTextBox.TabIndex = 12;
            addressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(37, 55);
            label4.Name = "label4";
            label4.Padding = new Padding(4);
            label4.Size = new System.Drawing.Size(59, 27);
            label4.TabIndex = 3;
            label4.Text = "Адрес";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label7.Location = new System.Drawing.Point(2, 21);
            label7.Name = "label7";
            label7.Padding = new Padding(4);
            label7.Size = new System.Drawing.Size(69, 27);
            label7.TabIndex = 6;
            label7.Text = "Откуда";
            // 
            // companyTextBox
            // 
            companyTextBox.Location = new System.Drawing.Point(102, 28);
            companyTextBox.Margin = new Padding(3, 2, 3, 2);
            companyTextBox.Name = "companyTextBox";
            companyTextBox.Size = new System.Drawing.Size(210, 25);
            companyTextBox.TabIndex = 11;
            companyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(5, 34);
            label3.Name = "label3";
            label3.Padding = new Padding(4);
            label3.Size = new System.Drawing.Size(91, 27);
            label3.TabIndex = 2;
            label3.Text = "Компания";
            // 
            // payerContractNumberTextBox
            // 
            payerContractNumberTextBox.Location = new System.Drawing.Point(159, 84);
            payerContractNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            payerContractNumberTextBox.Name = "payerContractNumberTextBox";
            payerContractNumberTextBox.Size = new System.Drawing.Size(87, 25);
            payerContractNumberTextBox.TabIndex = 6;
            payerContractNumberTextBox.Text = "Б/Н";
            payerContractNumberTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label6.Location = new System.Drawing.Point(4, 84);
            label6.Name = "label6";
            label6.Padding = new Padding(4);
            label6.Size = new System.Drawing.Size(150, 27);
            label6.TabIndex = 5;
            label6.Text = "Договор-заявка №";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Cursor = Cursors.No;
            label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(4, 24);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new System.Drawing.Size(73, 27);
            label1.TabIndex = 0;
            label1.Text = "Счёт №";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(12, 48);
            label2.Name = "label2";
            label2.Padding = new Padding(4);
            label2.Size = new System.Drawing.Size(65, 27);
            label2.TabIndex = 1;
            label2.Text = "Акт №";
            // 
            // checkDate
            // 
            checkDate.CustomFormat = "« dd » MMMM yyyy г.";
            checkDate.Format = DateTimePickerFormat.Custom;
            checkDate.Location = new System.Drawing.Point(125, 26);
            checkDate.Margin = new Padding(3, 2, 3, 2);
            checkDate.Name = "checkDate";
            checkDate.Size = new System.Drawing.Size(181, 25);
            checkDate.TabIndex = 3;
            // 
            // actDate
            // 
            actDate.CustomFormat = "« dd » MMMM yyyy г.";
            actDate.Format = DateTimePickerFormat.Custom;
            actDate.Location = new System.Drawing.Point(125, 53);
            actDate.Margin = new Padding(3, 2, 3, 2);
            actDate.Name = "actDate";
            actDate.Size = new System.Drawing.Size(181, 25);
            actDate.TabIndex = 5;
            // 
            // checkNumberTextBox
            // 
            checkNumberTextBox.Location = new System.Drawing.Point(85, 26);
            checkNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            checkNumberTextBox.MaxLength = 3;
            checkNumberTextBox.Name = "checkNumberTextBox";
            checkNumberTextBox.Size = new System.Drawing.Size(36, 25);
            checkNumberTextBox.TabIndex = 2;
            checkNumberTextBox.TextAlign = HorizontalAlignment.Center;
            checkNumberTextBox.KeyPress += IsDigit_KeyPress;
            // 
            // actNumberTextBox
            // 
            actNumberTextBox.Location = new System.Drawing.Point(85, 53);
            actNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            actNumberTextBox.MaxLength = 3;
            actNumberTextBox.Name = "actNumberTextBox";
            actNumberTextBox.Size = new System.Drawing.Size(36, 25);
            actNumberTextBox.TabIndex = 4;
            actNumberTextBox.TextAlign = HorizontalAlignment.Center;
            actNumberTextBox.KeyPress += IsDigit_KeyPress;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(submitButton);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(683, 542);
            panel1.TabIndex = 1;
            // 
            // submitButton
            // 
            submitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            submitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            submitButton.Location = new System.Drawing.Point(499, 485);
            submitButton.Name = "submitButton";
            submitButton.Size = new System.Drawing.Size(175, 45);
            submitButton.TabIndex = 36;
            submitButton.Text = "Создать документы";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += OnSubmitClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(cost);
            groupBox5.Controls.Add(label9);
            groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            groupBox5.ForeColor = System.Drawing.Color.White;
            groupBox5.Location = new System.Drawing.Point(2, 478);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(360, 57);
            groupBox5.TabIndex = 35;
            groupBox5.TabStop = false;
            groupBox5.Text = "Итого";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(1, 21);
            label5.Name = "label5";
            label5.Padding = new Padding(4);
            label5.Size = new System.Drawing.Size(169, 27);
            label5.TabIndex = 32;
            label5.Text = "СУММА К ОПЛАТЕ";
            // 
            // cost
            // 
            cost.Location = new System.Drawing.Point(173, 23);
            cost.Margin = new Padding(3, 2, 3, 2);
            cost.Name = "cost";
            cost.Size = new System.Drawing.Size(114, 25);
            cost.TabIndex = 23;
            cost.Text = "0,00";
            cost.TextAlign = HorizontalAlignment.Center;
            cost.TextChanged += tbox_price_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Cursor = Cursors.No;
            label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label9.Location = new System.Drawing.Point(290, 21);
            label9.Name = "label9";
            label9.Padding = new Padding(4);
            label9.Size = new System.Drawing.Size(67, 27);
            label9.TabIndex = 29;
            label9.Text = "рублей";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(srcRouteTextBox);
            groupBox4.Controls.Add(dstRouteTextBox);
            groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            groupBox4.ForeColor = System.Drawing.Color.White;
            groupBox4.Location = new System.Drawing.Point(424, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(256, 88);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Маршрут";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(bicTextBox);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(correspondentAccountTextBox);
            groupBox3.Controls.Add(innTextBox);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(settlementAccountTextBox);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(lable11);
            groupBox3.Controls.Add(bankTextBox);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(companyTextBox);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(addressTextBox);
            groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            groupBox3.ForeColor = System.Drawing.Color.White;
            groupBox3.Location = new System.Drawing.Point(2, 133);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(641, 339);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Информация о плательщике";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label15.Location = new System.Drawing.Point(43, 86);
            label15.Name = "label15";
            label15.Padding = new Padding(4);
            label15.Size = new System.Drawing.Size(53, 27);
            label15.TabIndex = 30;
            label15.Text = "ИНН";
            // 
            // innTextBox
            // 
            innTextBox.HidePromptOnLeave = true;
            innTextBox.InsertKeyMode = InsertKeyMode.Overwrite;
            innTextBox.Location = new System.Drawing.Point(102, 88);
            innTextBox.Margin = new Padding(3, 2, 3, 2);
            innTextBox.Mask = "0 0 0 0 0 0 0 0 0 0 0 0";
            innTextBox.Name = "innTextBox";
            innTextBox.Size = new System.Drawing.Size(147, 25);
            innTextBox.TabIndex = 13;
            innTextBox.TextAlign = HorizontalAlignment.Center;
            innTextBox.KeyPress += IsDigit_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(codeTextBox);
            groupBox1.Controls.Add(kppRadioButton);
            groupBox1.Controls.Add(ogrnipRadioButton);
            groupBox1.Controls.Add(ogrnRadioButton);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(14, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(241, 78);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Код";
            // 
            // codeTextBox
            // 
            codeTextBox.HidePromptOnLeave = true;
            codeTextBox.InsertKeyMode = InsertKeyMode.Overwrite;
            codeTextBox.Location = new System.Drawing.Point(6, 41);
            codeTextBox.Margin = new Padding(3, 2, 3, 2);
            codeTextBox.Mask = "0 0 0 0 0 0 0 0 0 0 0 0 0";
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new System.Drawing.Size(229, 25);
            codeTextBox.TabIndex = 18;
            codeTextBox.TextAlign = HorizontalAlignment.Center;
            codeTextBox.KeyPress += IsDigit_KeyPress;
            // 
            // kppRadioButton
            // 
            kppRadioButton.AutoSize = true;
            kppRadioButton.Cursor = Cursors.Hand;
            kppRadioButton.Location = new System.Drawing.Point(183, 15);
            kppRadioButton.Name = "kppRadioButton";
            kppRadioButton.Size = new System.Drawing.Size(54, 21);
            kppRadioButton.TabIndex = 17;
            kppRadioButton.Text = "КПП";
            kppRadioButton.UseVisualStyleBackColor = true;
            kppRadioButton.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // ogrnipRadioButton
            // 
            ogrnipRadioButton.AutoSize = true;
            ogrnipRadioButton.Cursor = Cursors.Hand;
            ogrnipRadioButton.Location = new System.Drawing.Point(88, 15);
            ogrnipRadioButton.Name = "ogrnipRadioButton";
            ogrnipRadioButton.Size = new System.Drawing.Size(81, 21);
            ogrnipRadioButton.TabIndex = 16;
            ogrnipRadioButton.Text = "ОГРНИП";
            ogrnipRadioButton.UseVisualStyleBackColor = true;
            ogrnipRadioButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // ogrnRadioButton
            // 
            ogrnRadioButton.AutoSize = true;
            ogrnRadioButton.Checked = true;
            ogrnRadioButton.Cursor = Cursors.Hand;
            ogrnRadioButton.Location = new System.Drawing.Point(11, 15);
            ogrnRadioButton.Name = "ogrnRadioButton";
            ogrnRadioButton.Size = new System.Drawing.Size(61, 21);
            ogrnRadioButton.TabIndex = 15;
            ogrnRadioButton.TabStop = true;
            ogrnRadioButton.Text = "ОГРН";
            ogrnRadioButton.UseVisualStyleBackColor = true;
            ogrnRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(payerContractDate);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(actDate);
            groupBox2.Controls.Add(actNumberTextBox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(checkNumberTextBox);
            groupBox2.Controls.Add(payerContractNumberTextBox);
            groupBox2.Controls.Add(checkDate);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            groupBox2.ForeColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(415, 120);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Документы";
            // 
            // payerContractDate
            // 
            payerContractDate.CustomFormat = "dd MMMM yyyy г.";
            payerContractDate.Format = DateTimePickerFormat.Custom;
            payerContractDate.Location = new System.Drawing.Point(252, 84);
            payerContractDate.Margin = new Padding(3, 2, 3, 2);
            payerContractDate.Name = "payerContractDate";
            payerContractDate.Size = new System.Drawing.Size(157, 25);
            payerContractDate.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 500;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            errorProvider1.ContainerControl = this;
            // 
            // CheckAct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.SystemColors.WindowFrame;
            ClientSize = new System.Drawing.Size(707, 562);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "CheckAct";
            Text = "Создание документов Счёт и Акт";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label lable11;
        private Label label12;
        private Label label13;
        private MaskedTextBox bicTextBox;
        private MaskedTextBox correspondentAccountTextBox;
        private MaskedTextBox settlementAccountTextBox;
        private TextBox bankTextBox;
        private TextBox payerContractNumberTextBox;
        private TextBox addressTextBox;
        private TextBox companyTextBox;
        private TextBox actNumberTextBox;
        private TextBox checkNumberTextBox;
        private TextBox dstRouteTextBox;
        private TextBox srcRouteTextBox;
        private DateTimePicker actDate;
        private DateTimePicker checkDate;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton kppRadioButton;
        private RadioButton ogrnipRadioButton;
        private RadioButton ogrnRadioButton;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label15;
        private MaskedTextBox innTextBox;
        private MaskedTextBox codeTextBox;
        private GroupBox groupBox4;
        private TextBox cost;
        private Label label5;
        private Label label9;
        private Button submitButton;
        private GroupBox groupBox5;
        private ErrorProvider errorProvider1;
        private DateTimePicker payerContractDate;
    }
}