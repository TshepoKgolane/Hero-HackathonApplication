using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonApplication
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnCapModules_Click(object sender, EventArgs e)
        {
            new txtpage1().Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new ManageModules().Show();
            this.Hide();
        }
    }
}
