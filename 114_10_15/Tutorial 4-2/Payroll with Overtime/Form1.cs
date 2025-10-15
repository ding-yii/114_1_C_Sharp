using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal BASE_HOURS = 40m;
            const decimal OT_MULTIPLIER = 1.5m;

            decimal hoursWorked;
            decimal hourlyPayRate;
            decimal grossPay;
            try
            {
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;

                }
                else
                {
                    grossPay = (BASE_HOURS * hourlyPayRate) +
                        ((hoursWorked - BASE_HOURS) * hourlyPayRate * OT_MULTIPLIER);
                }
                grossPayLabel.TextAlign = ContentAlignment.MiddleCenter;
                grossPayLabel.Text = grossPay.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
           hourlyPayRatePromptLabel.Text = "";
            hoursWorkedPromptLabel.Text = "";
            grossPayLabel.Text = "";
        }
            
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
