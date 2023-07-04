using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsXp
{
    public partial class Form1 : Form
    {
        bool Pause = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
      
            
            timer1.Enabled = true;
            btnTransfer.Enabled = false;
            btnPause.Enabled = true;
             if (Pause == true)
            {
                btnTransfer.Text = "Play";
               
            }
            //if btnTransfer.Enabled = false
             progressBar1.Enabled = true;
             
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value >= 100)
            {
                timer4.Enabled = false;
                timer3.Enabled = false;
                timer2.Enabled = false;
                timer1.Enabled = false;
                file2.Visible = false;
                fileShape.Visible = false;
                MessageBox.Show("Transfer complete");
                btnPause.Enabled = false;
                btnTransfer.Enabled = false;
                button2.Text = "Finish";
            }
            Pause = true;
            fileShape.Left += 15;
            fileShape.Top -= 4;
            if (fileShape.Left >= 230 || fileShape.Top <= 60)
            {
                fileShape.Left -=4;
                fileShape.Top += 3;
            }
            if (fileShape.Top <= 50) { timer2.Enabled = true; timer1.Enabled = false; }
            if (fileShape.Left >= 260)
            {
                timer3.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            fileShape.Left += 8;
            fileShape.Top += 2;
            if (fileShape.Left >= 550)
            {
                timer2.Enabled = false;
                fileShape.Visible = false;
                fileShape.Location = new Point(64, 102);
                fileShape.Visible = true;
                timer1.Enabled = true;
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
  
            file2.Left += 15;
            file2.Top -= 4;

            if (file2.Left >= 230 || file2.Top <= 60)
            {
                file2.Left -= 4;
                file2.Top += 3;
            }

            if (file2.Top <= 50) { timer4.Enabled = true; timer3.Enabled = false; }
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
        
            file2.Left += 8;
            file2.Top += 2;
            if (file2.Left >= 550)
            {
                timer4.Enabled = false;
                file2.Visible = false;
                file2.Location = new Point(64, 102);
                file2.Visible = true;
                timer3.Enabled = true;

              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            timer3.Enabled = false;
            timer2.Enabled = false;
            timer1.Enabled = false;

           // progressBar1.Visible = false;
            txtQuesion.Visible = true;
            btnYes.Visible = true;
            btnNo.Visible = true;

            if ( button2.Text == "Finish")
            {
                txtQuesion.Visible = true;
                btnYes.Visible = true;
                btnNo.Visible = true;

                this.Close();
            }

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            
            timer4.Enabled = false;
            timer3.Enabled = false;
            timer2.Enabled = false;
            timer1.Enabled = false;
            btnTransfer.Enabled = true;
            btnPause.Enabled = false;

            file2.Location = new Point(64, 102);
            fileShape.Location = new Point(64, 102);
       
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            file2.Location = new Point(64, 102);
            fileShape.Location = new Point(64, 102);
            
            timer1.Enabled = true;

            txtQuesion.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;
           // progressBar1.Visible = true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileShape_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
