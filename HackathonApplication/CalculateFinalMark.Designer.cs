
namespace HackathonApplication
{
    partial class CalculateFinalMark
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateFinalMark));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbModules = new System.Windows.Forms.ComboBox();
            this.lblErr3 = new System.Windows.Forms.Label();
            this.txtIce = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErr0 = new System.Windows.Forms.Label();
            this.lblErr1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAssess3 = new System.Windows.Forms.Label();
            this.txtAssess3 = new System.Windows.Forms.TextBox();
            this.lblAssess2 = new System.Windows.Forms.Label();
            this.txtAssess2 = new System.Windows.Forms.TextBox();
            this.lblAssess1 = new System.Windows.Forms.Label();
            this.txtAssess1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hackathonDataSet4 = new HackathonApplication.HackathonDataSet4();
            this.modulesTableAdapter = new HackathonApplication.HackathonDataSet4TableAdapters.ModulesTableAdapter();
            this.assessmentMarksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hackathonDataSet9 = new HackathonApplication.HackathonDataSet9();
            this.hackathonDataSet8 = new HackathonApplication.HackathonDataSet8();
            this.assessmentMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentMarksTableAdapter = new HackathonApplication.HackathonDataSet8TableAdapters.AssessmentMarksTableAdapter();
            this.assessmentMarksTableAdapter1 = new HackathonApplication.HackathonDataSet9TableAdapters.AssessmentMarksTableAdapter();
            this.assessmentMarksTableAdapter2 = new HackathonApplication.HackathonDataSet9TableAdapters.AssessmentMarksTableAdapter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentMarksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentMarksBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.cmbModules);
            this.panel3.Controls.Add(this.lblErr3);
            this.panel3.Controls.Add(this.txtIce);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblErr0);
            this.panel3.Controls.Add(this.lblErr1);
            this.panel3.Controls.Add(this.btnCalculate);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lblAssess3);
            this.panel3.Controls.Add(this.txtAssess3);
            this.panel3.Controls.Add(this.lblAssess2);
            this.panel3.Controls.Add(this.txtAssess2);
            this.panel3.Controls.Add(this.lblAssess1);
            this.panel3.Controls.Add(this.txtAssess1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(330, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 454);
            this.panel3.TabIndex = 8;
            // 
            // cmbModules
            // 
            this.cmbModules.FormattingEnabled = true;
            this.cmbModules.Location = new System.Drawing.Point(159, 73);
            this.cmbModules.Name = "cmbModules";
            this.cmbModules.Size = new System.Drawing.Size(146, 21);
            this.cmbModules.TabIndex = 31;
            this.cmbModules.Text = "Select Module";
            this.cmbModules.SelectedIndexChanged += new System.EventHandler(this.cmbModules_SelectedIndexChanged);
            // 
            // lblErr3
            // 
            this.lblErr3.AutoSize = true;
            this.lblErr3.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErr3.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErr3.Location = new System.Drawing.Point(199, 358);
            this.lblErr3.Name = "lblErr3";
            this.lblErr3.Size = new System.Drawing.Size(91, 19);
            this.lblErr3.TabIndex = 30;
            this.lblErr3.Text = "*insert Ice Mark";
            // 
            // txtIce
            // 
            this.txtIce.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIce.Location = new System.Drawing.Point(190, 331);
            this.txtIce.Name = "txtIce";
            this.txtIce.Size = new System.Drawing.Size(100, 24);
            this.txtIce.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ice task Mark";
            // 
            // lblErr0
            // 
            this.lblErr0.AutoSize = true;
            this.lblErr0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErr0.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErr0.Location = new System.Drawing.Point(173, 97);
            this.lblErr0.Name = "lblErr0";
            this.lblErr0.Size = new System.Drawing.Size(124, 13);
            this.lblErr0.TabIndex = 27;
            this.lblErr0.Text = "*insert Module Name";
            // 
            // lblErr1
            // 
            this.lblErr1.AutoSize = true;
            this.lblErr1.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErr1.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErr1.Location = new System.Drawing.Point(179, 274);
            this.lblErr1.Name = "lblErr1";
            this.lblErr1.Size = new System.Drawing.Size(133, 19);
            this.lblErr1.TabIndex = 25;
            this.lblErr1.Text = "*insert all values above";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculate.Location = new System.Drawing.Point(124, 396);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 25);
            this.btnCalculate.TabIndex = 24;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(155, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "Enter the Marks for the following";
            // 
            // lblAssess3
            // 
            this.lblAssess3.AutoSize = true;
            this.lblAssess3.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssess3.Location = new System.Drawing.Point(170, 242);
            this.lblAssess3.Name = "lblAssess3";
            this.lblAssess3.Size = new System.Drawing.Size(67, 19);
            this.lblAssess3.TabIndex = 15;
            this.lblAssess3.Text = "Exam Mark:";
            // 
            // txtAssess3
            // 
            this.txtAssess3.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssess3.Location = new System.Drawing.Point(248, 239);
            this.txtAssess3.Name = "txtAssess3";
            this.txtAssess3.Size = new System.Drawing.Size(64, 24);
            this.txtAssess3.TabIndex = 14;
            // 
            // lblAssess2
            // 
            this.lblAssess2.AutoSize = true;
            this.lblAssess2.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssess2.Location = new System.Drawing.Point(175, 204);
            this.lblAssess2.Name = "lblAssess2";
            this.lblAssess2.Size = new System.Drawing.Size(62, 19);
            this.lblAssess2.TabIndex = 13;
            this.lblAssess2.Text = "Test Mark:";
            // 
            // txtAssess2
            // 
            this.txtAssess2.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssess2.Location = new System.Drawing.Point(248, 201);
            this.txtAssess2.Name = "txtAssess2";
            this.txtAssess2.Size = new System.Drawing.Size(64, 24);
            this.txtAssess2.TabIndex = 12;
            // 
            // lblAssess1
            // 
            this.lblAssess1.AutoSize = true;
            this.lblAssess1.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssess1.Location = new System.Drawing.Point(139, 169);
            this.lblAssess1.Name = "lblAssess1";
            this.lblAssess1.Size = new System.Drawing.Size(103, 19);
            this.lblAssess1.TabIndex = 6;
            this.lblAssess1.Text = "Assignment Mark:";
            // 
            // txtAssess1
            // 
            this.txtAssess1.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssess1.Location = new System.Drawing.Point(248, 164);
            this.txtAssess1.Name = "txtAssess1";
            this.txtAssess1.Size = new System.Drawing.Size(64, 24);
            this.txtAssess1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Module Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(507, 28);
            this.panel4.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(169, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Capture final Mark";
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataMember = "Modules";
            this.modulesBindingSource.DataSource = this.hackathonDataSet4;
            // 
            // hackathonDataSet4
            // 
            this.hackathonDataSet4.DataSetName = "HackathonDataSet4";
            this.hackathonDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentMarksBindingSource1
            // 
            this.assessmentMarksBindingSource1.DataMember = "AssessmentMarks";
            this.assessmentMarksBindingSource1.DataSource = this.hackathonDataSet9;
            // 
            // hackathonDataSet9
            // 
            this.hackathonDataSet9.DataSetName = "HackathonDataSet9";
            this.hackathonDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hackathonDataSet8
            // 
            this.hackathonDataSet8.DataSetName = "HackathonDataSet8";
            this.hackathonDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentMarksBindingSource
            // 
            this.assessmentMarksBindingSource.DataMember = "AssessmentMarks";
            this.assessmentMarksBindingSource.DataSource = this.hackathonDataSet8;
            // 
            // assessmentMarksTableAdapter
            // 
            this.assessmentMarksTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentMarksTableAdapter1
            // 
            this.assessmentMarksTableAdapter1.ClearBeforeFill = true;
            // 
            // assessmentMarksTableAdapter2
            // 
            this.assessmentMarksTableAdapter2.ClearBeforeFill = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(146, 556);
            this.panel6.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 428);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(144, 73);
            this.button1.TabIndex = 12;
            this.button1.Text = "   Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 355);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(144, 73);
            this.button2.TabIndex = 11;
            this.button2.Text = "   Insights(premium)";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 282);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(144, 73);
            this.button3.TabIndex = 9;
            this.button3.Text = "   Set a Goal";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 209);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(144, 73);
            this.button4.TabIndex = 7;
            this.button4.Text = "  Study Plan";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 136);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(144, 73);
            this.button5.TabIndex = 3;
            this.button5.Text = "   My Modules";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 63);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(144, 73);
            this.button6.TabIndex = 1;
            this.button6.Text = "   Home";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(144, 63);
            this.panel7.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(146, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(921, 35);
            this.panel5.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capture my Marks";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(263, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 25);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CalculateFinalMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 556);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Name = "CalculateFinalMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Modules";
            this.Load += new System.EventHandler(this.CalculateFinalMark_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentMarksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentMarksBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAssess1;
        private System.Windows.Forms.TextBox txtAssess1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAssess3;
        private System.Windows.Forms.TextBox txtAssess3;
        private System.Windows.Forms.Label lblAssess2;
        private System.Windows.Forms.TextBox txtAssess2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblErr0;
        private System.Windows.Forms.Label lblErr1;
        private System.Windows.Forms.Label lblErr3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbModules;
        private HackathonDataSet4 hackathonDataSet4;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private HackathonDataSet4TableAdapters.ModulesTableAdapter modulesTableAdapter;
        private HackathonDataSet8 hackathonDataSet8;
        private System.Windows.Forms.BindingSource assessmentMarksBindingSource;
        private HackathonDataSet8TableAdapters.AssessmentMarksTableAdapter assessmentMarksTableAdapter;
        private HackathonDataSet9 hackathonDataSet9;
        private System.Windows.Forms.BindingSource assessmentMarksBindingSource1;
        private HackathonDataSet9TableAdapters.AssessmentMarksTableAdapter assessmentMarksTableAdapter1;
        private System.Windows.Forms.TextBox txtIce;
        private HackathonDataSet9TableAdapters.AssessmentMarksTableAdapter assessmentMarksTableAdapter2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}