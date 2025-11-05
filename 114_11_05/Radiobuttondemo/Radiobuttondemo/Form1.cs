using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiobuttondemo
{
    public partial class juice : Form
    {
        public juice()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "點餐內容:";
            String drink = "";
            String sandwich = "";

            if (coffee.Checked)
            {
                drink = "咖啡";
            }
            else if (milktea.Checked)
            {
                drink = "奶茶";
            }
            else if (blacktea.Checked)
            {
                drink = "紅茶";
            }
                else if (juiceradioButton.Checked)
            {
                drink = "果汁";
            }
            else {                 drink = "無飲料";
            }
            if (jellysandwich.Checked)
            {
                sandwich = "果醬三明治";
            }
            else if (hamsandwich.Checked)
            {
                sandwich = "火腿三明治";
            }
            else if (fishsandwich.Checked)
            {
                sandwich = "鮪魚三明治";
                   
            }
            else
            {
                sandwich = "無三明治";
            }
            message += "\n飲料:" + drink;
            message += "\n三明治:" + sandwich;
            MessageBox.Show(message, "點餐結果");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

