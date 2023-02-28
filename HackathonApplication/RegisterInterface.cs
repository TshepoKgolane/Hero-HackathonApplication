using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace HackathonApplication
{
    public partial class RegisterInterface : Form
    {
        public RegisterInterface()
        {
            InitializeComponent();
            Err1.Visible = false;
            Err2.Visible = false;
            Err3.Visible = false;
            Err4.Visible = false;

            
            
        }
        SqlConnection connection = new SqlConnection(Login.connectionString);
        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            //insert user into database here
            try
            {
                if (txtName.TextLength==0)
                {
                    Err1.Visible = true;
                }else if (txtSurname.TextLength == 0)
                {
                    Err2.Visible = true;
                }
                else if (txtUsername.TextLength == 0)
                {
                    Err3.Visible = true;
                }
                else if (txtPassword.TextLength == 0)
                {
                    Err4.Visible = true;
                }
                else
                {
                    if (cmbAcctype.SelectedItem.Equals("Administrator"))
                    {
                        connection.Open();
                        //sql query to insert to table
                        string query = "INSERT INTO Users(Name,Surname,Username,userPassword,AccType) " +
                        "VALUES ('" + txtName.Text + "','" + txtSurname.Text + "','" + txtUsername.Text + "','" + Hashing.Encrypt(txtPassword.Text) + "','Admin');";

                        //declaring sqlcommand object
                        SqlCommand command = new SqlCommand(query, connection);
                        //declaring sqlDataReader object
                        SqlDataReader read = command.ExecuteReader();
                        this.Hide();
                        SplashScreen splash = new SplashScreen();
                        splash.Show();
                        Thread.Sleep(2500);
                        MessageBox.Show("Great, Your all Registered as Admin!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        splash.Hide();
                        UserInformation.Username = txtUsername.Text;
                        UserInformation.Name = txtName.Text;
                        UserInformation.Surname = txtSurname.Text;
                        this.Hide();
                        new Home().Show();
                        connection.Close();
                    }
                    else if (cmbAcctype.SelectedItem.Equals("Student"))
                    {
                        connection.Open();
                        //sql query to insert to table
                        string query = "INSERT INTO Users(Name,Surname,Username,userPassword,AccType) " +
                        "VALUES ('" + txtName.Text + "','" + txtSurname.Text + "','" + txtUsername.Text + "','" + Hashing.Encrypt(txtPassword.Text) + "','Student');";

                        //declaring sqlcommand object
                        SqlCommand command = new SqlCommand(query, connection);
                        //declaring sqlDataReader object
                        SqlDataReader read = command.ExecuteReader();
                        this.Hide();
                        SplashScreen splash = new SplashScreen();
                        splash.Show();
                        Thread.Sleep(2500);
                        MessageBox.Show("Great, Your all Registered!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        splash.Hide();
                        UserInformation.Username = txtUsername.Text;
                        UserInformation.Name = txtName.Text;
                        UserInformation.Surname = txtSurname.Text;
                        this.Hide();
                        new StudentInfoCapture().Show();
                        connection.Close();
                    }

                }
            }
            //catching exceptions
            catch (Exception ex)
            {
                //display the error message
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //closing connection
                connection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(2);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
