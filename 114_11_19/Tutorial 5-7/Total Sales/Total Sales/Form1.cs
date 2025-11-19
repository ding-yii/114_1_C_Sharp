using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile; // 宣告StreamReader物件以讀取檔案
            decimal totalSales = 0.0m; // 儲存總銷售額
            decimal currentSales = 0.0m; // 儲存目前的銷售額
            try 
            {
                inputFile = File.OpenText("Sales.txt");// 開啟Sales.txt檔案
                while (!inputFile.EndOfStream)// 迴圈直到檔案結尾
                {
                    currentSales = decimal.Parse(inputFile.ReadLine());// 讀取目前的銷售額
                    totalSales += currentSales;// 將目前的銷售額加到總銷售額
                }
                inputFile.Close();// 關閉檔案
                totalLabel.Text = totalSales.ToString("c");// 顯示總銷售額
            }
            catch(Exception ex)
            {
                MessageBox.Show("發生錯誤"+ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
