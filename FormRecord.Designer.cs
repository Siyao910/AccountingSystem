namespace Accounting
{
    partial class FormRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            radioButtonIncome = new RadioButton();
            radioButtonExpense = new RadioButton();
            comboBoxIncome = new ComboBox();
            comboBoxExpense = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBoxMoney = new TextBox();
            label4 = new Label();
            buttonSend = new Button();
            buttonClear = new Button();
            buttonEnd = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(185, 35);
            dateTimePicker1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2024, 5, 25, 23, 59, 59, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(50, 35);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 1;
            label1.Text = "請選擇日期:";
            // 
            // radioButtonIncome
            // 
            radioButtonIncome.AutoSize = true;
            radioButtonIncome.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            radioButtonIncome.Location = new Point(50, 145);
            radioButtonIncome.Name = "radioButtonIncome";
            radioButtonIncome.Size = new Size(73, 29);
            radioButtonIncome.TabIndex = 2;
            radioButtonIncome.TabStop = true;
            radioButtonIncome.Text = "收入";
            radioButtonIncome.UseVisualStyleBackColor = true;
            radioButtonIncome.CheckedChanged += radioButtonIncome_CheckedChanged_1;
            // 
            // radioButtonExpense
            // 
            radioButtonExpense.AutoSize = true;
            radioButtonExpense.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            radioButtonExpense.Location = new Point(50, 291);
            radioButtonExpense.Name = "radioButtonExpense";
            radioButtonExpense.Size = new Size(73, 29);
            radioButtonExpense.TabIndex = 3;
            radioButtonExpense.TabStop = true;
            radioButtonExpense.Text = "支出";
            radioButtonExpense.UseVisualStyleBackColor = true;
            radioButtonExpense.CheckedChanged += radioButtonExpense_CheckedChanged_1;
            // 
            // comboBoxIncome
            // 
            comboBoxIncome.FormattingEnabled = true;
            comboBoxIncome.Location = new Point(50, 226);
            comboBoxIncome.Name = "comboBoxIncome";
            comboBoxIncome.Size = new Size(191, 27);
            comboBoxIncome.TabIndex = 4;
            // 
            // comboBoxExpense
            // 
            comboBoxExpense.FormattingEnabled = true;
            comboBoxExpense.Location = new Point(50, 369);
            comboBoxExpense.Name = "comboBoxExpense";
            comboBoxExpense.Size = new Size(191, 27);
            comboBoxExpense.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(50, 193);
            label2.Name = "label2";
            label2.Size = new Size(194, 22);
            label2.TabIndex = 6;
            label2.Text = "請選擇項目(可自行新增):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(50, 335);
            label3.Name = "label3";
            label3.Size = new Size(194, 22);
            label3.TabIndex = 7;
            label3.Text = "請選擇項目(可自行新增):";
            // 
            // textBoxMoney
            // 
            textBoxMoney.Location = new Point(185, 85);
            textBoxMoney.Name = "textBoxMoney";
            textBoxMoney.Size = new Size(207, 27);
            textBoxMoney.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(50, 87);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 9;
            label4.Text = "請輸入金額:";
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(298, 317);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(94, 29);
            buttonSend.TabIndex = 10;
            buttonSend.Text = "送出";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(298, 269);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "清除";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonEnd
            // 
            buttonEnd.Location = new Point(298, 369);
            buttonEnd.Name = "buttonEnd";
            buttonEnd.Size = new Size(94, 29);
            buttonEnd.TabIndex = 12;
            buttonEnd.Text = "結束";
            buttonEnd.UseVisualStyleBackColor = true;
            buttonEnd.Click += buttonEnd_Click;
            // 
            // FormRecord
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 458);
            Controls.Add(buttonEnd);
            Controls.Add(buttonClear);
            Controls.Add(buttonSend);
            Controls.Add(label4);
            Controls.Add(textBoxMoney);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxExpense);
            Controls.Add(comboBoxIncome);
            Controls.Add(radioButtonExpense);
            Controls.Add(radioButtonIncome);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "FormRecord";
            Text = "記帳表單";
            Load += FormRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private RadioButton radioButtonIncome;
        private RadioButton radioButtonExpense;
        private ComboBox comboBoxIncome;
        private ComboBox comboBoxExpense;
        private Label label2;
        private Label label3;
        private TextBox textBoxMoney;
        private Label label4;
        private Button buttonSend;
        private Button buttonClear;
        private Button buttonEnd;
    }
}