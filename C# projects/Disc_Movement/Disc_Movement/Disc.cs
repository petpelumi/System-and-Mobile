using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disc_Movement
{
    public partial class Disc : Form
    {
        public Disc()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dvd.Top += 5;
            if (Dvd.Top >= 238)
            {
                //if (Dvd.Top >= 50)
                //{
                //    timer4.Enabled = true;
                //    timer3.Enabled = false;
                //}
                timer1.Enabled = false;
                timer2.Enabled = true;


                Dvd.FillColor = new Color();
                Dvd.FillColor = Color.Green;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            Dvd.Top -= 5;
            if (Dvd.Top <= 10)
            {
                //if (Dvd.Top <= 50)
                //{
                //    timer3.Enabled = true;
                //    timer4.Enabled = false;
                //}
                timer1.Enabled = true;
                timer2.Enabled = false;

                Dvd.FillColor = new Color();
                Dvd.FillColor = Color.Blue;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            Dvd.Left += 15;
            if (Dvd.Left >= 230)
            {
                //if (Dvd.Top >= 50)
                //{
                //    timer1.Enabled = true;
                //    timer2.Enabled = false;
                //}
                timer3.Enabled = false;
                timer4.Enabled = true;
                

                Dvd.FillColor = new Color();
                Dvd.FillColor = Color.Red;
                
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Dvd.Left -= 15;
            if (Dvd.Left <= 10  )
            {
                //if (Dvd.Top <= 50)
                //{
                //    timer2.Enabled = true;
                //    timer1.Enabled = false;
                //}
                timer4.Enabled = false;
                timer3.Enabled = true;

                Dvd.FillColor = new Color();
                Dvd.FillColor = Color.Yellow;
            }
        }
    }
}
