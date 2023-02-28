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
using MyLibrary;

namespace HackathonApplication
{
    
    public partial class CalculateFinalMark : Form
    {
        SqlConnection connection = new SqlConnection(Login.connectionString);
        private string modulecode;
        private string moduleName;
        int weigh1;
        int weigh2;
        int weigh3;
        public CalculateFinalMark()
        {
            InitializeComponent();
            lblErr0.Visible = false;
            lblErr1.Visible = false;
            lblErr3.Visible = false;


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
                    moduleName = drd["ModuleName"].ToString();
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
                connection.Open();
                //AssessmentWeigh
                string query = @"Select * from Modules where Username = '" + UserInformation.Username + "' AND ModuleCode = '"+modulecode+"';";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    weigh1 = Convert.ToInt32(drd["AssessWeight1"].ToString());
                    weigh2 = Convert.ToInt32(drd["AssessWeight2"].ToString());
                    weigh3 = Convert.ToInt32(drd["AssessWeight3"].ToString());
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

        int sum ;
        int sumweight;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbModules.SelectedItem == null)
            {
                lblErr0.Visible =true;
            }
            else if(txtAssess2.TextLength ==0 || txtAssess1.TextLength == 0 || txtAssess3.TextLength == 0)
            {
                lblErr1.Visible = true;
            }
           
            else if (txtIce.TextLength == 0)
            {
                lblErr3.Visible = true;
            }
            
            else
            {
                if (Convert.ToInt32(txtAssess1.Text) > 100 & Convert.ToInt32(txtAssess2.Text) > 100 && Convert.ToInt32(txtAssess3.Text) > 100)
                {
                    MessageBox.Show("Marks for Each of the assessments cannot be above 100,\nplease re-check each weighting and comfirm correct data insertion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                
                else
                {
                    try
                   {
                        int convertMark1 = Convert.ToInt32(txtAssess1.Text);
                        int convertMark2 = Convert.ToInt32(txtAssess2.Text);
                        int convertMark3 = Convert.ToInt32(txtAssess3.Text);
                        int convertMark4 = Convert.ToInt32(txtIce.Text);

                        sum = convertMark1 + convertMark2 + convertMark3;
                        sumweight = Convert.ToInt32(txtAssess3.Text) + Convert.ToInt32(txtAssess2.Text) + Convert.ToInt32(txtAssess1.Text);
                        ModuleMethods my = new ModuleMethods();
                        double finalplus = my.CalculateFinal(convertMark1, convertMark2, convertMark3, convertMark4, weigh1, weigh2, weigh3, 10);
                        connection.Open();
                        string query = "Insert into AssessmentMarks(Username,ModuleName,Mark1,Mark2,Mark3,ice) " +
                            "values('" +UserInformation.Username +"','"+cmbModules.SelectedItem+"',"+convertMark1+","+convertMark2 + "," + convertMark3 + "," + convertMark4+ ");";
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataReader read = command.ExecuteReader();

                        if (finalplus>=75)
                        {
                            MessageBox.Show("Your Assignment Mark is: " +convertMark1+
                            "\nYour Test Mark is: " +convertMark2+
                            "\nYour Exam Mark is: " +convertMark3+
                            "\nFinal mark is:" + finalplus + "% Which is a Distinction!","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            DialogResult dr = MessageBox.Show("Would you like to capture Marks for another Module?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                txtAssess1.Text = "";
                                txtAssess2.Text = "";
                                txtAssess3.Text = "";
                                txtIce.Text = "";
                            }
                            else
                            {
                                new Home().Show();
                                this.Hide();
                                //do whatever you want
                            }
                        }
                        else if (finalplus >= 50 && finalplus<75)
                        {
                            MessageBox.Show("Your Assignment Mark is: " + convertMark1 +
                            "\nYour Test Mark is: " + convertMark2 +
                            "\nYour Exam Mark is: " + convertMark3 +
                            "\nFinal mark is:" + finalplus + "%"+" You have passed!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult dr = MessageBox.Show("Would you like to capture Marks for another Module?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                txtAssess1.Text = "";
                                txtAssess2.Text = "";
                                txtAssess3.Text = "";
                                txtIce.Text = "";
                            }
                            else
                            {
                                new Home().Show();
                                this.Hide();
                                //do whatever you want
                            }
                        }
                        else if (finalplus < 50)
                        {
                            MessageBox.Show("Your Assignment Mark is: " + convertMark1 +
                            "\nYour Test Mark is: " + convertMark2 +
                            "\nYour Exam Mark is: " + convertMark3 +
                            "\nFinal mark is:" + finalplus + "%" + " You have Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult dr = MessageBox.Show("Would you like to capture Marks for another Module?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                txtAssess1.Text = "";
                                txtAssess2.Text = "";
                                txtAssess3.Text = "";
                                txtIce.Text = "";
                            }
                            else
                            {
                                new Home().Show();
                                this.Hide();
                                //do whatever you want
                            }
                        }

                    }
                    catch (SqlException sqq)
                    {
                        MessageBox.Show(sqq.Message, "Error");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please Ensure you entered the correct format.\n" +
                            "Refrain from entering characters where numbers are needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                
                }

            }
        }
        public void HandlingRadioButtons()
        {
            
            
            
        }

        private void rbtnPoe_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnExam_CheckedChanged(object sender, EventArgs e)
        {
            //hello stub :)
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new CaptureModules().Show();
            this.Hide();
        }

        private void CalculateFinalMark_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hackathonDataSet9.AssessmentMarks' table. You can move, or remove it, as needed.
            this.assessmentMarksTableAdapter1.Fill(this.hackathonDataSet9.AssessmentMarks);
            // TODO: This line of code loads data into the 'hackathonDataSet8.AssessmentMarks' table. You can move, or remove it, as needed.
            this.assessmentMarksTableAdapter.Fill(this.hackathonDataSet8.AssessmentMarks);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(4);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            new CalculateFinalMark();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnCapModules_Click(object sender, EventArgs e)
        {
            new CaptureModules().Show();
            this.Hide();
        }


        private void btnFinalMark_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the page");
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void cmbModules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new MyModules().Show();
            this.Hide();
        }
    }
}
