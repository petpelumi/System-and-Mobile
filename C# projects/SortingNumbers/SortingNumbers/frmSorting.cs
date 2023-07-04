using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingNumbers
{
    public partial class frmSorting : Form
    {
        public frmSorting()
        {
            InitializeComponent();
        }

        private void btnAscending_Click(object sender, EventArgs e)
        {
           // string[] score = new string[10];
            string inputScores = txtInput.Text;
            string[] explode_scores = inputScores.Split('\n') ;
           // MessageBox.Show(explode_scores.Length.ToString());
            double temp;
            for (int i = 0; i < 10; i++)
            {
               for (int j = i+1; j < 10; j++)
               {
                   double x = double.Parse(explode_scores[i]);
                   double y = double.Parse(explode_scores[j]);
                   if (x > y)
                   {
                       temp = x;
                       x = y;
                       y = temp;
                       explode_scores[i] = "" + x;
                       explode_scores[j] = "" + y;
                   }
               }
            }

            for (int z = 0; z < 10; z++)
            {
                lstOutput.Items.Add(explode_scores[z]);
               
            }

           

        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
           // string[] score = new string[10];
            string inputScores = txtInput.Text;
            string[] explode_scores = inputScores.Split('\n');
            // MessageBox.Show(explode_scores.Length.ToString());
            double temp;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    double x = double.Parse(explode_scores[i]);
                    double y = double.Parse(explode_scores[j]);
                    if (x < y)
                    {
                        temp = x;
                        x = y;
                        y = temp;
                        explode_scores[i] = x.ToString();
                        explode_scores[j] = y.ToString();
                    }
                }
            }

            for (int z = 0; z < 10; z++)
            {
                lstOutput.Items.Add(explode_scores[z]);
            }
        }
    }
}
