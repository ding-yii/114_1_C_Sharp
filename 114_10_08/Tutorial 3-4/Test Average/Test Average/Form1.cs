using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算平均按鈕事件處理函式
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1, test2, test3;
            try
            {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
                double average = (test1 + test2 + test3) / 3.0;
                averageLabel.Text = average.ToString("n2");
            }
           catch(Exception ex)
            {
                MessageBox.Show( ex.Message, "例外發生!");
                // 將三個成績輸入框與平均分數標籤清空
                test1TextBox.Text = "";
                test2TextBox.Text = "";
                test3TextBox.Text = "";
                averageLabel.Text = "";
                // 將焦點設置到第一個成績輸入框
                test1TextBox.Focus();
            }
        }

        // 清除按鈕事件處理函式
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 將三個成績輸入框與平均分數標籤清空
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
            // 將焦點設置到第一個成績輸入框
            test1TextBox.Focus();
        }

        // 離開按鈕事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }
    }
}
