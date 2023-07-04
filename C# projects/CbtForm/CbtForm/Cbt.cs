using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CbtForm
{
    public partial class Cbt : Form
    {
        public Cbt()
        {
            InitializeComponent();
        }

        private void txtStart_Click(object sender, EventArgs e)
        {
            string Username = txtName.Text.Trim();
            string PHONE = txtPhone.Text.Trim();

            if (Username == "")
            {
                MessageBox.Show("Please Enter your Username");
                txtName.Focus();
                return;
            }
            if (PHONE == "")
            {
                MessageBox.Show("Please Enter your Number");
                txtPhone.Focus();
                return;
            }

            if (Username == "A" && PHONE == "A")
            {
                

                this.Hide();
                ExamQuestions pet = new ExamQuestions();
                pet.ShowDialog();
                this.Dispose();
                
            }

            else
            {
                MessageBox.Show("Opps Access Denied. Invalid Username or Password");
                txtName.Focus();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
