using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
using System.Data.SqlClient;

namespace HackathonApplication
{
    public partial class StudentInfoCapture : Form
    {
        public StudentInfoCapture()
        {
            InitializeComponent();
            lblName.Text = UserInformation.Name + " " + UserInformation.Surname;
        }
        SqlConnection connection = new SqlConnection(Login.connectionString);

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
        List<string> assessPage1 = new List<string>();
        List<string> assessPage2 = new List<string>();
        List<string> assessPage3 = new List<string>();
        List<string> CourseCode = new List<string>();
        List<string> year = new List<string>();
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (cmbCourse.GetItemText(cmbCourse.SelectedItem).Equals("Software development") && cmbYear.GetItemText(cmbYear.SelectedItem).Equals("First Year"))
            {

                    //second year
                try
                {
                    connection.Open();
                    //first year
                    string query1 = "Select * from FullModule where year = 1";
                    SqlCommand command = new SqlCommand(query1, connection);
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        string courseCode = reader["CourseCode"].ToString();
                        string ModuleCode = reader["ModuleCode"].ToString();
                        string ModuleName = reader["ModuleName"].ToString();
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
                        assessPage1.Add(reader["Assess1Pages"].ToString() + "");
                        assessPage2.Add(reader["Assess2Pages"].ToString() + "");
                        assessPage3.Add(reader["Assess3Pages"].ToString() + "");
                        year.Add(Convert.ToInt32(reader["year"].ToString()) + "");
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

                try
                {

                    for (int i = 0; i < code.Count; i++)
                    {
                        connection.Open();
                        string query = "Insert into Modules" +
                        "(CourseCode,Username,ModuleCode,ModuleName,AssessWeight1,AssessWeight2,AssessWeight3,iceWeight,ReqHours,ModuleAssessType_1forPOE_2ForAssess,LearingUnitForAssess1,LearingUnitForAssess2,LearingUnitForAssess3,Assess1HoursReq,Assess2HoursReq,Assess3HoursReq,year,Assess1Pages,Assess2Pages,Assess3Pages)" +
                        "values('" + CourseCode[i] + "','" + UserInformation.Username + "','" + code[i] + "','" + name[i] + "'," + Assessment1[i] + "," + Assessment2[i] + "," + Assessment3[i] + "," + 10 + "," + RequirredHours[i] + "," + AssessmentType_1_forPOE_2_forAssignment[i] + ",'" + LearningUnitForAssess1[i] + "','" + LearningUnitForAssess2[i] + "','" + LearningUnitForAssess3[i] + "','" + RequirredHoursForAssignment[i] + "','" + RequirredHoursForTest[i] + "','" + RequirredHoursForExam[i] + "'," + year[i] + ",'" + assessPage1[i] + "','" + assessPage2[i] + "','" + assessPage3[i] + "');";

                        SqlCommand command1 = new SqlCommand(query, connection);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        connection.Close();
                    }

                }
                finally
                {
                    connection.Close();
                }
                this.Hide();
                new Home().Show();

            }
            else if (cmbCourse.GetItemText(cmbCourse.SelectedItem).Equals("Software development") && cmbYear.GetItemText(cmbYear.SelectedItem).Equals("Second Year"))

            {
                try
                {
                    connection.Open();
                    //second year
                    string query1 = "Select * from FullModule where year = 2";
                    SqlCommand command = new SqlCommand(query1, connection);
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        string courseCode = reader["CourseCode"].ToString();
                        string ModuleCode = reader["ModuleCode"].ToString();
                        string ModuleName = reader["ModuleName"].ToString();
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
                        assessPage1.Add(reader["Assess1Pages"].ToString() + "");
                        assessPage2.Add(reader["Assess2Pages"].ToString() + "");
                        assessPage3.Add(reader["Assess3Pages"].ToString() + "");
                        year.Add(Convert.ToInt32(reader["year"].ToString()) + "");
                    }

                }

                finally
                {
                    connection.Close();
                }

                try
                {

                    for (int i = 0; i < code.Count; i++)
                    {
                        connection.Open();
                        string query = "Insert into Modules" +
                        "(CourseCode,Username,ModuleCode,ModuleName,AssessWeight1,AssessWeight2,AssessWeight3,iceWeight,ReqHours,ModuleAssessType_1forPOE_2ForAssess,LearingUnitForAssess1,LearingUnitForAssess2,LearingUnitForAssess3,Assess1HoursReq,Assess2HoursReq,Assess3HoursReq,year,Assess1Pages,Assess2Pages,Assess3Pages)" +                                                                                                                                                                                     //add pages here
                        "values('" + CourseCode[i] + "','" + UserInformation.Username + "','" + code[i] + "','" + name[i] + "'," + Assessment1[i] + "," + Assessment2[i] + "," + Assessment3[i] + "," + 10 + "," + RequirredHours[i] + "," + AssessmentType_1_forPOE_2_forAssignment[i] + ",'" + LearningUnitForAssess1[i] + "','" + LearningUnitForAssess2[i] + "','" + LearningUnitForAssess3[i] + "','" + RequirredHoursForAssignment[i] + "','" + RequirredHoursForTest[i] + "','" + RequirredHoursForExam[i] + "'," + year[i] +",'"+ assessPage1[i] + "','" + assessPage2[i] + "','" + assessPage3[i] + "');";

                        SqlCommand command1 = new SqlCommand(query, connection);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        connection.Close();
                    }

                }
                finally
                {
                    connection.Close();
                }
                this.Hide();
                new Home().Show();
            }
            else if (cmbCourse.GetItemText(cmbCourse.SelectedItem).Equals("Software development") && cmbYear.GetItemText(cmbYear.SelectedItem).Equals("Third Year"))
            {
                try
                {
                    connection.Open();
                    //first year
                    string query1 = "Select * from FullModule where year = 3";
                    SqlCommand command = new SqlCommand(query1, connection);
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        string courseCode = reader["CourseCode"].ToString();
                        string ModuleCode = reader["ModuleCode"].ToString();
                        string ModuleName = reader["ModuleName"].ToString();
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
                        assessPage1.Add(reader["Assess1Pages"].ToString() + "");
                        assessPage2.Add(reader["Assess2Pages"].ToString() + "");
                        assessPage3.Add(reader["Assess3Pages"].ToString() + "");
                        year.Add(Convert.ToInt32(reader["year"].ToString()) + "");
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

                try
                {

                    for (int i = 0; i < code.Count; i++)
                    {
                        connection.Open();
                        string query = "Insert into Modules" +
                        "(CourseCode,Username,ModuleCode,ModuleName,AssessWeight1,AssessWeight2,AssessWeight3,iceWeight,ReqHours,ModuleAssessType_1forPOE_2ForAssess,LearingUnitForAssess1,LearingUnitForAssess2,LearingUnitForAssess3,Assess1HoursReq,Assess2HoursReq,Assess3HoursReq,year,Assess1Pages,Assess2Pages,Assess3Pages)" +
                        "values('" + CourseCode[i] + "','" + UserInformation.Username + "','" + code[i] + "','" + name[i] + "'," + Assessment1[i] + "," + Assessment2[i] + "," + Assessment3[i] + "," + 10 + "," + RequirredHours[i] + "," + AssessmentType_1_forPOE_2_forAssignment[i] + ",'" + LearningUnitForAssess1[i] + "','" + LearningUnitForAssess2[i] + "','" + LearningUnitForAssess3[i] + "','" + RequirredHoursForAssignment[i] + "','" + RequirredHoursForTest[i] + "','" + RequirredHoursForExam[i] + "'," + year[i] +",'"+ assessPage1[i]+ "','" + assessPage2[i]+"','" + assessPage3[i]  + "');";

                        SqlCommand command1 = new SqlCommand(query, connection);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        connection.Close();
                    }

                }
                finally
                {
                    connection.Close();
                }
                this.Hide();
                new Home().Show();
            }
            else
            {
                MessageBox.Show("Year is :" + cmbYear.GetItemText(cmbYear.SelectedItem) + "\nCourse is: " + cmbCourse.GetItemText(cmbCourse.SelectedItem));
            }
        }
    }
}
