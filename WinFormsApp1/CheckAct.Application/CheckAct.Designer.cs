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
            this.components = new System.ComponentModel.Container();
            this.tbox_BIC = new System.Windows.Forms.MaskedTextBox();
            this.tbox_correspondentAccount = new System.Windows.Forms.MaskedTextBox();
            this.tbox_currentAccount = new System.Windows.Forms.MaskedTextBox();
            this.bank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lable11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbox_where = new System.Windows.Forms.TextBox();
            this.tbox_from = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contractNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTime_check = new System.Windows.Forms.DateTimePicker();
            this.dateTime_act = new System.Windows.Forms.DateTimePicker();
            this.tbox_check = new System.Windows.Forms.TextBox();
            this.tbox_act = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbox_TIN = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_code = new System.Windows.Forms.MaskedTextBox();
            this.rb_KPP = new System.Windows.Forms.RadioButton();
            this.rb_OGRNIP = new System.Windows.Forms.RadioButton();
            this.rb_OGRN = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTime_Contract = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_BIC
            // 
            this.tbox_BIC.HidePromptOnLeave = true;
            this.tbox_BIC.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.tbox_BIC.Location = new System.Drawing.Point(62, 291);
            this.tbox_BIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_BIC.Mask = "0 0  0 0  0 0  0 0 0";
            this.tbox_BIC.Name = "tbox_BIC";
            this.tbox_BIC.Size = new System.Drawing.Size(131, 25);
            this.tbox_BIC.TabIndex = 22;
            this.tbox_BIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_BIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // tbox_correspondentAccount
            // 
            this.tbox_correspondentAccount.HidePromptOnLeave = true;
            this.tbox_correspondentAccount.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.tbox_correspondentAccount.Location = new System.Drawing.Point(62, 262);
            this.tbox_correspondentAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_correspondentAccount.Mask = "0 0 0  0 0  0 0 0  0  0 0 0 0  0 0 0 0 0 0 0";
            this.tbox_correspondentAccount.Name = "tbox_correspondentAccount";
            this.tbox_correspondentAccount.Size = new System.Drawing.Size(250, 25);
            this.tbox_correspondentAccount.TabIndex = 21;
            this.tbox_correspondentAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_correspondentAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // tbox_currentAccount
            // 
            this.tbox_currentAccount.HidePromptOnLeave = true;
            this.tbox_currentAccount.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.tbox_currentAccount.Location = new System.Drawing.Point(62, 235);
            this.tbox_currentAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_currentAccount.Mask = "0 0 0  0 0  0 0 0  0  0 0 0 0  0 0 0 0 0 0 0";
            this.tbox_currentAccount.Name = "tbox_currentAccount";
            this.tbox_currentAccount.Size = new System.Drawing.Size(250, 25);
            this.tbox_currentAccount.TabIndex = 20;
            this.tbox_currentAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_currentAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // bank
            // 
            this.bank.Location = new System.Drawing.Point(62, 206);
            this.bank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(363, 25);
            this.bank.TabIndex = 19;
            this.bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(19, 48);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(4);
            this.label8.Size = new System.Drawing.Size(52, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Куда";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(20, 233);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(4);
            this.label10.Size = new System.Drawing.Size(41, 27);
            this.label10.TabIndex = 9;
            this.label10.Text = "Р/С";
            // 
            // lable11
            // 
            this.lable11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lable11.AutoSize = true;
            this.lable11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lable11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lable11.Location = new System.Drawing.Point(19, 260);
            this.lable11.Name = "lable11";
            this.lable11.Padding = new System.Windows.Forms.Padding(4);
            this.lable11.Size = new System.Drawing.Size(44, 27);
            this.lable11.TabIndex = 10;
            this.lable11.Text = "К/С";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(5, 208);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(4);
            this.label12.Size = new System.Drawing.Size(54, 27);
            this.label12.TabIndex = 11;
            this.label12.Text = "Банк";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(9, 291);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(4);
            this.label13.Size = new System.Drawing.Size(52, 27);
            this.label13.TabIndex = 12;
            this.label13.Text = "БИК";
            // 
            // tbox_where
            // 
            this.tbox_where.Location = new System.Drawing.Point(77, 50);
            this.tbox_where.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_where.Name = "tbox_where";
            this.tbox_where.Size = new System.Drawing.Size(173, 25);
            this.tbox_where.TabIndex = 9;
            this.tbox_where.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_from
            // 
            this.tbox_from.Location = new System.Drawing.Point(77, 21);
            this.tbox_from.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_from.Name = "tbox_from";
            this.tbox_from.Size = new System.Drawing.Size(173, 25);
            this.tbox_from.TabIndex = 8;
            this.tbox_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(102, 59);
            this.address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(525, 25);
            this.address.TabIndex = 12;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(37, 55);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(59, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(2, 21);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(4);
            this.label7.Size = new System.Drawing.Size(69, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Откуда";
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(102, 28);
            this.company.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(210, 25);
            this.company.TabIndex = 11;
            this.company.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(5, 34);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Компания";
            // 
            // contractNumber
            // 
            this.contractNumber.Location = new System.Drawing.Point(159, 84);
            this.contractNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contractNumber.Name = "contractNumber";
            this.contractNumber.Size = new System.Drawing.Size(87, 25);
            this.contractNumber.TabIndex = 6;
            this.contractNumber.Text = "Б/Н";
            this.contractNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(4, 84);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4);
            this.label6.Size = new System.Drawing.Size(150, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Договор-заявка №";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счёт №";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Акт №";
            // 
            // dateTime_check
            // 
            this.dateTime_check.CustomFormat = "« dd » MMMM yyyy г.";
            this.dateTime_check.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_check.Location = new System.Drawing.Point(125, 26);
            this.dateTime_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_check.Name = "dateTime_check";
            this.dateTime_check.Size = new System.Drawing.Size(181, 25);
            this.dateTime_check.TabIndex = 3;
            // 
            // dateTime_act
            // 
            this.dateTime_act.CustomFormat = "« dd » MMMM yyyy г.";
            this.dateTime_act.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_act.Location = new System.Drawing.Point(125, 53);
            this.dateTime_act.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_act.Name = "dateTime_act";
            this.dateTime_act.Size = new System.Drawing.Size(181, 25);
            this.dateTime_act.TabIndex = 5;
            // 
            // tbox_check
            // 
            this.tbox_check.Location = new System.Drawing.Point(85, 26);
            this.tbox_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_check.MaxLength = 3;
            this.tbox_check.Name = "tbox_check";
            this.tbox_check.Size = new System.Drawing.Size(36, 25);
            this.tbox_check.TabIndex = 2;
            this.tbox_check.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_check.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // tbox_act
            // 
            this.tbox_act.Location = new System.Drawing.Point(85, 53);
            this.tbox_act.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_act.MaxLength = 3;
            this.tbox_act.Name = "tbox_act";
            this.tbox_act.Size = new System.Drawing.Size(36, 25);
            this.tbox_act.TabIndex = 4;
            this.tbox_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_act.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 542);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(499, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 45);
            this.button1.TabIndex = 36;
            this.button1.Text = "Создать документы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.price);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(2, 478);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 57);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Итого";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1, 21);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4);
            this.label5.Size = new System.Drawing.Size(169, 27);
            this.label5.TabIndex = 32;
            this.label5.Text = "СУММА К ОПЛАТЕ";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(173, 23);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(114, 25);
            this.price.TabIndex = 23;
            this.price.Text = "0,00";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.TextChanged += new System.EventHandler(this.tbox_price_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.No;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(290, 21);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(4);
            this.label9.Size = new System.Drawing.Size(67, 27);
            this.label9.TabIndex = 29;
            this.label9.Text = "рублей";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tbox_from);
            this.groupBox4.Controls.Add(this.tbox_where);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(424, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 88);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Маршрут";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.tbox_BIC);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbox_correspondentAccount);
            this.groupBox3.Controls.Add(this.tbox_TIN);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbox_currentAccount);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.lable11);
            this.groupBox3.Controls.Add(this.bank);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.company);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.address);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(2, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 339);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о плательщике";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(43, 86);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(4);
            this.label15.Size = new System.Drawing.Size(53, 27);
            this.label15.TabIndex = 30;
            this.label15.Text = "ИНН";
            // 
            // tbox_TIN
            // 
            this.tbox_TIN.HidePromptOnLeave = true;
            this.tbox_TIN.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.tbox_TIN.Location = new System.Drawing.Point(102, 88);
            this.tbox_TIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_TIN.Mask = "0 0 0 0 0 0 0 0 0 0 0 0";
            this.tbox_TIN.Name = "tbox_TIN";
            this.tbox_TIN.Size = new System.Drawing.Size(147, 25);
            this.tbox_TIN.TabIndex = 13;
            this.tbox_TIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_TIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_code);
            this.groupBox1.Controls.Add(this.rb_KPP);
            this.groupBox1.Controls.Add(this.rb_OGRNIP);
            this.groupBox1.Controls.Add(this.rb_OGRN);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 78);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Код";
            // 
            // tbox_code
            // 
            this.tbox_code.HidePromptOnLeave = true;
            this.tbox_code.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.tbox_code.Location = new System.Drawing.Point(6, 41);
            this.tbox_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_code.Mask = "0 0 0 0 0 0 0 0 0 0 0 0 0";
            this.tbox_code.Name = "tbox_code";
            this.tbox_code.Size = new System.Drawing.Size(229, 25);
            this.tbox_code.TabIndex = 18;
            this.tbox_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // rb_KPP
            // 
            this.rb_KPP.AutoSize = true;
            this.rb_KPP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_KPP.Location = new System.Drawing.Point(183, 15);
            this.rb_KPP.Name = "rb_KPP";
            this.rb_KPP.Size = new System.Drawing.Size(54, 21);
            this.rb_KPP.TabIndex = 17;
            this.rb_KPP.Text = "КПП";
            this.rb_KPP.UseVisualStyleBackColor = true;
            this.rb_KPP.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rb_OGRNIP
            // 
            this.rb_OGRNIP.AutoSize = true;
            this.rb_OGRNIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_OGRNIP.Location = new System.Drawing.Point(88, 15);
            this.rb_OGRNIP.Name = "rb_OGRNIP";
            this.rb_OGRNIP.Size = new System.Drawing.Size(81, 21);
            this.rb_OGRNIP.TabIndex = 16;
            this.rb_OGRNIP.Text = "ОГРНИП";
            this.rb_OGRNIP.UseVisualStyleBackColor = true;
            this.rb_OGRNIP.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_OGRN
            // 
            this.rb_OGRN.AutoSize = true;
            this.rb_OGRN.Checked = true;
            this.rb_OGRN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_OGRN.Location = new System.Drawing.Point(11, 15);
            this.rb_OGRN.Name = "rb_OGRN";
            this.rb_OGRN.Size = new System.Drawing.Size(61, 21);
            this.rb_OGRN.TabIndex = 15;
            this.rb_OGRN.TabStop = true;
            this.rb_OGRN.Text = "ОГРН";
            this.rb_OGRN.UseVisualStyleBackColor = true;
            this.rb_OGRN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTime_Contract);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTime_act);
            this.groupBox2.Controls.Add(this.tbox_act);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbox_check);
            this.groupBox2.Controls.Add(this.contractNumber);
            this.groupBox2.Controls.Add(this.dateTime_check);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Документы";
            // 
            // dateTime_Contract
            // 
            this.dateTime_Contract.CustomFormat = "dd MMMM yyyy г.";
            this.dateTime_Contract.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_Contract.Location = new System.Drawing.Point(252, 84);
            this.dateTime_Contract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_Contract.Name = "dateTime_Contract";
            this.dateTime_Contract.Size = new System.Drawing.Size(157, 25);
            this.dateTime_Contract.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 500;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(707, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Создание документов Счёт и Акт";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

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
        private MaskedTextBox tbox_BIC;
        private MaskedTextBox tbox_correspondentAccount;
        private MaskedTextBox tbox_currentAccount;
        private TextBox bank;
        private TextBox contractNumber;
        private TextBox address;
        private TextBox company;
        private TextBox tbox_act;
        private TextBox tbox_check;
        private TextBox tbox_where;
        private TextBox tbox_from;
        private DateTimePicker dateTime_act;
        private DateTimePicker dateTime_check;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton rb_KPP;
        private RadioButton rb_OGRNIP;
        private RadioButton rb_OGRN;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label15;
        private MaskedTextBox tbox_TIN;
        private MaskedTextBox tbox_code;
        private GroupBox groupBox4;
        private TextBox price;
        private Label label5;
        private Label label9;
        private Button button1;
        private GroupBox groupBox5;
        private ErrorProvider errorProvider1;
        private DateTimePicker dateTime_Contract;
    }
}