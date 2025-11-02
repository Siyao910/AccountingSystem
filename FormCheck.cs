using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class FormCheck : Form
    {
        public FormCheck()
        {
            InitializeComponent();
        }
        //宣告字串(月份)
        string[] month = { "一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" };

        private void FormCheck_Load(object sender, EventArgs e)
        {
            //將字串陣列新增至下拉選單
            comboBox1.Items.AddRange(month);

        }

        //按<確定>按鈕時
        private void buttonOk_Click(object sender, EventArgs e)
        {
            textBoxMsg.Text = $"{comboBox1.SelectedItem}記帳紀錄\r\n\r\n";
            //將使用者先前輸入的資料顯示於文字方塊

            //選擇一月時
            if (comboBox1.SelectedIndex == 0)
            {
                //將使用者填寫之一月資料顯示於textBox
                textBoxMsg.Text += FormRecord.msg1;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBoxMsg.Text += FormRecord.msg2;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBoxMsg.Text += FormRecord.msg3;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBoxMsg.Text += FormRecord.msg4;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                textBoxMsg.Text += FormRecord.msg5;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                textBoxMsg.Text += FormRecord.msg6;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                textBoxMsg.Text += FormRecord.msg7;
            }
            if (comboBox1.SelectedIndex == 7)
            {
                textBoxMsg.Text += FormRecord.msg8;
            }
            if (comboBox1.SelectedIndex == 8)
            {
                textBoxMsg.Text += FormRecord.msg9;
            }
            if (comboBox1.SelectedIndex == 9)
            {
                textBoxMsg.Text += FormRecord.msg10;
            }
            if (comboBox1.SelectedIndex == 10)
            {
                textBoxMsg.Text += FormRecord.msg11;
            }
            if (comboBox1.SelectedIndex == 11)
            {
                textBoxMsg.Text += FormRecord.msg12;
            }
            
        }

        //當按<結束>按鈕
        private void buttoEnd_Click(object sender, EventArgs e)
        {
            //關閉此表單
            this.Close();
        }
    }
}
