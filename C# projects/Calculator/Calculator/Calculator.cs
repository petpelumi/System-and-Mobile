using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operationperformed = "";
        bool performed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            // performed = true;
          if ((txtDis.Text == "0") || (performed)) 
                txtDis.Clear();
            
            performed = false;
            Button button = (Button)sender;
            txtDis.Text = txtDis.Text + button.Text;
            labelOperation.Text += operationperformed +" " + button.Text + " " ;
            
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperformed = button.Text;
            value = double.Parse(txtDis.Text);
           
            performed = true;
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
           
            switch (operationperformed) 
            {
                    
                case "+":
                    txtDis.Text = (value + double.Parse(txtDis.Text)).ToString();
                    break;

                case "-":
                    txtDis.Text = (value - double.Parse(txtDis.Text)).ToString();
                    break;

                case "/":
                    txtDis.Text = (value / double.Parse(txtDis.Text)).ToString();
                    break;

                case "x":
                    txtDis.Text = (value * double.Parse(txtDis.Text)).ToString();
                    break;

                default:
                    break;
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDis.Text = "0";
            labelOperation.Text= " ";
        }

       


       
    }
}
