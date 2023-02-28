using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyLibrary;
using System.Threading;

namespace HackathonApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label5.Visible = false;

            this.Hide();
            SplashScreen splash = new SplashScreen();
            splash.Show();
            Thread.Sleep(5000);
            splash.Hide();
            this.Show();
        }
        public static String connectionString = @"Data Source = TSHEPO-KGOLANE;Initial Catalog=Hackathon;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        String Username;
        String Name1;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
            label5.Visible = true;
        }
        public void login()
        {
            try
            {
                connection.Open();
                //query
                String query = "SELECT * from Users;";
                //sql connection and data reader
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader Reader = command.ExecuteReader();

                //iterating through database
                while (Reader.Read())
                {

                    Name1 = Reader["Name"].ToString();//assigning userEmail
                    String Surname = Reader["Surname"].ToString();//assigning password
                    Username = Reader["Username"].ToString();//userID
                    String uPassword = Reader["userPassword"].ToString();//this password is encrypted btw
                    String acctype = Reader["AccType"].ToString();//this password is encrypted btw

                    string userPassword = Hashing.Decrypt(uPassword);

                    //if email stored from database and password from database match current saved password and email, allow access

                    if (txtUsername.Text == Username && txtPassword.Text == userPassword && acctype == "Student")
                    {
                        UserInformation.Name = Name1;
                        UserInformation.Surname = Surname;
                        UserInformation.Username = Username;

                        checkIfModulesIsEmpty();
                        
                    }
                    else if(txtUsername.Text == Username && txtPassword.Text == userPassword && acctype == "admin")
                    {
                        new AdminDashboard().Show();
                        this.Hide();
                    }

                }

                //closing datareader after done with it
                Reader.Close();

            }
            catch (Exception qwerty)
            {
                // catchng more errors
                MessageBox.Show(qwerty.Message + " from Login Catch", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close connection
                connection.Close();
            }
        }
        public void checkIfModulesIsEmpty()
        {
            SqlConnection connection2 = new SqlConnection(connectionString);
  
            try
            {
                
                connection2.Open();
                string query = "Select * from Modules where Username ='" + Username + "'";
                SqlCommand command = new SqlCommand(query, connection2);
                SqlDataReader read = command.ExecuteReader();
                if (read.HasRows)
                {
                    //redirecting to new page
                    MessageBox.Show("Hello, " + Name1 + " \nHappy to see you again..", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Home().Show();
                }
                else
                {
                    new StudentInfoCapture().Show();
                    this.Hide();
                }
            }
            finally
            {
                connection2.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(2);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterInterface().Show();
        }
    }
}
