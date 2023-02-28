using MyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonApplication
{
    public partial class EditAssessments : Form
    {
        SqlConnection connection = new SqlConnection(Login.connectionString);
        public EditAssessments()
        {
            InitializeComponent();
            fillModules();
            lblErr2.Visible = false;
            lblErr1.Visible = false;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

        }
        public void UpdateMarks()
        {
            if (cmbAssessment.SelectedItem.Equals("Assignment/Task1"))
            {
                try
                {

                    connection.Open();
                    string query = "Update AssessmentMarks " +
                   "set Mark1 = " + Convert.ToInt32(txtMark.Text) + " " +
                   "where Username='" + UserInformation.Username + " AND ModuleName = '" + cmbModule.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Successfully updated Mark");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }


            }
            else if (cmbAssessment.SelectedItem.Equals("Test/Task2"))
            {
                try
                {

                    connection.Open();
                    string query = "Update AssessmentMarks " +
                   "set Mark2 = " + Convert.ToInt32(txtMark.Text) + " " +
                   "where Username='" + UserInformation.Username + " AND ModuleName = '" + cmbModule.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Successfully updated Mark");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            else if (cmbAssessment.SelectedItem.Equals("Exam/Final Poe"))
            {
                try
                {

                    connection.Open();
                    string query = "Update AssessmentMarks " +
                   "set Mark3 = " + Convert.ToInt32(txtMark.Text) + " " +
                   "where Username='" + UserInformation.Username + " AND ModuleName = '" + cmbModule.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Successfully updated Mark");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            else if (cmbAssessment.SelectedItem.Equals("Ice"))
            {
                try
                {

                    connection.Open();
                    string query = "Update AssessmentMarks " +
                   "set ice = " + Convert.ToInt32(txtMark.Text) + " " +
                   "where Username='" + UserInformation.Username + " AND ModuleName = '" + cmbModule.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Successfully updated Mark");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void fillModules()
        {
            try
            {
                string query = "Select * from Modules where Username = '" + UserInformation.Username + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = query;
                connection.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    cmbModule.Items.Add(drd["ModuleName"].ToString());
                    cmbModule.ValueMember = drd["ModuleCode"].ToString();
                    cmbModule.DisplayMember = drd["ModuleName"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public void viewMarks()
        {
            try
            {
                connection.Open();
                string query = "Select * from AssessmentMarks where Username = '" + UserInformation.Username + "' AND ModuleName ='" + cmbModule.SelectedItem + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = query;

                SqlDataReader drd = cmd.ExecuteReader();


                string ModuleName = drd["ModuleName"].ToString();
                string Username = drd["Username"].ToString();

                //if module marks already exists
                if (drd.Read())
                {
                    connection.Close();
                    //if marks already exist
                    UpdateMarks();
                }
                else
                {
                    if (cmbAssessment.SelectedItem.Equals("Exam/Final Poe"))
                    {
                        try
                        {
                            connection.Open();
                            string query1 = "Insert into AssessmentMarks(Username,ModuleName,Mark3) " +
                                "values('" + UserInformation.Username + "','" + cmbModule.SelectedItem + "'," + txtMark.Text + ");";
                            SqlCommand command = new SqlCommand(query, connection);
                            SqlDataReader reader = command.ExecuteReader();
                            MessageBox.Show("Added Mark to the database");
                            connection.Close();

                        }
                        catch (SqlException)
                        {

                            throw;
                        }

                    }
                    else if (cmbAssessment.SelectedItem.Equals("Test/Task2"))
                    {
                        try
                        {
                            connection.Open();
                            string query1 = "Insert into AssessmentMarks(Username,ModuleName,Mark2) " +
                                "values('" + UserInformation.Username + "','" + cmbModule.SelectedItem + "'," + txtMark.Text + ");";
                            SqlCommand command = new SqlCommand(query, connection);
                            SqlDataReader reader = command.ExecuteReader();
                            MessageBox.Show("Added Mark to the database");
                            connection.Close();

                        }
                        catch (SqlException)
                        {

                            throw;
                        }

                    }
                    else if (cmbAssessment.SelectedItem.Equals("Assignment/Task1"))
                    {
                        try
                        {

                        }
                        catch (SqlException)
                        {

                            throw;
                        }
                        connection.Open();
                        string query1 = "Insert into AssessmentMarks(Username,ModuleName,Mark1) " +
                            "values('" + UserInformation.Username + "','" + cmbModule.SelectedItem + "'," + txtMark.Text + ");";
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        MessageBox.Show("Added Mark to the database");
                        connection.Close();
                    }
                    else if (cmbAssessment.SelectedItem.Equals("ice"))
                    {
                        try
                        {
                            connection.Open();
                            string query1 = "Insert into AssessmentMarks(Username,ModuleName,ice2) " +
                                "values('" + UserInformation.Username + "','" + cmbModule.SelectedItem + "'," + txtMark.Text + ");";
                            SqlCommand command = new SqlCommand(query, connection);
                            SqlDataReader reader = command.ExecuteReader();
                            MessageBox.Show("Added Mark to the database");
                            connection.Close();
                        }
                        catch (SqlException)
                        {

                            throw;
                        }
                    }
                    else
                    {
                        lblErr2.Visible = true;
                        MessageBox.Show("We've encounted a problem");
                    }

                }

            }
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
