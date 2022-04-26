using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Fwta_Troxaias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            if ((red1.Visible) && (orange2.Visible))
            {
                red1.Visible = false;
                orange1.Visible = false;
                green1.Visible = true;
                red2.Visible = true;
                orange2.Visible = false;
                green2.Visible = false; 
            }
            else if ((red1.Visible) && (green2.Visible))
            {
                red1.Visible = true;
                orange1.Visible = false;
                green1.Visible = false;
                red2.Visible = false;
                orange2.Visible = true;
                green2.Visible = false;
            }
            else if (orange1.Visible)
            {
                red1.Visible = true;
                orange1.Visible = false;
                green1.Visible = false;
                red2.Visible = false;
                orange2.Visible = false;
                green2.Visible = true;
            }
            else if (green1.Visible)
            {
                red1.Visible = false;
                orange1.Visible = true;
                green1.Visible = false;
                red2.Visible = true;
                orange2.Visible = false;
                green2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRed1.Text) || string.IsNullOrEmpty(txtOrange1.Text) || string.IsNullOrEmpty(txtGreen1.Text) || string.IsNullOrEmpty(txtRed1.Text) || string.IsNullOrEmpty(txtOrange2.Text) || string.IsNullOrEmpty(txtGreen2.Text))
            {
                MessageBox.Show("Πρέπει να δώσεις χρόνο και για τα 6 φανάρια!");
            }            
                else
                {
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    timer4.Enabled = true;
                    timer3.Enabled = true;
                    timer5.Enabled = true;
                    timer6.Enabled = true;
            }

        }

        private int trafficcolour = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            if ((red2.Visible) && (orange1.Visible))
            {
                red2.Visible = false;
                orange2.Visible = false;
                green2.Visible = true;
                red1.Visible = true;
                orange1.Visible = false;
                green1.Visible = false;
            }
            else if ((red2.Visible) && (green1.Visible))
            {
                red2.Visible = true;
                orange2.Visible = false;
                green2.Visible = false;
                red1.Visible = false;
                orange1.Visible = true;
                green1.Visible = false;
            }
            else if (orange2.Visible)
            {
                red2.Visible = true;
                orange2.Visible = false;
                green2.Visible = false;
                red1.Visible = false;
                orange1.Visible = false;
                green1.Visible = true;
            }
            else if (green2.Visible)
            {
                red2.Visible = false;
                orange2.Visible = true;
                green2.Visible = false;
                red1.Visible = true;
                orange1.Visible = false;
                green1.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            if (CarYellow.Left + CarYellow.Size.Width <= 0)
            {
                CarYellow.Left = 700;
            }
            if (CarBlue.Top + CarBlue.Size.Height <= 0)
            {
                CarBlue.Top = 500;
            }


            trafficcolour = trafficcolour % 4;

            switch (trafficcolour)

            {
                case 0:
                    if (txtRed1.Text != "")
                        timer1.Interval = Convert.ToInt32(txtRed1.Text) * 1000; ;
                    red1.Visible = true;
                    green1.Visible = false;
                    orange1.Visible = false;
                    red2.Visible = false;
                    green2.Visible = true;
                    orange2.Visible = false;
                    break;
                case 1:
                    if (txtOrange2.Text != "")
                        timer1.Interval = Convert.ToInt32(txtOrange2.Text) * 1000; ;
                    red1.Visible = true;
                    green1.Visible = false;
                    orange1.Visible = false;
                    red2.Visible = false;
                    green2.Visible = false;
                    orange2.Visible = true;
                    break;
                case 2:
                    if (txtGreen1.Text != "")
                        timer1.Interval = Convert.ToInt32(txtGreen1.Text) * 1000; ;
                    green1.Visible = true;
                    orange1.Visible = false;
                    red1.Visible = false;
                    green2.Visible = false;
                    orange2.Visible = false;
                    red2.Visible = true;
                    break;
                case 3:
                    if (txtOrange1.Text != "")
                        timer1.Interval = Convert.ToInt32(txtOrange1.Text) * 1000; ;
                    green1.Visible = false;
                    orange1.Visible = true;
                    red1.Visible = false;
                    green2.Visible = false;
                    orange2.Visible = false;
                    red2.Visible = true;
                    break;




            }
            trafficcolour++;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((((CarBlue.Top + CarBlue.Size.Height) > (groupBox2.Top + groupBox2.Size.Height)) && (CarBlue.Top < groupBox1.Top) && (CarYellow.Left < groupBox1.Left) && (CarYellow.Left + CarYellow.Size.Width) > (groupBox2.Left + groupBox2.Size.Width)) || (((CarBlue.Top + CarBlue.Size.Height) > (groupBox2.Top + groupBox2.Size.Height)) && (CarBlue.Top < groupBox1.Top) && (CarYellow2.Left < groupBox1.Left) && (CarYellow2.Left + CarYellow2.Size.Width) > (groupBox2.Left + groupBox2.Size.Width)))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
            }
            else
            {

                if ((CarYellow.Left > groupBox1.Left) && (CarYellow.Left < groupBox1.Left + groupBox1.Size.Width) && (red1.Visible))
                {
                    CarYellow.Left = CarYellow.Left;
                }
                else
                {
                    CarYellow.Left = CarYellow.Left -= 10;
                }



                if ((CarBlue.Top + CarBlue.Size.Height / 3 >= groupBox2.Top) && (CarBlue.Top <= groupBox2.Top + groupBox2.Size.Height) && (red2.Visible))
                {
                    CarBlue.Top = CarBlue.Top;
                }
                else
                {
                    CarBlue.Top = CarBlue.Top -= 10;
                }


                if (Math.Abs(CarYellow2.Left - (CarYellow.Left + CarYellow.Size.Width)) < 10)
                {
                    CarYellow2.Left = CarYellow2.Left;
                }
                else
                {

                    if ((CarYellow2.Left > groupBox1.Left) && (CarYellow2.Left < groupBox1.Left + groupBox1.Size.Width) && (red1.Visible))
                    {
                        CarYellow2.Left = CarYellow2.Left;
                    }
                    else
                    {
                        CarYellow2.Left = CarYellow2.Left -= 10;
                    }

                }

                if ((CarYellow.Left - (CarYellow2.Left + CarYellow2.Size.Width) < 10))
                {
                    CarYellow.Left = CarYellow.Left;
                }
                else
                {

                    if ((CarYellow.Left > groupBox1.Left) && (CarYellow.Left < groupBox1.Left + groupBox1.Size.Width) && (red1.Visible))
                    {
                        CarYellow.Left = CarYellow.Left;
                    }
                    else
                    {
                        CarYellow.Left = CarYellow.Left -= 10;
                    }
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 500;


            if ((CarYellow.Left > groupBox1.Left) && (CarYellow.Left < groupBox1.Left + groupBox1.Size.Width) && (red1.Visible))
            {
                CarYellow.Left = CarYellow.Left;
            }
            else
            {
                CarYellow.Left = CarYellow.Left -= 10;
            }



            if ((CarYellow2.Left - (CarYellow.Left + CarYellow.Size.Width) < 10))
            {
                CarYellow2.Left = CarYellow2.Left;
            }
            else
            {

                if ((CarYellow2.Left > groupBox1.Left) && (CarYellow2.Left < groupBox1.Left + groupBox1.Size.Width) && (red1.Visible))
                {
                    CarYellow2.Left = CarYellow2.Left;
                }
                else
                {
                    CarYellow2.Left = CarYellow2.Left -= 10;
                }

            }

            if ((CarYellow.Left < CarYellow.Left + CarYellow2.Left + CarYellow2.Size.Width + 10))
            {
                CarYellow.Left = CarYellow.Left;
            }
            else
            {

                if ((CarYellow.Left > groupBox1.Left) && (CarYellow.Left < groupBox1.Left + groupBox1.Size.Width) && (red1.Visible))
                {
                    CarYellow.Left = CarYellow.Left;
                }
                else
                {
                    CarYellow.Left = CarYellow.Left -= 10;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Interval = 500;
            if ((CarBlue.Top + CarBlue.Size.Height / 3 >= groupBox2.Top) && (CarBlue.Top <= groupBox2.Top + groupBox2.Size.Height) && (red2.Visible))
            {
                CarBlue.Top = CarBlue.Top;
            }
            else
            {
                CarBlue.Top = CarBlue.Top -= 10;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            CarBlue.Top = 490;
            CarYellow.Left = 500;
            CarYellow2.Left = 700;
            txtRed1.Text = "";
            txtOrange1.Text = "";
            txtGreen1.Text = "";
            txtRed2.Text = "";
            txtOrange2.Text = "";
            txtGreen2.Text = "";
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (CarYellow.Left < groupBox1.Left)
            {
                CarYellow.Left -= 30;
            }
            if (CarYellow2.Left < 480)
            {
                CarYellow2.Left -= 25;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (CarBlue.Top < groupBox2.Top)
            {
                CarBlue.Top -= 30;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}