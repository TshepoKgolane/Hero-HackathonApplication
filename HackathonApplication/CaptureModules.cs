using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MyLibrary;

namespace HackathonApplication
{
    public partial class CaptureModules : Form
    {
        SqlConnection connection = new SqlConnection(Login.connectionString);
        int year;

        List<string> code = new List<string>();
        List<string> name = new List<string>();
        List<string> Assessment1 = new List<string>();
        List<string> Assessment2 = new List<string>();
        List<string> Assessment3 = new List<string>();
        List<string> iceM = new List<string>();

        List<string> RequirredHours = new List<string>();
        List<string> AssessmentType_1_forPOE_2_forAssignment = new List<string>();
        List<string> LearningUnitForAssess1 = new List<string>();
        List<string> LearningUnitForAssess2 = new List<string>();
        List<string> LearningUnitForAssess3 = new List<string>();
        List<string> RequirredHoursForAssignment = new List<string>();
        List<string> RequirredHoursForTest = new List<string>();
        List<string> RequirredHoursForExam = new List<string>();
        List<string> CourseCode = new List<string>();
        List<string> year2 = new List<string>();
        public CaptureModules()
        {
            InitializeComponent();
            lblTitle.Visible = false;
            
            try
            {
                connection.Open();
                string query = @"Select * from Modules where Username = '" + UserInformation.Username + "';";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    listModules.Items.Add(read["ModuleName"].ToString());
                    year = Convert.ToInt32(read["year"].ToString());
                }


                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            FillComboBox();
            //exec SelectModule @Username =''

        }
        public void FillComboBox()
        {
            MessageBox.Show("Year is :"+year);
            if (year == 1)
            {
                MessageBox.Show("Unfortunately there are no modules for you to add due to your current year of study", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (year == 2)
            {
                
                connection.Open();
                //taking in first year modules because seond year is already populated
                string query2 = @"Select * from FullModule where year=1";
                SqlCommand command2 = new SqlCommand(query2, connection);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    string courseCode = reader["CourseCode"].ToString();
                    string ModuleCode = reader["ModuleCode"].ToString();
                    string ModuleName = reader["ModuleName"].ToString();
                    cmbModules.Items.Add(ModuleName);
                    int Assessment = Convert.ToInt32(reader["AssessWeight1"].ToString());
                    int test = Convert.ToInt32(reader["AssessWeight2"].ToString());
                    int exam = Convert.ToInt32(reader["AssessWeight3"].ToString());
                    int ice = Convert.ToInt32(reader["iceWeight"].ToString());

                    CourseCode.Add(courseCode);
                    code.Add(ModuleCode);
                    name.Add(ModuleName);
                    Assessment1.Add(Assessment + "");
                    Assessment2.Add(test + "");
                    Assessment3.Add(exam + "");
                    iceM.Add(ice + "");

                    RequirredHours.Add(Convert.ToInt32(reader["ReqHours"].ToString()) + "");
                    AssessmentType_1_forPOE_2_forAssignment.Add(Convert.ToInt32(reader["ModuleAssessType_1forPOE_2ForAssess"].ToString()) + "");
                    LearningUnitForAssess1.Add(reader["LearingUnitForAssess1"].ToString() + "");
                    LearningUnitForAssess2.Add(reader["LearingUnitForAssess2"].ToString() + "");
                    LearningUnitForAssess3.Add(reader["LearingUnitForAssess3"].ToString() + "");
                    RequirredHoursForAssignment.Add(Convert.ToInt32(reader["Assess1HoursReq"].ToString()) + "");
                    RequirredHoursForTest.Add(Convert.ToInt32(reader["Assess2HoursReq"].ToString()) + "");
                    RequirredHoursForExam.Add(Convert.ToInt32(reader["Assess3HoursReq"].ToString()) + "");
                    year2.Add(Convert.ToInt32(reader["year"].ToString()) + "");

                }
                connection.Close();


            }
            else if (year == 3)
            {
                connection.Open();
                //taking in first year modules because seond year is already populated
                string query2 = @"Select * from FullModule where year<3";
                SqlCommand command2 = new SqlCommand(query2, connection);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    string courseCode = reader["CourseCode"].ToString();
                    string ModuleCode = reader["ModuleCode"].ToString();
                    string ModuleName = reader["ModuleName"].ToString();
                    cmbModules.Items.Add(ModuleName);
                    int Assessment = Convert.ToInt32(reader["AssessWeight1"].ToString());
                    int test = Convert.ToInt32(reader["AssessWeight2"].ToString());
                    int exam = Convert.ToInt32(reader["AssessWeight3"].ToString());
                    int ice = Convert.ToInt32(reader["iceWeight"].ToString());

                    CourseCode.Add(courseCode);
                    code.Add(ModuleCode);
                    name.Add(ModuleName);
                    Assessment1.Add(Assessment + "");
                    Assessment2.Add(test + "");
                    Assessment3.Add(exam + "");
                    iceM.Add(ice + "");

                    RequirredHours.Add(Convert.ToInt32(reader["ReqHours"].ToString()) + "");
                    AssessmentType_1_forPOE_2_forAssignment.Add(Convert.ToInt32(reader["ModuleAssessType_1forPOE_2ForAssess"].ToString()) + "");
                    LearningUnitForAssess1.Add(reader["LearingUnitForAssess1"].ToString() + "");
                    LearningUnitForAssess2.Add(reader["LearingUnitForAssess2"].ToString() + "");
                    LearningUnitForAssess3.Add(reader["LearingUnitForAssess3"].ToString() + "");
                    RequirredHoursForAssignment.Add(Convert.ToInt32(reader["Assess1HoursReq"].ToString()) + "");
                    RequirredHoursForTest.Add(Convert.ToInt32(reader["Assess2HoursReq"].ToString()) + "");
                    RequirredHoursForExam.Add(Convert.ToInt32(reader["Assess3HoursReq"].ToString()) + "");
                    year2.Add(Convert.ToInt32(reader["year"].ToString()) + "");
                    connection.Close();
                }
            }
        }
        

