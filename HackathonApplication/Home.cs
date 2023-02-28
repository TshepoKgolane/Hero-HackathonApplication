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
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace HackathonApplication
{
    public partial class Home : Form
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        
        SqlConnection connection = new SqlConnection(Login.connectionString);
        public Home()
        {
            InitializeComponent();
            listView1.GridLines = true;
            listView2.GridLines = true;
            listView3.GridLines = true;
            fillChart();
            using (SqlDataAdapter myAdapter = new SqlDataAdapter("exec personalStudyProcedure @Username ='" + UserInformation.Username + "'", connection))
            {
                //Use DataAdapter to fill DataTable
                DataTable myTable = new DataTable();
                myAdapter.Fill(myTable);
                //Render Data onto the screen
            }
            lblErr.Visible = false;
            lblErr11.Visible = false;
            lblErr2.Visible = false;
            lblErr22.Visible = false;
            lblErr3.Visible = false;
            lblErr33.Visible = false;
            btnAddGoal.Visible = false;
            btnAddMarks.Visible = false;
            btnAddSched.Visible = false;
            
            goalfill();
            assessMarks();
            if (UserInformation.repetitions == 1 )
            {
                fillHome();
                UserInformation.repetitions = 0;
            }
            else
            {
                fillHomeDuplicate();
            }
            //checking the items in the list view to determine if there are any values
            //if theres no values display a message saying no data
            if (listView1.Items.Count == 0)
            {
                lblErr.Visible = true;
                lblErr11.Visible = true;
                btnAddSched.Visible = true;
            }
            if (listView2.Items.Count == 0)
            {
                lblErr2.Visible = true;
                lblErr22.Visible = true;
                btnAddMarks.Visible = true;
            }
            if (listView3.Items.Count == 0)
            {
                lblErr3.Visible = true;
                lblErr33.Visible = true;
                btnAddGoal.Visible = true;
                
            }
            
        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            //btnHome
            MessageBox.Show("Your Already on Home Page", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

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

        private void btnMyStudies_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MyModules().Show();
            
        }
        

        private void btnStudyPlan_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudyPlan myplan = new StudyPlan();
            myplan.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homepagePersonalStudydataset.personalStudy' table. You can move, or remove it, as needed.
            this.personalStudyTableAdapter1.Fill(this.homepagePersonalStudydataset.personalStudy);
            // TODO: This line of code loads data into the 'hackathonDataSet1.personalStudy' table. You can move, or remove it, as needed.
            this.personalStudyTableAdapter.Fill(this.hackathonDataSet1.personalStudy);

        }


        private void btnGoal_Click(object sender, EventArgs e)
        {
            new MyModuleGoal().Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //fillChart();
        }

        private void fillChart()
        {
            // cmmenting out the fill chart logic
            /*
            DataSet ds = new DataSet();
            connection.Open();
            string query = "Select MAX(MinutesStudied) as 'Minutes Studied',ModuleName,Hours from personalStudy where Username ='"+UserInformation.Username+"' group by ModuleName,Hours order by MAX(MinutesStudied)";
            SqlDataAdapter adapt = new SqlDataAdapter(query,connection);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            //
            chart1.Series["Module"].XValueMember = "ModuleName";
            //
            chart1.Series["Module"].YValueMembers = "Minutes Studied";
            chart1.Series["HoursToStudy"].XValueMember = "ModuleName";
            //
            chart1.Series["HoursToStudy"].YValueMembers = "Hours";


            connection.Close();
            */
        }

        private void btnFinalMark_Click(object sender, EventArgs e)
        {
            new CalculateFinalMark().Show();
            this.Hide();
        }
        public void assessMarks()
        {
            try
            {
                //AssessmentWeigh
                string query = "Select * from AssessmentMarks where Username = '" + UserInformation.Username + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = query;
                connection.Open();
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    ListViewItem item = new ListViewItem(drd["ModuleName"].ToString());
                    item.SubItems.Add(drd["Mark1"].ToString());
                    item.SubItems.Add(drd["Mark2"].ToString());
                    item.SubItems.Add(drd["Mark3"].ToString());
                    item.SubItems.Add(drd["ice"].ToString());
                    listView2.Items.Add(item);

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
                    listView3.Items.Add(item);
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
        public void fillHome()
        {
            List<string> dueToday = new List<string>();
            List<string> upcoming = new List<string>();
            List<string> late = new List<string>();
            try
            {
                string query = "Select * from personalStudy where Username = '" + UserInformation.Username + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = query;
                connection.Open();
                SqlDataReader drd = cmd.ExecuteReader();

                while (drd.Read())
                {
                    TimeSpan timeDifference = Convert.ToDateTime(drd["studyDate"].ToString()).Subtract(System.DateTime.Today.Date);
                    string modulesName = drd["ModuleName"].ToString();
                    //   MessageBox.Show("Date difference : "+ timeDifference);

                    if (timeDifference.TotalDays == 0)
                    {
                        //   MessageBox.Show("You need to study " + modulesName + " today");

                        ListViewItem item = new ListViewItem("Study today");
                        item.SubItems.Add(timeDifference.Days + " day(s)");
                        item.SubItems.Add(modulesName);
                        listView1.Items.Add(item);
                        dueToday.Add(modulesName);

                    }
                    else if (timeDifference.TotalDays > 0)
                    {
                        // MessageBox.Show("Upcoming Module is "+modulesName+" Study is in : " + timeDifference.TotalDays+" days");
                        ListViewItem item = new ListViewItem("Upcoming");
                        item.SubItems.Add(timeDifference.Days + " day(s)");
                        item.SubItems.Add(modulesName);
                        listView1.Items.Add(item);
                        upcoming.Add(modulesName);
                    }
                    else if (timeDifference.TotalDays < 0)
                    {
                        // MessageBox.Show("Late Study for "+ modulesName + " module was to be studied in : " + timeDifference.TotalDays + " days");
                        ListViewItem item = new ListViewItem("Late, by " + timeDifference.Days + " day(s)");
                        item.SubItems.Add(timeDifference.Days + " day(s)");
                        item.SubItems.Add(modulesName);
                        listView1.Items.Add(item);
                        late.Add(modulesName);
                    }
                }
                MessageBox.Show("You have " + dueToday.Count() + " Module(s) that needs to be studyed today,\n\n " + upcoming.Count() +
                    " Module(s) are to be studyed in the upcoming days and \n\n " + late.Count() + " Module(s) that have dates that passed", "My Study Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public void fillHomeDuplicate()
        {
            List<string> dueToday = new List<string>();
            List<string> upcoming = new List<string>();
            List<string> late = new List<string>();
            try
            {
                string query = "Select * from personalStudy where Username = '" + UserInformation.Username + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandText = query;
                connection.Open();
                SqlDataReader drd = cmd.ExecuteReader();

                while (drd.Read())
                {
                    TimeSpan timeDifference = Convert.ToDateTime(drd["studyDate"].ToString()).Subtract(System.DateTime.Today.Date);
                    string modulesName = drd["ModuleName"].ToString();
                    //   MessageBox.Show("Date difference : "+ timeDifference);

                    if (timeDifference.TotalDays == 0)
                    {
                        //   MessageBox.Show("You need to study " + modulesName + " today");

                        ListViewItem item = new ListViewItem("Study today");
                        item.SubItems.Add(timeDifference.Days + " day(s)");
                        item.SubItems.Add(modulesName);
                        listView1.Items.Add(item);
                        dueToday.Add(modulesName);

                    }
                    else if (timeDifference.TotalDays > 0)
                    {
                        // MessageBox.Show("Upcoming Module is "+modulesName+" Study is in : " + timeDifference.TotalDays+" days");
                        ListViewItem item = new ListViewItem("Upcoming");
                        item.SubItems.Add(timeDifference.Days + " day(s)");
                        item.SubItems.Add(modulesName);
                        listView1.Items.Add(item);
                        upcoming.Add(modulesName);
                    }
                    else if (timeDifference.TotalDays < 0)
                    {
                        // MessageBox.Show("Late Study for "+ modulesName + " module was to be studied in : " + timeDifference.TotalDays + " days");
                        ListViewItem item = new ListViewItem("Late, by " + timeDifference.Days + " day(s)");
                        item.SubItems.Add(timeDifference.Days + " day(s)");
                        item.SubItems.Add(modulesName);
                        listView1.Items.Add(item);
                        late.Add(modulesName);
                    }
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

        private void btnAddSched_Click(object sender, EventArgs e)
        {
            new StudyPlan().Show();
            this.Hide();
        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            new EditAssessments().Show();
            this.Hide();
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            new MyModuleGoal().Show();
            this.Hide();
        }
    }
}
