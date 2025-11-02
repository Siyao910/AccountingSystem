namespace Accounting
{
    partial class FormMain
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
            labelCost = new Label();
            labelIncome = new Label();
            labelBalance = new Label();
            buttonRecord = new Button();
            buttonCheck = new Button();
            comboBoxMonth = new ComboBox();
            label1 = new Label();
            buttonEnd = new Button();
            SuspendLayout();
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCost.Location = new Point(30, 113);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(77, 25);
            labelCost.TabIndex = 3;
            labelCost.Text = "月支出:";
            // 
            // labelIncome
            // 
            labelIncome.AutoSize = true;
            labelIncome.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelIncome.Location = new Point(30, 163);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new Size(77, 25);
            labelIncome.TabIndex = 4;
            labelIncome.Text = "月收入:";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelBalance.Location = new Point(30, 214);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(77, 25);
            labelBalance.TabIndex = 5;
            labelBalance.Text = "月結餘:";
            // 
            // buttonRecord
            // 
            buttonRecord.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonRecord.Location = new Point(220, 113);
            buttonRecord.Name = "buttonRecord";
            buttonRecord.Size = new Size(100, 35);
            buttonRecord.TabIndex = 6;
            buttonRecord.Text = "記帳";
            buttonRecord.UseVisualStyleBackColor = true;
            buttonRecord.Click += buttonRecord_Click;
            // 
            // buttonCheck
            // 
            buttonCheck.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonCheck.Location = new Point(220, 163);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(100, 35);
            buttonCheck.TabIndex = 7;
            buttonCheck.Text = "查看紀錄";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(163, 55);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(151, 27);
            comboBoxMonth.TabIndex = 8;
            comboBoxMonth.SelectedIndexChanged += comboBoxMonth_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(30, 57);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 9;
            label1.Text = "請選擇月份:";
            // 
            // buttonEnd
            // 
            buttonEnd.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonEnd.Location = new Point(220, 214);
            buttonEnd.Name = "buttonEnd";
            buttonEnd.Size = new Size(100, 35);
            buttonEnd.TabIndex = 10;
            buttonEnd.Text = "結束";
            buttonEnd.UseVisualStyleBackColor = true;
            buttonEnd.Click += buttonEnd_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 338);
            Controls.Add(buttonEnd);
            Controls.Add(label1);
            Controls.Add(comboBoxMonth);
            Controls.Add(buttonCheck);
            Controls.Add(buttonRecord);
            Controls.Add(labelBalance);
            Controls.Add(labelIncome);
            Controls.Add(labelCost);
            Name = "FormMain";
            Text = "2024年 收入支出記帳";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCost;
        private Label labelIncome;
        private Label labelBalance;
        private Button buttonRecord;
        private Button buttonCheck;
        private ComboBox comboBoxMonth;
        private Label label1;
        private Button buttonEnd;
    }
}
