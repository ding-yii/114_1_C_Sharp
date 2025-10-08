using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算特價」按鈕時執行
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告三個 decimal 變數：原價、折扣百分比、特價
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;
            // 從文字方塊讀取原價和折扣百分比，並計算特價
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);
            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 當使用者按下「離開」按鈕時執行，關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        // 特價標籤被點擊時執行（目前未使用）
        private void salePriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
