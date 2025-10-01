using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Showdate_Click(object sender, EventArgs e)
        {
            string dayOfWeek = DayofweekTextBox.Text;
            string month = MonthTextBox.Text;
            string year =YearTextBox.Text;
            string dayofmonth = DayofmonthTextBox.Text;

            string output = year + " 年 " + month+ " 月 "  + dayofmonth+" 日 " + " 星期 " + dayOfWeek;

            DateOutputLabel.Text = output;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DayofweekTextBox.Text = "";
            DayofmonthTextBox.Text = "";
            MonthTextBox.Text = "";
            YearTextBox.Text = "";
            DateOutputLabel.Text = "";
        }
    }
}
