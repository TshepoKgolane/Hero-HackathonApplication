
namespace HackathonApplication
{
    partial class StudyPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyPlan));
            this.panelPrepare = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStudyType = new System.Windows.Forms.ComboBox();
            this.lblErr1 = new System.Windows.Forms.Label();
            this.cmbModules = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.personalStudyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hackathonDataSet = new HackathonApplication.HackathonDataSet();
            this.panelStudy = new System.Windows.Forms.Panel();
            this.lblReqHours = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblLearUni = new System.Windows.Forms.Label();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblnowStudying = new System.Windows.Forms.Label();
            this.listModules = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblStudyNow = new System.Windows.Forms.Label();
            this.personalStudyTableAdapter = new HackathonApplication.HackathonDataSetTableAdapters.personalStudyTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPrepare.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalStudyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet)).BeginInit();
            this.panelStudy.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrepare
            // 
            this.panelPrepare.BackColor = System.Drawing.SystemColors.Control;
            this.panelPrepare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrepare.Controls.Add(this.label8);
            this.panelPrepare.Controls.Add(this.cmbStudyType);
            this.panelPrepare.Controls.Add(this.lblErr1);
            this.panelPrepare.Controls.Add(this.cmbModules);
            this.panelPrepare.Controls.Add(this.btnClear);
            this.panelPrepare.Controls.Add(this.btnDone);
            this.panelPrepare.Controls.Add(this.txtHours);
            this.panelPrepare.Controls.Add(this.label4);
            this.panelPrepare.Controls.Add(this.label3);
            this.panelPrepare.Controls.Add(this.dateTimePicker1);
            this.panelPrepare.Controls.Add(this.label2);
            this.panelPrepare.Controls.Add(this.panel3);
            this.panelPrepare.Location = new System.Drawing.Point(194, 80);
            this.panelPrepare.Name = "panelPrepare";
            this.panelPrepare.Size = new System.Drawing.Size(394, 438);
            this.panelPrepare.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "What are you studying towards?";
            // 
            // cmbStudyType
            // 
            this.cmbStudyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudyType.FormattingEnabled = true;
            this.cmbStudyType.Items.AddRange(new object[] {
            "Towards My Assignment",
            "Towards My Test",
            "Towards My Exam",
            "General study"});
            this.cmbStudyType.Location = new System.Drawing.Point(124, 258);
            this.cmbStudyType.Name = "cmbStudyType";
            this.cmbStudyType.Size = new System.Drawing.Size(172, 24);
            this.cmbStudyType.TabIndex = 11;
            this.cmbStudyType.Text = "--Select";
            // 
            // lblErr1
            // 
            this.lblErr1.AutoSize = true;
            this.lblErr1.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErr1.ForeColor = System.Drawing.Color.Maroon;
            this.lblErr1.Location = new System.Drawing.Point(148, 117);
            this.lblErr1.Name = "lblErr1";
            this.lblErr1.Size = new System.Drawing.Size(119, 23);
            this.lblErr1.TabIndex = 10;
            this.lblErr1.Text = "*Select a module";
            // 
            // cmbModules
            // 
            this.cmbModules.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModules.FormattingEnabled = true;
            this.cmbModules.Location = new System.Drawing.Point(123, 79);
            this.cmbModules.Name = "cmbModules";
            this.cmbModules.Size = new System.Drawing.Size(165, 31);
            this.cmbModules.TabIndex = 9;
            this.cmbModules.Text = "--Select a Module";
            this.cmbModules.SelectedIndexChanged += new System.EventHandler(this.cmbModules_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(208, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDone.Location = new System.Drawing.Point(123, 373);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(72, 31);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(123, 321);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(165, 27);
            this.txtHours.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount of hours to study";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Module to Study";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 36);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(106, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prepare personal study";
            // 
            // personalStudyBindingSource
            // 
            this.personalStudyBindingSource.DataMember = "personalStudy";
            this.personalStudyBindingSource.DataSource = this.hackathonDataSet;
            // 
            // hackathonDataSet
            // 
            this.hackathonDataSet.DataSetName = "HackathonDataSet";
            this.hackathonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelStudy
            // 
            this.panelStudy.BackColor = System.Drawing.SystemColors.Control;
            this.panelStudy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStudy.Controls.Add(this.lblReqHours);
            this.panelStudy.Controls.Add(this.lblPages);
            this.panelStudy.Controls.Add(this.lblLearUni);
            this.panelStudy.Controls.Add(this.lblAssignment);
            this.panelStudy.Controls.Add(this.btnQuit);
            this.panelStudy.Controls.Add(this.lblnowStudying);
            this.panelStudy.Controls.Add(this.listModules);
            this.panelStudy.Controls.Add(this.label7);
            this.panelStudy.Controls.Add(this.label5);
            this.panelStudy.Controls.Add(this.btnStop);
            this.panelStudy.Controls.Add(this.timer);
            this.panelStudy.Controls.Add(this.btnStart);
            this.panelStudy.Controls.Add(this.panel5);
            this.panelStudy.Location = new System.Drawing.Point(630, 80);
            this.panelStudy.Name = "panelStudy";
            this.panelStudy.Size = new System.Drawing.Size(392, 438);
            this.panelStudy.TabIndex = 4;
            // 
            // lblReqHours
            // 
            this.lblReqHours.AutoSize = true;
            this.lblReqHours.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqHours.Location = new System.Drawing.Point(141, 188);
            this.lblReqHours.Name = "lblReqHours";
            this.lblReqHours.Size = new System.Drawing.Size(109, 23);
            this.lblReqHours.TabIndex = 21;
            this.lblReqHours.Text = "requirred hours";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(168, 165);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(50, 23);
            this.lblPages.TabIndex = 20;
            this.lblPages.Text = "Pages";
            // 
            // lblLearUni
            // 
            this.lblLearUni.AutoSize = true;
            this.lblLearUni.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearUni.Location = new System.Drawing.Point(97, 142);
            this.lblLearUni.Name = "lblLearUni";
            this.lblLearUni.Size = new System.Drawing.Size(213, 23);
            this.lblLearUni.TabIndex = 19;
            this.lblLearUni.Text = "Learning units to be covered: 1-8";
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignment.Location = new System.Drawing.Point(152, 116);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(86, 23);
            this.lblAssignment.TabIndex = 18;
            this.lblAssignment.Text = "Assignment";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuit.Location = new System.Drawing.Point(155, 340);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(72, 28);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Stop";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblnowStudying
            // 
            this.lblnowStudying.AutoSize = true;
            this.lblnowStudying.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnowStudying.Location = new System.Drawing.Point(98, 87);
            this.lblnowStudying.Name = "lblnowStudying";
            this.lblnowStudying.Size = new System.Drawing.Size(191, 23);
            this.lblnowStudying.TabIndex = 5;
            this.lblnowStudying.Text = "Now Studying: Programming";
            this.lblnowStudying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listModules
            // 
            this.listModules.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listModules.FormattingEnabled = true;
            this.listModules.ItemHeight = 23;
            this.listModules.Location = new System.Drawing.Point(74, 50);
            this.listModules.Name = "listModules";
            this.listModules.Size = new System.Drawing.Size(231, 119);
            this.listModules.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Study Timer:";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.Location = new System.Drawing.Point(206, 295);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 25);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Pause";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer
            // 
            this.timer.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(193, 249);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(85, 27);
            this.timer.TabIndex = 10;
            this.timer.Text = "00:00:00:00";
            this.timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(101, 295);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 25);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblStudyNow);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 36);
            this.panel5.TabIndex = 0;
            // 
            // lblStudyNow
            // 
            this.lblStudyNow.AutoSize = true;
            this.lblStudyNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStudyNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyNow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudyNow.Location = new System.Drawing.Point(152, 8);
            this.lblStudyNow.Name = "lblStudyNow";
            this.lblStudyNow.Size = new System.Drawing.Size(80, 18);
            this.lblStudyNow.TabIndex = 1;
            this.lblStudyNow.Text = "Study Now";
            // 
            // personalStudyTableAdapter
            // 
            this.personalStudyTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnModules);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 556);
            this.panel2.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
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
            this.button1.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
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
            this.button3.ForeColor = System.Drawing.Color.Black;
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
            this.button3.Click += new System.EventHandler(this.btnGoal_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
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
            // btnModules
            // 
            this.btnModules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModules.FlatAppearance.BorderSize = 0;
            this.btnModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModules.ForeColor = System.Drawing.Color.Black;
            this.btnModules.Image = ((System.Drawing.Image)(resources.GetObject("btnModules.Image")));
            this.btnModules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModules.Location = new System.Drawing.Point(0, 136);
            this.btnModules.Name = "btnModules";
            this.btnModules.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnModules.Size = new System.Drawing.Size(144, 73);
            this.btnModules.TabIndex = 3;
            this.btnModules.Text = "   My Modules";
            this.btnModules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 63);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(144, 73);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "   Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 63);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(146, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(921, 35);
            this.panel7.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Study Plan";
            // 
            // StudyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 556);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelStudy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelPrepare);
            this.Name = "StudyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudyPlan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudyPlan_FormClosing);
            this.Load += new System.EventHandler(this.StudyPlan_Load);
            this.panelPrepare.ResumeLayout(false);
            this.panelPrepare.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalStudyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet)).EndInit();
            this.panelStudy.ResumeLayout(false);
            this.panelStudy.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPrepare;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStudy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox timer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStudyNow;
        private System.Windows.Forms.ListBox listModules;
        private HackathonDataSet hackathonDataSet;
        private System.Windows.Forms.BindingSource personalStudyBindingSource;
        private HackathonDataSetTableAdapters.personalStudyTableAdapter personalStudyTableAdapter;
        private System.Windows.Forms.Label lblnowStudying;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblErr1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cmbModules;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStudyType;
        private System.Windows.Forms.Label lblLearUni;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblReqHours;
    }
}