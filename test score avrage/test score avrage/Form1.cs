using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_score_avrage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
           
            double score1, score2, score3;

            if (double.TryParse(txtTestScore1.Text, out score1) &&
                double.TryParse(txtTestScore2.Text, out score2) &&
                double.TryParse(txtTestScore3.Text, out score3))
            {
                double average = (score1 + score2 + score3) / 3;

                txtAverage.Text = average.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        {
            txtTestScore1.Clear();
            txtTestScore2.Clear();
            txtTestScore3.Clear();
            txtAverage.Clear();

            txtTestScore1.Focus();
        }
    }

        private void btnExit_Click(object sender, EventArgs e)
        {
             
        {
            this.Close();
        }
    }
    }
    }

