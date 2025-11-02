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
    public partial class FormRecord : Form
    {
        public FormRecord()
        {
            InitializeComponent();
        }
        //宣告字串陣列
        string[] income = { "薪水", "獎金", "股息", "租金", "投資" };
        string[] expense = { "早餐", "午餐", "晚餐", "點心", "交通", "娛樂", "日用品", "房租" };

        //宣告字串(各月分之收入支出紀錄)
        public static string msg1, msg2, msg3, msg4, msg5, msg6, msg7, msg8, msg9, msg10, msg11, msg12 = "";

        //宣告整數(各月分之收入總金額)
        public static int income1, income2, income3, income4, income5, income6, income7, income8, income9, income10, income11, income12 = 0;

        //宣告整數(各月分之支出總金額)
        public static int expense1, expense2, expense3, expense4, expense5, expense6, expense7, expense8, expense9, expense10, expense11, expense12 = 0;

        //宣告整數(各月份之結餘)
        public static int total1, total2, total3, total4, total5, total6, total7, total8, total9, total10, total11, total12 = 0;

        //按<送出>按鈕時
        private void buttonSend_Click(object sender, EventArgs e)
        {
            //選擇一月
            if (dateTimePicker1.Value.Month == 1)
            {

                //當"收入"按鈕被選擇時
                if (radioButtonIncome.Checked)
                {
                    //當使用者有填寫項目時
                    if (comboBoxIncome.Text != "")
                    {
                        //當使用者有填寫金額時
                        if (textBoxMoney.Text != "")
                        {
                            //將選擇的日期加入msg1
                            msg1 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";

                            //將資料加到msg1
                            msg1 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";

                            //將金額加到"一月之總收入"
                            income1 += Convert.ToInt32(textBoxMoney.Text);

                            //顯示提示訊息
                            MessageBox.Show("記帳成功!");

                            //宣告提示訊息(是否繼續記帳)之結果
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);

                            //當按<否>按鈕時
                            if (result == DialogResult.No)
                            {
                                //關閉此表單
                                this.Close();
                            }

                            //當按<是>按鈕時
                            else
                            {
                                //清除上次填寫之資料
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }

                        //當使用者未填寫金額時
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    //當使用者未填寫項目時
                    else
                    {
                        //當使用者未填寫金額時
                        if (textBoxMoney.Text == "")

                            //顯示提示訊息
                            MessageBox.Show("請輸入金額!", "注意");

                        //顯示提示訊息
                        MessageBox.Show("請選擇項目!", "注意");
                    }


                }

                //當"支出"按鈕被選擇時
                else
                {
                    //當使用者有填寫項目時
                    if (comboBoxExpense.Text != "")
                    {
                        //當使用者有填寫金額時
                        if (textBoxMoney.Text != "")
                        {
                            //將選擇的日期加入msg1
                            msg1 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";

                            //將資料加到msg1
                            msg1 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";

                            //將金額加到"一月之總支出"
                            expense1 += Convert.ToInt32(textBoxMoney.Text);

                            //顯示提示訊息
                            MessageBox.Show("記帳成功!");

                            //宣告提示訊息(是否繼續記帳)之結果
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);

                            //當按<否>按鈕時
                            if (result == DialogResult.No)
                            {
                                //關閉此表單
                                this.Close();
                            }

                            //當按<是>按鈕時
                            else
                            {
                                //清除上次填寫之資料
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }


                        }

                        //當使用者未填寫金額時
                        else
                        {
                            //顯示提示訊息
                            MessageBox.Show("請輸入金額!", "注意");

                        }
                    }

                    //當使用者未填寫項目時
                    else
                    {
                        //當使用者未填寫金額時
                        if (textBoxMoney.Text == "")
                            //顯示提示訊息
                            MessageBox.Show("請輸入金額!", "注意");
                        //顯示提示訊息SS
                        MessageBox.Show("請選擇項目!", "注意");
                    }

                }

                //結餘=收入-支出
                total1 = income1 - expense1;
                


            }

            if (dateTimePicker1.Value.Month == 2)
            {

                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg2 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg2 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income2 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");

                        }
                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {

                            msg2 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg2 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense2 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }
                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total2 = income2 - expense2;


            }


            if (dateTimePicker1.Value.Month == 3)
            {

                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg3 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg3 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income3 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg3 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg3 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense3 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total3 = income3 - expense3;
            }


            if (dateTimePicker1.Value.Month == 4)
            {
                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg4 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg4 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income4 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            if (textBoxMoney.Text == "")
                                MessageBox.Show("請輸入金額!", "注意");

                            MessageBox.Show("請選擇項目!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg4 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg4 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense4 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total4 = income4 - expense4;

            }



            if (dateTimePicker1.Value.Month == 5)
            {
                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg5 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg5 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income5 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }


                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg5 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg5 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense5 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }


                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total5 = income5 - expense5;

            }


            if (dateTimePicker1.Value.Month == 6)
            {
                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg6 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg6 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income6 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }


                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg6 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg6 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense6 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total6 = income6 - expense6;

            }


            if (dateTimePicker1.Value.Month == 7)
            {
                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg7 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg7 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income7 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg7 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg7 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense7 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }
                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total7 = income7 - expense7;


            }
            if (dateTimePicker1.Value.Month == 8)
            {
                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg8 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg8 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income8 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg8 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg8 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense8 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }


                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total8 = income8 - expense8;

            }


            if (dateTimePicker1.Value.Month == 9)
            {
                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg9 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg9 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income9 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }


                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg9 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg9 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense9 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total9 = income9 - expense9;

            }


            if (dateTimePicker1.Value.Month == 10)
            {
                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg10 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg10 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income10 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg10 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg10 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense10 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total10 = income10 - expense10;


            }
            if (dateTimePicker1.Value.Month == 11)
            {
                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg11 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg11 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income11 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg11 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg11 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense11 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }

                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total11 = income11 - expense11;

            }


            if (dateTimePicker1.Value.Month == 12)
            {
                if (radioButtonIncome.Checked)
                {
                    if (comboBoxIncome.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg12 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg12 += $"{comboBoxIncome.Text}\t$+{textBoxMoney.Text}\r\n===============\r\n";
                            income12 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }


                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                else
                {
                    if (comboBoxExpense.Text != "")
                    {
                        if (textBoxMoney.Text != "")
                        {
                            msg12 += $"{dateTimePicker1.Value.ToString("MM / dd")}\r\n";
                            msg12 += $"{comboBoxExpense.Text}\t$-{textBoxMoney.Text}\r\n===============\r\n";
                            expense12 += Convert.ToInt32(textBoxMoney.Text);
                            MessageBox.Show("記帳成功!");
                            DialogResult result = MessageBox.Show("是否繼續記帳?", "注意", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                textBoxMoney.Text = "";
                                comboBoxIncome.Text = "";
                                comboBoxExpense.Text = "";
                                radioButtonExpense.Checked = false;
                                radioButtonIncome.Checked = false;
                                radioButtonIncome.Enabled = true;
                                radioButtonExpense.Enabled = true;
                                comboBoxExpense.Enabled = true;
                                comboBoxIncome.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("請輸入金額!", "注意");
                        }
                    }
                    else
                    {
                        if (textBoxMoney.Text == "")
                            MessageBox.Show("請輸入金額!", "注意");

                        MessageBox.Show("請選擇項目!", "注意");
                    }
                }
                total12 = income12 - expense12;

            }

            


            
            

        }


        private void radioButtonIncome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormRecord_Load(object sender, EventArgs e)
        {
            //將字串陣列新增至下拉選單
            comboBoxExpense.Items.AddRange(expense);
            comboBoxIncome.Items.AddRange(income);
        }



        //選擇<收入>時
        private void radioButtonIncome_CheckedChanged_1(object sender, EventArgs e)
        {
            //"支出"之按鈕與下拉選單皆不可使用
            radioButtonExpense.Enabled = false;
            comboBoxExpense.Enabled = false;
        }

        //選擇<支出>時
        private void radioButtonExpense_CheckedChanged_1(object sender, EventArgs e)
        {
            //"收入"之按鈕與下拉選單皆不可使用
            radioButtonIncome.Enabled = false;
            comboBoxIncome.Enabled = false;
        }

        //選擇<清除>按鈕時
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //清空表單的資料
            textBoxMoney.Text = "";
            comboBoxIncome.Text = "";
            comboBoxExpense.Text = "";
            radioButtonExpense.Checked = false;
            radioButtonIncome.Checked = false;
            radioButtonIncome.Enabled = true;
            radioButtonExpense.Enabled = true;
            comboBoxExpense.Enabled = true;
            comboBoxIncome.Enabled = true;
        }

        //選擇<結束>按鈕時
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            //關閉此表單
            this.Close();
        }
    }


}

