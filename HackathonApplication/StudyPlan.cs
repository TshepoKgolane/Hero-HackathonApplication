using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MyLibrary;

namespace HackathonApplication
{
    public partial class StudyPlan : Form
    { 
        SqlConnection connection = new SqlConnection(Login.connectionString);
        List<string> ModuleName = new List<string>();
        List<string> ModuleName2 = new List<string>();
        //learning units
        List<string> LearningUnitAssess1 = new List<string>();
        List<string> LearningUnitAssess2 = new List<string>();
        List<string> LearningUnitAssess3 = new List<string>();
        //Pages
        List<string> Assesment1Page = new List<string>();
        List<string> Assesment2Page = new List<string>();
        List<string> Assesment3Page = new List<string>();
        //Requirred study hours
        List<double> Assesment1Hours = new List<double>();
        List<double> Assesment2Hours = new List<double>();
        List<double> Assesment3Hours = new List<double>();
        //hours remaimning
        List<double> hoursRemaining = new List<double>();
        //assessment type 1 or 2
        List<int> assessmenttype = new List<int>();
        //what Assessment theyre studying
        List<string> studyReason = new List<string>();
        public StudyPlan()
        {
            InitializeComponent();
            lblErr1.Visible = false;
            lblnowStudying.Visible = false;
            try
            {
                connection.Open();
                string query = "Select * from Modules where Username = '"+UserInformation.Username+"';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = query;
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    cmbModules.Items.Add(drd["ModuleName"].ToString());
                    ModuleName2.Add(drd["ModuleName"].ToString()); 
                    cmbModules.ValueMember = drd["ModuleCode"].ToString();
                    cmbModules.DisplayMember = drd["ModuleName"].ToString();
                    //Gettong the learning units
                    LearningUnitAssess1.Add(drd["LearingUnitForAssess1"].ToString());
                    LearningUnitAssess2.Add(drd["LearingUnitForAssess2"].ToString());
                    LearningUnitAssess3.Add(drd["LearingUnitForAssess3"].ToString());
                    //Populating pages
                    Assesment1Page.Add(drd["Assess1Pages"].ToString());
                    Assesment2Page.Add(drd["Assess2Pages"].ToString());
                    Assesment3Page.Add(drd["Assess3Pages"].ToString());
                    assessmenttype.Add(Convert.ToInt32(drd["ModuleAssessType_1forPOE_2ForAssess"].ToString()));
                    //populating hours
                    Assesment1Hours.Add(Convert.ToInt32(drd["Assess1HoursReq"].ToString()));
                    Assesment2Hours.Add(Convert.ToInt32(drd["Assess2HoursReq"].ToString()));
                    Assesment3Hours.Add(Convert.ToInt32(drd["Assess3HoursReq"].ToString()));
                }
            }
            
            catch (SqlException ter)
            {
                MessageBox.Show(ter.Message);
            }
            catch (Exception uy)
            {
                MessageBox.Show(uy.Message);
            } 
            
            finally
            {
                connection.Close();
            }
            try
            {
                string query = "Select * from personalStudy where Username = '" + UserInformation.Username + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = query;
                connection.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    //edite sudy now here
                    listModules.Items.Add(drd["ModuleName"].ToString());
                    listModules.ValueMember = drd["Username"].ToString();
                    listModules.DisplayMember = drd["ModuleName"].ToString();
                    studyReason.Add(drd["studyReason"].ToString());
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
        System.Timers.Timer ti;
        int hr, min, sec,sec1, ms;
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                System.Environment.Exit(3);
            }
            else
            {
                //do whatever you want
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Text = "";
        }

        private void StudyPlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            ti.Stop();
            Application.DoEvents();
        }

