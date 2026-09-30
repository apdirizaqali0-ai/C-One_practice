using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_room_booking_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNights_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string GuestName, RoomType;
                int NumberOfNights, PriceNight;

                //
                GuestName = lblGuestName.Text;
                RoomType = lblRoomType.Text;

                //
                NumberOfNights = int.Parse(txtNights.Text);
                PriceNight = int.Parse(txtPriceNight.Text);


                Double ServiceTax, Total, Discount;

                ServiceTax = (NumberOfNights * PriceNight) * 0.10;
                Discount = (NumberOfNights * PriceNight) * 0.05;
                Total = (NumberOfNights * PriceNight) + ServiceTax - Discount;



                //output
                txtServiceTaxt.Text = ServiceTax.ToString();
               txtDiscountAmount.Text = Discount.ToString();  
               txtTotalAmount.Text = Total.ToString();





            }
            catch (Exception ex)
            {
                MessageBox.Show("Sir there is something wrong please Re correct your code. Error: " + ex.Message);



            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtRoomType.Clear();
            txtNights.Clear();
            txtPriceNight.Clear();
            txtServiceTaxt.Clear();
            txtDiscountAmount.Clear();
            txtTotalAmount.Clear();
        }
    }
    }

