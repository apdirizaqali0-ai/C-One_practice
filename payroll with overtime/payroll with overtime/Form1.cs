using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hoursWorked;
            double hourlyPayRate;
            double grossPay;

            hoursWorked = double.Parse(txtHoursWorked.Text);
            hourlyPayRate = double.Parse(txtHourlyPayRate.Text);

            if (hoursWorked <= 40)
            {
                grossPay = hoursWorked * hourlyPayRate;
            }
            else
            {
                grossPay = (40 * hourlyPayRate) +
                           ((hoursWorked - 40) * hourlyPayRate * 1.5);
            }

            txtGrossPay.Text = grossPay.ToString("C2");

          
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            
        {
            txtHoursWorked.Clear();
            txtHourlyPayRate.Clear();
            txtGrossPay.Clear();

            txtHoursWorked.Focus();
        }
    }

        private void btnExite_Click(object sender, EventArgs e)
        {
            
        {
            this.Close();
        }
    }
    }
}
