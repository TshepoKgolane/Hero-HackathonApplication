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
    public partial class MyModules : Form
    {
        public MyModules()
        {
            InitializeComponent();
            //fill listboxs with database modules
            Fill_Listbox_With_Modules();
            //displays messages if list boxes have no data
            //and asks the user to push a button if they want to see data
            Check_If_lists_Have_Data();
            //hiding edit button

        }
        public string code;
        public string name;
        public int Mark1;
        public int Mark2;
        public int Mark3;
        public int ice;

        SqlConnection connection = new SqlConnection(Login.connectionString);
        private void btnManage_Click(object sender, EventArgs e)
        {
            if (listModules.SelectedItems == null)
            {
                MessageBox.Show("Please select the module to edit from the list", "Error");
            }
            else
            {
                new EditAssessments().Show();
                this.Hide();
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            new Home().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your already on the page", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new CaptureModules().Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnStudyPlan_Click(object sender, EventArgs e)
        {
            new StudyPlan().Show();
            this.Hide();
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            new MyModuleGoal().Show();
            this.Hide();
        }

        private void btnCalcFinal_Click(object sender, EventArgs e)
        {
            new CalculateFinalMark().Show();
            this.Hide();
        }
        //exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(2);
        }
        public void Fill_Listbox_With_Modules()
        {
            try
            {
                connection.Open();
                string query = @"Select * from Modules where Username = '" + UserInformation.Username + "';";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    //adding module from database to the list 
                    listModules.Items.Add(read["ModuleName"].ToString());

                }
                //closing current connection
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
        //called whenever user clicks on the list box to select something
        private void listModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] status = new string[4];

                connection.Open();
                string query = @"Select * from AssessmentMarks where Username = '" + UserInformation.Username + "';";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    name = read["ModuleName"].ToString();

                    Mark1 = Convert.ToInt32(read["Mark1"].ToString());
                    Mark2 = Convert.ToInt32(read["Mark2"].ToString());
                    Mark3 = Convert.ToInt32(read["Mark3"].ToString());
                    ice = Convert.ToInt32(read["ice"].ToString());

                    string goal = read["MyGoal"].ToString();

                    string[] assessmentName = new string[] { "Assignment/Task 1", "Test/Task 2", "Exam/Final Poe", "Ice Task" };
                    int[] marks = new int[] { Mark1, Mark2 , Mark3, ice };
                    if (listModules.GetItemText(listModules.SelectedItem).Equals(name))
                    {
                        //clearing listview so that new data is not appended
                        listViewMarks.Items.Clear();
                        for (int i = 0; i < marks.Length; i++)
                        {

                            if (goal.Equals("above 75%"))
                            {
                                for (int j = 0; j < marks.Length; j++)
                                {
                                    if (marks[j]>75)
                                    {
                                        status[j] = "Reached";
                                    }
                                    else
                                    {
                                        status[j] = "Not Reached";
                                    }  
                                }

                                lblDisplay11.Visible = false;
                                lblDisplay12.Visible = false;
                                btnAddMarks.Visible = false;

                            }
                            else if (goal.Equals("above 50%"))
                            {

                                for (int j = 0; j < marks.Length; j++)
                                {
                                    if (marks[j] > 50)
                                    {
                                        status[j] = "Reached";
                                    }
                                    else
                                    {
                                        status[j] = "Not Reached";
                                    }
                                }
                                lblDisplay11.Visible = false;
                                lblDisplay12.Visible = false;
                                btnAddMarks.Visible = false;
                            }
                            ListViewItem item = new ListViewItem(assessmentName[i]);
                            item.SubItems.Add(marks[i] + "");
                            item.SubItems.Add(status[i]);
                            listViewMarks.Items.Add(item);
                        }
                        if (goal != "above 75%" && goal != "above 50%" )
                        {
                           MessageBox.Show("Please select a goal for " + listModules.GetItemText(listModules.SelectedItem) + " to proceed" , "Alert");
                            MyModuleGoal gooal = new MyModuleGoal();
                            gooal.cmbModules.SelectedItem = listModules.GetItemText(listModules.SelectedItem);
                            gooal.lblgoaltitle.Text = "Select goal for " + listModules.GetItemText(listModules.SelectedItem);
                            gooal.Show();
                        }
                    }
                    else
                    {
                        listViewMarks.Items.Clear();
                        lblDisplay11.Visible = true;
                        lblDisplay11.Text = "You have not added Marks for this module";
                        lblDisplay12.Visible = true;
                        btnAddMarks.Visible = true;

                    }
                }
            }



            finally
            {
                connection.Close();
            }
        }
        public void Check_If_lists_Have_Data()
        {
            if (listModules.Items.Count == 0)
            {
                //displaying the error labels
                lbldisplay1.Visible = true;
                lbldisplay2.Visible = true;
                lbldisplay3.Visible = true;

            }
            else
            {
                //displaying the error labels
                lbldisplay1.Visible = false;
                lbldisplay2.Visible = false;
                lbldisplay3.Visible = false;

            }

        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            MyModuleGoal goal = new MyModuleGoal();
            goal.cmbModules.SelectedItem = listModules.SelectedItem;
            goal.Show();
            this.Hide();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to navigate to calculate your final mark now?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                new CalculateFinalMark().Show();
                this.Hide();
            }
            else
            {

                //do whatever you want
            }
            new CalculateFinalMark().Show();
            this.Hide();
        }
    }
}
