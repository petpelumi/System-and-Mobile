using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Bounce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.Text = DateTime.Now.ToString();
            Ball.Top += 50;
            if (Ball.Top >= 100)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }


            this.Text = Ball.Top.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //this.Text = DateTime.Now.ToString();
            Ball.Top -= 50;
            if (Ball.Top <= 50)
            {
                timer2.Enabled = false;
                timer1.Enabled = true;
            }


            this.Text = Ball.Top.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            Ball2.Top += 50;
            if (Ball2.Top >= 100)
            {
                timer3.Enabled = false;
                timer4.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Ball2.Top -= 50;
            if (Ball2.Top <= 50)
            {
                timer4.Enabled = false;
                timer3.Enabled = true;
            }

        }
    }
}
