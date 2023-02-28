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
    public partial class ManageModules : Form
    {
        SqlConnection connection = new SqlConnection(Login.connectionString);
        public string moduleName;
        public ManageModules()
        {
            

            InitializeComponent();
            try
            {
                connection.Open();
                string query = @"Select * from FullModule where;";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    cmbModules.Items.Add(read["ModuleName"].ToString());
                    moduleName = read["ModuleName"].ToString();
                }

                connection.Close();
            }
            catch (Exception )
            {
                throw;
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
          //stub #2 :)
        }
        string[] DatabaseTitles = new string[]{"CourseCode","ModuleName", "AssessWeight1", "AssessWeight2", "AssessWeight3", "iceWeight", "ReqHours",
            "ModuleAssessType_1forPOE_2ForAssess","LearingUnitForAssess1","LearingUnitForAssess2","LearingUnitForAssess3","Assess1HoursReq",
            "Assess2HoursReq","Assess3HoursReq","year" };
        string[] comboTitles = new string[] {"CourseCode","ModuleName","Assessment1 Percentage","Assessment2 Percentage","Assessment3 Percentage",
            "ice Percentage","Requirred Hours","AssessmentType-1_forPOE-2_forAssignment","Learning Unit for Assess1","Learning Unit for Assess2","Learning Unit for Assess3",
            "RequirredHours for assignment","RequirredHours for Test","RequirredHours for Exam","year"};
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbChange.SelectedItem.Equals("Course Code"))
            {
                try
                {
                    for (int i = 0; i < comboTitles.Length; i++)
                    {
                        if (cmbChange.SelectedItem.Equals(comboTitles[i]))
                        {
                            connection.Open();
                            string query = "update Modules" +
                            "set " + DatabaseTitles[i] + " = '" + txtValue.Text + "';";
                            SqlCommand command = new SqlCommand(query, connection);
                            SqlDataReader reader = command.ExecuteReader();
                            MessageBox.Show("Successfully Updated "+comboTitles[i] + "Success");
                            connection.Close();
                        }
                    }
                    
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }
    }
}
