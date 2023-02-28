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

namespace HackathonApplication
{
    public partial class txtpage1 : Form
    {
        public txtpage1()
        {
            InitializeComponent();
        }

        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            lblAssignment.Text = "Task 1 Weighting :";
            lblTest.Text = "Task 2 Weighting :";
            lblExam.Text = "Final Weighting :";

            lblAssignment2.Text = "Learning Units for Task 1 :";
            lblTest2.Text = "Learning Units for Task 2 :";
            lblExam2.Text = "Learning Units for Final Poe :";

            lblReqHrs1.Text = "Required Hours for Task 1:";
            lblReqHrs1.Text = "Required Hours for Task 2:";
            lblReqHrs1.Text = "Required Hours for Final Poe:";
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            lblAssignment.Text = "Assignment Weighting :";
            lblTest.Text = "Test Weighting :";
            lblExam.Text = "Exam Weighting :";

            lblAssignment2.Text = "Learning Units for Assignment:";
            lblTest2.Text = "Learning Units for Test:";
            lblExam2.Text = "Learning Units for Exam:";

            lblReqHrs1.Text = "Learning Units for Assignment:";
            lblReqHrs2.Text = "Learning Units for Test:";
            lblReqHrs3.Text = "Learning Units for Exam:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }
        SqlConnection connection = new SqlConnection(Login.connectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnNo.Checked)
            {
                //Insert to database here
                try
                {
                    connection.Open();
                    string query = "Insert into FullModule" +
                        "(CourseCode,ModuleCode,ModuleName,AssessWeight1,AssessWeight2,AssessWeight3,iceWeight,ReqHours,ModuleAssessType_1forPOE_2ForAssess,LearingUnitForAssess1,LearingUnitForAssess2,LearingUnitForAssess3,Assess1HoursReq,Assess2HoursReq,Assess3HoursReq,year,Assess1Pages,Assess2Pages,Assess3Pages)" +                                                                                                   //pages 1           page 2                  page 3
                        "values('" + txtCourse.Text + "','" + txtCode.Text + "','" + txtName.Text + "," + txtWeight1.Text + "," + txtWeight2.Text + "," + txtWeight3.Text + "," + 10 + "," + txtReqHours.Text + "," + 2 + ",'" + txtLearnUni1.Text + "','" + txtLearnUni2.Text + "','" + txtLearnUni3.Text + "','" + ReqHrsAssignment.Text + "','" + ReqHrsTest.Text + "','" + ReqHrsExam.Text + "'," + txtYear.Text + "," + txtPass1.Text + "'," + txtPage2.Text + "'," + txtPage3.Text + ");";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    MessageBox.Show("Module Captured Successfully","Success");
                    connection.Close();
                }
                catch (SqlException Ef)
                {
                    MessageBox.Show(Ef.Message, "SQL Exception");
                }
                catch(Exception We)
                {
                    MessageBox.Show(We.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            if (rbtnYes.Checked)
            {
                //Insert to database here
                try
                {
                    connection.Open();
                    string query = "Insert into FullModule" +
                        "(CourseCode,ModuleCode,ModuleName,AssessWeight1,AssessWeight2,AssessWeight3,iceWeight,ReqHours,ModuleAssessType_1forPOE_2ForAssess,LearingUnitForAssess1,LearingUnitForAssess2,LearingUnitForAssess3,Assess1HoursReq,Assess2HoursReq,Assess3HoursReq,year,Assess1Pages,Assess2Pages,Assess3Pages)" +
                        "values('" + txtCourse.Text + "','" + txtCode.Text + "','" + txtName.Text + "'," + txtWeight1.Text + "," + txtWeight2.Text + "," + txtWeight3.Text + "," + 10 + "," + txtReqHours.Text + "," + 2 + ",'" + txtLearnUni1.Text + "','" + txtLearnUni2.Text + "','" + txtLearnUni3.Text + "','" + ReqHrsAssignment.Text + "','" + ReqHrsTest.Text + "','" + ReqHrsExam.Text +"',"+txtYear.Text + "," + txtPass1.Text + "'," + txtPage2.Text + "'," + txtPage3.Text + ");";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    MessageBox.Show("Module Captured Successfully", "Success");
                    connection.Close();
                }
                catch (SqlException Ef)
                {
                    MessageBox.Show(Ef.Message, "SQL Exception");
                }
                catch (Exception We)
                {
                    MessageBox.Show(We.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Make a selection stupid");
            }
        }
    }
}
