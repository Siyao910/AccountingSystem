namespace Accounting
{
    partial class FormCheck
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBoxMsg = new TextBox();
            buttonOk = new Button();
            buttoEnd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(67, 59);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 0;
            label1.Text = "請選擇欲查看之月份:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(67, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 27);
            comboBox1.TabIndex = 1;
            // 
            // textBoxMsg
            // 
            textBoxMsg.Location = new Point(67, 181);
            textBoxMsg.Multiline = true;
            textBoxMsg.Name = "textBoxMsg";
            textBoxMsg.ReadOnly = true;
            textBoxMsg.ScrollBars = ScrollBars.Vertical;
            textBoxMsg.Size = new Size(320, 347);
            textBoxMsg.TabIndex = 3;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(293, 111);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "確定";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttoEnd
            // 
            buttoEnd.Location = new Point(415, 499);
            buttoEnd.Name = "buttoEnd";
            buttoEnd.Size = new Size(94, 29);
            buttoEnd.TabIndex = 5;
            buttoEnd.Text = "結束";
            buttoEnd.UseVisualStyleBackColor = true;
            buttoEnd.Click += buttoEnd_Click;
            // 
            // FormCheck
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 613);
            Controls.Add(buttoEnd);
            Controls.Add(buttonOk);
            Controls.Add(textBoxMsg);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FormCheck";
            Text = "查看紀錄";
            Load += FormCheck_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBoxMsg;
        private Button buttonOk;
        private Button buttoEnd;
    }
}