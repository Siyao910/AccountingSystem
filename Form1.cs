namespace Accounting
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //宣告字串(月份)
        string[] month = { "一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" };

        //按<記帳>按鈕時
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            //開啟記帳表單
            FormRecord f1 = new FormRecord();
            f1.ShowDialog();
        }

        //按<查看紀錄>按鈕時
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //開啟查看紀錄表單
            FormCheck f1 = new FormCheck();
            f1.ShowDialog();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {

        }

        //按<結束>按紐時
        private void buttonEnd_Click_1(object sender, EventArgs e)
        {
            //結束程式
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //將字串陣列新增至下拉選單
            comboBoxMonth.Items.AddRange(month);
        }

        //當選擇月份時
        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //顯示該月份之收入、支出與結餘
            if (comboBoxMonth.SelectedIndex == 0)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income1)+"元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense1) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total1) + "元";
            }
            if (comboBoxMonth.SelectedIndex == 1)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income2) + "元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense2) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total2) + "元";
            }
            if (comboBoxMonth.SelectedIndex == 2)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income3) + "元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense3) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total3) + "元";
            }
            if (comboBoxMonth.SelectedIndex == 3)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income4) + "元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense4) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total4) + "元";
            }
            if (comboBoxMonth.SelectedIndex == 4)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income5) + "元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense5) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total5) + "元";
            }
            if (comboBoxMonth.SelectedIndex == 5)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income6) + "元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense6) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total6) + "元";
            }
            if (comboBoxMonth.SelectedIndex == 6)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income7) + "元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense7) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total7) + "元";
            }
            if (comboBoxMonth.SelectedIndex == 7)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income8) + "元";
                labelCost.Text  = "月支出: " + Convert.ToString(FormRecord.expense8) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total8) + "元";
            }
            if (comboBoxMonth.SelectedIndex == 8)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income9) + "元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense9) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total9) + "元";
            }
            if (comboBoxMonth.SelectedIndex == 9)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income10) + "元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense10) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total10) + "元";
            }
            if (comboBoxMonth.SelectedIndex == 10)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income11) + "元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense11) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total11) + "元";

            }
            if (comboBoxMonth.SelectedIndex == 11)
            {
                labelIncome.Text = "月收入: " + Convert.ToString(FormRecord.income12) + "元";
                labelCost.Text = "月支出: " + Convert.ToString(FormRecord.expense12) + "元";
                labelBalance.Text = "月結餘: " + Convert.ToString(FormRecord.total12) + "元";
            }
        }
    }
}