        private void btnModules_Click(object sender, EventArgs e)
        {
            try
            {
                    for (int i = 0; i < code.Count; i++)
                    {
                        if (cmbModules.SelectedItem.Equals(name[i]))
                        {
                            connection.Open();
                            string query3 = "Insert into Modules" +
                            "(CourseCode,Username,ModuleCode,ModuleName,AssessWeight1,AssessWeight2,AssessWeight3,iceWeight,ReqHours,ModuleAssessType_1forPOE_2ForAssess,LearingUnitForAssess1,LearingUnitForAssess2,LearingUnitForAssess3,Assess1HoursReq,Assess2HoursReq,Assess3HoursReq,year)" +
                            "values('" + CourseCode[i] + "','" + UserInformation.Username + "','" + code[i] + "','" + name[i] + "'," + Assessment1[i] + "," + Assessment2[i] + "," + Assessment3[i] + "," + 10 + "," + RequirredHours[i] + "," + AssessmentType_1_forPOE_2_forAssignment[i] + ",'" + LearningUnitForAssess1[i] + "','" + LearningUnitForAssess2[i] + "','" + LearningUnitForAssess3[i] + "','" + RequirredHoursForAssignment[i] + "','" + RequirredHoursForTest[i] + "','" + RequirredHoursForExam[i] + "'," + year2[i] + ");";

                            SqlCommand command3 = new SqlCommand(query3, connection);
                            SqlDataReader reader3 = command3.ExecuteReader();
                            connection.Close();
                        }
                    }
                

                DialogResult dr = MessageBox.Show("Would You Like to Add a Goal for this Module?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    new MyModuleGoal().Show();
                    this.Hide();
                }
                else
                {

                }

                //-------------
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Ensure you entered the correct format.\n" +
                    "Refrain from entering characters where numbers are needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                connection.Close();
            }
        }

        private void CaptureModules_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hackathonDataSet5.Modules' table. You can move, or remove it, as needed.
            this.modulesTableAdapter.Fill(this.hackathonDataSet5.Modules);

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            new ManageModules().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to redirect to the next page?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                new Home().Show();
                this.Hide();
            }
            else
            {
                //do whatever you want
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new MyModules().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new StudyPlan().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MyModuleGoal().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CalculateFinalMark().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(2);
        }
    }
    
}
