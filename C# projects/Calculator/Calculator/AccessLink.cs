using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Calculator
{
    public partial class AccessLink : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\InsertData.accdb");
        public AccessLink()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Firstname = txtFirstName.Text.Trim();
            string Lastname = txtLastName.Text.Trim();
            string Username = txtUsername.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string Password = txtPassword.Text.Trim();
            string Confirm = txtConfirmPassword.Text.Trim();

            if (Firstname == "")
            {
                MessageBox.Show("Please Enter your Firsname");
                txtFirstName.Focus();
                return;
            }
            if (Lastname == "")
            {
                MessageBox.Show("Please Enter your Lastname");
                txtLastName.Focus();
                return;
            }
            if (Username == "")
            {
                MessageBox.Show("Please Enter your Username");
                txtUsername.Focus();
                return;
            }
            if (Email == "")
            {
                MessageBox.Show("Please Enter your Email");
                txtEmail.Focus();
                return;
            }
            if (Password == "")
            {
                MessageBox.Show("Please Enter your Password");
                txtPassword.Focus();
                return;
            }
            if (Confirm == "")
            {
                MessageBox.Show("Please confirm password");
                txtConfirmPassword.Focus();
                return;
            }

            if (Confirm != Password)
                 {
                MessageBox.Show("Please Crosscheck your password");
                txtConfirmPassword.Focus();
                return;
            }
            if (Confirm == Password)
            {


                this.Hide();
                Calculator pet = new Calculator();
                pet.ShowDialog();
                this.Dispose();

                try
                {
                    con.Open();
                    OleDbCommand command = new OleDbCommand();
                   // con.ConnectionString=ConfigurationManager.ConnectionStrings["Connection"].ToString();
                    command.Connection = con;
                    command.CommandText = "INSERT into [RegistrationData](Name1)values(@nm)";

                    int a = command.ExecuteNonQuery();

                  //  OleDbDataReader dbReader = command.ExecuteReader();
                    //while (dbReader.Read())
                    //{
                    //    label1.Text += dbReader.GetValue(1).ToString();
                    //}
                    //   label1.Text = "Connection successful";

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("err" + ex);
                }

            }

            else
            {
                MessageBox.Show("Opps Access Denied. Invalid Username or Password");
                txtPassword.Focus();

            }

           
        }
    }
}
