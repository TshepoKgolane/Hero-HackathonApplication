
namespace HackathonApplication
{
    partial class MyModuleGoal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyModuleGoal));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnGoal = new System.Windows.Forms.Button();
            this.cmbOutcome = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModules = new System.Windows.Forms.ComboBox();
            this.lblgoaltitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFinalMark = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStudyPlan = new System.Windows.Forms.Button();
            this.btnCapModules = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set a Goal For a Module";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnGoal);
            this.panel1.Controls.Add(this.cmbOutcome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbModules);
            this.panel1.Controls.Add(this.lblgoaltitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(620, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 331);
            this.panel1.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.Location = new System.Drawing.Point(231, 253);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(95, 33);
            this.btnDashboard.TabIndex = 50;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnGoal
            // 
            this.btnGoal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoal.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGoal.Location = new System.Drawing.Point(107, 253);
            this.btnGoal.Name = "btnGoal";
            this.btnGoal.Size = new System.Drawing.Size(99, 33);
            this.btnGoal.TabIndex = 5;
            this.btnGoal.Text = "Set Goal";
            this.btnGoal.UseVisualStyleBackColor = false;
            this.btnGoal.Click += new System.EventHandler(this.btnGoal_Click);
            // 
            // cmbOutcome
            // 
            this.cmbOutcome.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOutcome.FormattingEnabled = true;
            this.cmbOutcome.Items.AddRange(new object[] {
            "I want a Distinction",
            "I just want to pass"});
            this.cmbOutcome.Location = new System.Drawing.Point(133, 203);
            this.cmbOutcome.Name = "cmbOutcome";
            this.cmbOutcome.Size = new System.Drawing.Size(154, 30);
            this.cmbOutcome.TabIndex = 4;
            this.cmbOutcome.Text = "     --Select Outcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Outcome";
            // 
            // cmbModules
            // 
            this.cmbModules.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModules.FormattingEnabled = true;
            this.cmbModules.Location = new System.Drawing.Point(133, 100);
            this.cmbModules.Name = "cmbModules";
            this.cmbModules.Size = new System.Drawing.Size(138, 30);
            this.cmbModules.TabIndex = 2;
            this.cmbModules.Text = "     --Select Module";
            // 
            // lblgoaltitle
            // 
            this.lblgoaltitle.AutoSize = true;
            this.lblgoaltitle.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgoaltitle.Location = new System.Drawing.Point(153, 57);
            this.lblgoaltitle.Name = "lblgoaltitle";
            this.lblgoaltitle.Size = new System.Drawing.Size(91, 22);
            this.lblgoaltitle.TabIndex = 1;
            this.lblgoaltitle.Text = "Select Module";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 29);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 29);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "My Goals";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(392, 300);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Module";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "My Goal";
            this.columnHeader2.Width = 150;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(181, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 331);
            this.panel4.TabIndex = 51;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.btnExit);
            this.MenuPanel.Controls.Add(this.btnFinalMark);
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Controls.Add(this.btnStudyPlan);
            this.MenuPanel.Controls.Add(this.btnCapModules);
            this.MenuPanel.Controls.Add(this.btnHome);
            this.MenuPanel.Controls.Add(this.panel3);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(141, 556);
            this.MenuPanel.TabIndex = 52;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(139, 73);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFinalMark
            // 
            this.btnFinalMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinalMark.FlatAppearance.BorderSize = 0;
            this.btnFinalMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalMark.ForeColor = System.Drawing.Color.Black;
            this.btnFinalMark.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalMark.Image")));
            this.btnFinalMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalMark.Location = new System.Drawing.Point(0, 362);
            this.btnFinalMark.Name = "btnFinalMark";
            this.btnFinalMark.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFinalMark.Size = new System.Drawing.Size(139, 73);
            this.btnFinalMark.TabIndex = 11;
            this.btnFinalMark.Text = "   Insights(Premium)";
            this.btnFinalMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalMark.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 289);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(139, 73);
            this.button1.TabIndex = 9;
            this.button1.Text = "   Set a Goal";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStudyPlan
            // 
            this.btnStudyPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudyPlan.FlatAppearance.BorderSize = 0;
            this.btnStudyPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudyPlan.ForeColor = System.Drawing.Color.Black;
            this.btnStudyPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnStudyPlan.Image")));
            this.btnStudyPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudyPlan.Location = new System.Drawing.Point(0, 216);
            this.btnStudyPlan.Name = "btnStudyPlan";
            this.btnStudyPlan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStudyPlan.Size = new System.Drawing.Size(139, 73);
            this.btnStudyPlan.TabIndex = 7;
            this.btnStudyPlan.Text = "  Study Plan";
            this.btnStudyPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudyPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudyPlan.UseVisualStyleBackColor = true;
            this.btnStudyPlan.Click += new System.EventHandler(this.btnStudyPlan_Click);
            // 
            // btnCapModules
            // 
            this.btnCapModules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCapModules.FlatAppearance.BorderSize = 0;
            this.btnCapModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapModules.ForeColor = System.Drawing.Color.Black;
            this.btnCapModules.Image = ((System.Drawing.Image)(resources.GetObject("btnCapModules.Image")));
            this.btnCapModules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapModules.Location = new System.Drawing.Point(0, 143);
            this.btnCapModules.Name = "btnCapModules";
            this.btnCapModules.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCapModules.Size = new System.Drawing.Size(139, 73);
            this.btnCapModules.TabIndex = 3;
            this.btnCapModules.Text = "   My Modules";
            this.btnCapModules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapModules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapModules.UseVisualStyleBackColor = true;
            this.btnCapModules.Click += new System.EventHandler(this.btnCapModules_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 70);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(139, 73);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "   Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 70);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(141, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(926, 35);
            this.panel7.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "My Goals";
            // 
            // MyModuleGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 556);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MyModuleGoal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Module Goals";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGoal;
        private System.Windows.Forms.ComboBox cmbOutcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.ComboBox cmbModules;
        public System.Windows.Forms.Label lblgoaltitle;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFinalMark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStudyPlan;
        private System.Windows.Forms.Button btnCapModules;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
    }
}