        private void StudyPlan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hackathonDataSet.personalStudy' table. You can move, or remove it, as needed.
            this.personalStudyTableAdapter.Fill(this.hackathonDataSet.personalStudy);
            ti = new System.Timers.Timer();
            ti.Interval = 10;//1 ms
            ti.Elapsed += onTimeEvent;
        }

        private void onTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            ms += 1;
            Invoke(new Action(() =>
           {
               if (ms == 60)
               {
                   ms = 0;
                   sec += 1;
                   sec1 += 1;
               }
               if (sec == 60)
               {
                   sec = 0;
                   min += 1;
               }
               if (min == 60)
               {
                   min = 0;
                   hr += 1;
               }
               
               timer.Text = string.Format("{0}:{1}:{2}:{3}", hr.ToString().PadLeft(2, '0'), min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'), ms.ToString().PadLeft(2, '0'));
           }));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ti.Stop();
           
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Module is : " + listModules.GetItemText(listModules.SelectedItem),"Alert");
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }



        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new MyModules().Show();
            this.Hide();
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            new MyModuleGoal().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Study Plan Page","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmbModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AFTER SELECTING MODULE CHCK IF ITS A POE MODULE
            for (int i = 0; i < ModuleName2.Count; i++)
            {
                if (cmbModules.SelectedItem.Equals(ModuleName2[i]))
                {
                    lblAssignment.Text = "";
                    if (assessmenttype[i] == 1)
                    {
                        //its a poe
                        cmbStudyType.Items.Clear();
                        cmbStudyType.Items.Add("Towards Task 1");
                        cmbStudyType.Items.Add("Towards Task 2");
                        cmbStudyType.Items.Add("Towards Final Poe");
                        cmbStudyType.Items.Add("General study");
                    }
                    else if (assessmenttype[i] == 2)
                    {
                        //not a poe
                        cmbStudyType.Items.Clear();
                        cmbStudyType.Items.Add("Towards My Assignment");
                        cmbStudyType.Items.Add("Towards My Test");
                        cmbStudyType.Items.Add("Towards My Exam");
                        cmbStudyType.Items.Add("General study");

                    }
                } 
            }

        }

        private void btnFinalMark_Click(object sender, EventArgs e)
        {
            new CalculateFinalMark().Show();
            this.Hide();
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Stop Studying?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
               try
                {
                    connection.Open();
                    MessageBox.Show("You have studyed " + cmbModules.SelectedItem + " for the following time:\n" +
                                    "Hours: " + TimeMethods.ConvertToHours(sec1) + "\n" +
                                    "Minutes: " +Convert.ToDouble(TimeMethods.ConvertToMinutes(sec1)),"Alert",MessageBoxButtons.OK,MessageBoxIcon.Information) ;
                    double resul = (sec1 / 60);
                    double result = TimeMethods.ConvertToMinutes(sec1);
                    string query = "UPDATE personalStudy " +
                                    " SET MinutesStudied = '" + resul + "'"+
                                    " WHERE ModuleName = '" + listModules.GetItemText(listModules.SelectedItem) + "';";
                   
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader read = command.ExecuteReader();
                    new StudyPlan().Show();
                    this.Hide();
                  }
                catch (SqlException er)
                {

                    MessageBox.Show(er.Message);
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
                //do nothing
            }
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbModules.SelectedItem != null  )
                {
                    if (cmbStudyType.SelectedItem != null)
                    {
                        if (txtHours.Text.Length != 0)
                        {
                            try
                            {
                                for (int i = 0; i < listModules.Items.Count; i++)
                                {
                                    if (cmbModules.SelectedItem != listModules.Items)
                                    {
                                        connection.Open();
                                        String query = "insert into personalStudy(Username,ModuleName,studyDate,Hours,studyReason) " +
                                            "values('" + UserInformation.Username + "','" + cmbModules.GetItemText(cmbModules.SelectedItem) + "','" + Convert.ToDateTime(dateTimePicker1.Value) + "','" + Convert.ToInt32(txtHours.Text) * 60 + "','" + cmbStudyType.SelectedItem + "');";
                                        SqlCommand command = new SqlCommand(query, connection);
                                        SqlDataReader read = command.ExecuteReader();
                                        MessageBox.Show("Successfully added " + cmbModules.SelectedItem + " to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        read.Close();
                                        new StudyPlan().Show();
                                        this.Hide();  
                                    }
                                }

                            }
                            catch (SqlException er)
                            {
                                MessageBox.Show(er.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter data on textboxes", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    lblErr1.Visible = true;
                }

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

        private void btnStart_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You want to Start Studying "+ listModules.GetItemText(listModules.SelectedItem) +" Now?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dr == DialogResult.Yes)
            {
                ti.Start();
                panelPrepare.Visible = false;
                //setting new location for the panel
                panelStudy.Location = new Point(420, 80);
                //hide list
                listModules.Visible = false;
                //making the label visible
                lblnowStudying.Visible = true;
                lblAssignment.Visible = true;
                lblLearUni.Visible = true;
                //hiding buttons
                btnHome.Enabled = false;
                btnModules.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = false;

                lblnowStudying.Text = "Now Studying: " + listModules.GetItemText(listModules.SelectedItem);
                lblStudyNow.Text = "Studying in progress";
                //lblStudyNow.Location = new Point(426, 97);
                for (int i = 0; i < ModuleName2.Count; i++)
                {
                    if (listModules.GetItemText(listModules.SelectedItem) == ModuleName2[i])
                    {
                        
                        if (assessmenttype[i] == 1)
                        {

                            //its a poe
                            for (int j = 0; j < studyReason.Count; j++)
                            {
                                if (studyReason[j] == "Towards Task 1")
                                {
                                    //studying for assignment
                                    lblAssignment.Text = "Studying towards Task 1";
                                    lblLearUni.Text = "Learning units to be covered: " + LearningUnitAssess1[i];
                                    lblPages.Text = Assesment1Page[i];
                                    lblReqHours.Text = "Requirred hours: " + Assesment1Hours[i];
                                }
                                else if (studyReason[j] == "Towards Task 2")
                                {
                                    //studying for Test
                                    lblAssignment.Text = "Studying towards Task 2";
                                    lblLearUni.Text = "Learning units to be covered: " + LearningUnitAssess2[i];
                                    lblPages.Text = Assesment2Page[i];
                                    lblReqHours.Text = "Requirred hours: " + Assesment2Hours[i];
                                }
                                else if (studyReason[j] == "Towards Final Poe")
                                {
                                    //studying for Exam
                                    lblAssignment.Text = "Studying towards Final Poe";
                                    lblLearUni.Text = "Learning units to be covered: " + LearningUnitAssess3[i];
                                    lblPages.Text = Assesment3Page[i];
                                    lblReqHours.Text = "Requirred hours: " + Assesment3Hours[i];
                                }
                                else if (studyReason[j] == "General study")
                                {
                                    //studying genaral study
                                    lblAssignment.Text = "" + studyReason[j];
                                    lblLearUni.Text = "Total Learning units" + LearningUnitAssess3[i];
                                    lblPages.Text = "Requirred hours N/A";
                                    lblReqHours.Text = "";
                                } 
                            }
                            
                        } else if (assessmenttype[i] == 2)
                        {
                            //not a poe
                            for (int j = 0; j < studyReason.Count; j++)
                            {
                                if (studyReason[j] == "Towards My Assignment")
                                {
                                    //studying for assignment
                                    lblAssignment.Text = "Studying towards my Assignment";
                                    lblLearUni.Text = "Learning units to be covered: " + LearningUnitAssess1[i];
                                    lblPages.Text = Assesment1Page[i];
                                    lblReqHours.Text = "Requirred hours: " + Assesment1Hours[i];
                                }
                                else if (studyReason[j] == "Towards My Test")
                                {
                                    //studying for Test
                                    lblAssignment.Text = "Studying towards my Test";
                                    lblLearUni.Text = "Learning units to be covered: " + LearningUnitAssess2[i];
                                    lblPages.Text = Assesment2Page[i];
                                    lblReqHours.Text = "Requirred hours: " + Assesment2Hours[i];
                                }
                                else if (studyReason[j] == "Towards My Exam")
                                {
                                    //studying for Exam
                                    lblAssignment.Text = "Studying towards my Exam";
                                    lblLearUni.Text = "Learning units to be covered: " + LearningUnitAssess3[i];
                                    lblPages.Text = Assesment3Page[i];
                                    lblReqHours.Text = "Exam hours: " + Assesment3Hours[i];
                                }
                                else if (studyReason[j] == "General study")
                                {
                                    //studying genaral study
                                    lblAssignment.Text = "" + studyReason[j];
                                    lblLearUni.Text = "Total Learning units: " + LearningUnitAssess3[i];
                                    lblPages.Text = "Requirred hours N/A";
                                    lblReqHours.Text = "";
                                } 
                            }
                        }
                    }
                   
                }
            }
            else
            {
                //do nothing
            }
            

        }
    }
}
