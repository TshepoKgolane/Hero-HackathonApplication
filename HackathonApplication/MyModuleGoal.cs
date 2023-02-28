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
    public partial class MyModuleGoal : Form
    {
        SqlConnection connection = new SqlConnection(Login.connectionString);
        private string modulecode;
        private string moduleName;
        public MyModuleGoal()
        {
            InitializeComponent();
            listView1.GridLines = true;
            try
            {
                string query = "Select * from Modules where Username = '" + UserInformation.Username + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = query;
                connection.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    cmbModules.Items.Add(drd["ModuleName"].ToString());
                    cmbModules.ValueMember = drd["ModuleCode"].ToString();
                    cmbModules.DisplayMember = drd["ModuleName"].ToString();
                    modulecode = drd["ModuleCode"].ToString();
                    moduleName = drd["ModuleCode"].ToString();
                }


            }
            catch (SqlException sqq)
            {

                MessageBox.Show(sqq.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
            goalfill();
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            if (cmbOutcome.SelectedItem.Equals("I want a Distinction"))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT into goal " + "values ('" + UserInformation.Username + "','" + cmbModules.GetItemText(cmbModules.SelectedItem) + "','I Want distinction');";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Please note to get a distinction you need to get above 75 %\n" +
                        "for each of your assessment with your ice tasks included aswell", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult dr = MessageBox.Show("Would you like to create a study schedule for this Module?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        StudyPlan study = new StudyPlan();
                        study.Show();
                        study.cmbModules.SelectedItem = cmbModules.GetItemText(cmbModules.SelectedItem);
                        this.Hide();
                    }
                    else
                    {
                        new MyModuleGoal().Show();
                        this.Hide();
                        //do whatever you want
                    }
                    connection.Close();
                    //Would you like to create a study plan?
                }
                catch (SqlException)
                {

                    MessageBox.Show("You have already set a goal for this Module","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                finally
                {
                    connection.Close();
                }

            }
            else if (cmbOutcome.SelectedItem.Equals("I just want to pass"))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT into goal " + "values ('" + UserInformation.Username + "','" + cmbModules.GetItemText(cmbModules.SelectedItem) + "','I Just want to pass');";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Successfully added Goal", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult dr = MessageBox.Show("Would you like to create a study schedule for this Module?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        StudyPlan study = new StudyPlan();
                        study.cmbModules.SelectedItem = cmbModules.GetItemText(cmbModules.SelectedItem);
                        study.Show();

                        this.Hide();
                    }
                    else
                    {
                        new MyModuleGoal().Show();
                        this.Hide();
                        //do whatever you want
                    }
                    connection.Close();
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
            else
            {
                MessageBox.Show("Please select an outcome", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            CaptureModules my = new CaptureModules();
            my.Show();
            my.lblTitle.Visible = true;
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
        public void goalfill()
        {
            try
            {
                //AssessmentWeigh
                string query = "Select * from goal where Username = '" + UserInformation.Username + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = query;
                connection.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    ListViewItem item = new ListViewItem(drd["ModuleName"].ToString());
                    item.SubItems.Add(drd["MyGoal"].ToString());
                    listView1.Items.Add(item);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnCapModules_Click(object sender, EventArgs e)
        {
            new MyModules().Show();
            this.Hide();
        }

        private void btnStudyPlan_Click(object sender, EventArgs e)
        {
            new StudyPlan().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MyModuleGoal().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                System.Environment.Exit(1);
            }
            else
            {
               
                //do whatever you want
            }
        }
    }
}
