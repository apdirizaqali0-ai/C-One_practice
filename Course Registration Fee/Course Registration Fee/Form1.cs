using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_Fee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
        {
            // Read the input values
            string studentName = txtName.Text.Trim();
            string studentId = txtId.Text.Trim();

            // Validate the input values
            if (studentName == "" || studentId == "")
            {
                MessageBox.Show("Please enter Student Name and Student ID.");
                return;
            }

            int numberOfCourses;
            int studyLevel;
            decimal transportFee;

            if (!int.TryParse(txtCourses.Text, out numberOfCourses) ||
                numberOfCourses <= 0)
            {
                MessageBox.Show("Please enter a valid number of courses.");
                return;
            }

            if (!int.TryParse(txtLevel.Text, out studyLevel) ||
                studyLevel <= 0)
            {
                MessageBox.Show("Please enter a valid Study Level.");
                return;
            }

            if (!decimal.TryParse(txtTransport.Text, out transportFee) ||
                transportFee < 0)
            {
                MessageBox.Show("Please enter a valid Transport Fee.");
                return;
            }

            // Calculate the fees
            decimal tuitionFee = numberOfCourses * 50;
            decimal discount = tuitionFee * 0.10m;
            decimal finalAmount = tuitionFee - discount + transportFee;

            // Display the results
            txtNameResult.Text = "name: " + studentName;
            txtIdResult.Text ="id: " + studentId;
            txtCoursesResult.Text = "Coursr: " +numberOfCourses.ToString();
            txtLevelResult.Text = "Level :"+studyLevel.ToString();

            txtTransportResult.Text = "Trasport: "+transportFee.ToString("0.##");
            txtDiscountResult.Text = "Discount: "+discount.ToString("0.##");
            txtTuitionResult.Text = "tuitionFee: "+tuitionFee.ToString("0.##");
            txtFinalResult.Text = "finalAmount: "+finalAmount.ToString("0.##");
        }
    }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        {
            // Clear input TextBoxes
            txtName.Clear();
            txtId.Clear();
            txtCourses.Clear();
            txtLevel.Clear();
            txtTransport.Clear();

            // Clear result TextBoxes
            txtNameResult.Clear();
            txtIdResult.Clear();
            txtCoursesResult.Clear();
            txtLevelResult.Clear();
            txtTransportResult.Clear();
            txtDiscountResult.Clear();
            txtTuitionResult.Clear();
            txtFinalResult.Clear();

            // Put the cursor back in Student Name
            txtName.Focus();
        }
    }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    }
}
