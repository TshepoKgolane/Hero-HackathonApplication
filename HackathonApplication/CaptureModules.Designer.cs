
namespace HackathonApplication
{
    partial class CaptureModules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureModules));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hackathonDataSet5 = new HackathonApplication.HackathonDataSet5();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulesTableAdapter = new HackathonApplication.HackathonDataSet5TableAdapters.ModulesTableAdapter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listModules = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbModules = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbModules);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.btnModules);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(182, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 361);
            this.panel1.TabIndex = 1;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashBoard.Location = new System.Drawing.Point(215, 179);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(75, 23);
            this.btnDashBoard.TabIndex = 8;
            this.btnDashBoard.Text = "Home";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnModules
            // 
            this.btnModules.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModules.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModules.Location = new System.Drawing.Point(98, 179);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(75, 23);
            this.btnModules.TabIndex = 7;
            this.btnModules.Text = "Add";
            this.btnModules.UseVisualStyleBackColor = false;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(119, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available modules to add";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 28);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(150, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capture a Module";
            // 
            // hackathonDataSet5
            // 
            this.hackathonDataSet5.DataSetName = "HackathonDataSet5";
            this.hackathonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataMember = "Modules";
            this.modulesBindingSource.DataSource = this.hackathonDataSet5;
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
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
            this.panel6.Size = new System.Drawing.Size(146, 450);
            this.panel6.TabIndex = 38;
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
            this.button1.Location = new System.Drawing.Point(0, 363);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(144, 65);
            this.button1.TabIndex = 12;
            this.button1.Text = "   Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 303);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(144, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "   Insights(Premium)";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 243);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(144, 60);
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
            this.button4.Location = new System.Drawing.Point(0, 183);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(144, 60);
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
            this.button5.Location = new System.Drawing.Point(0, 123);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(144, 60);
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
            this.button6.Size = new System.Drawing.Size(144, 60);
            this.button6.TabIndex = 1;
            this.button6.Text = "   Home";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            // listModules
            // 
            this.listModules.BackColor = System.Drawing.SystemColors.Control;
            this.listModules.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listModules.FormattingEnabled = true;
            this.listModules.Location = new System.Drawing.Point(0, 26);
            this.listModules.Name = "listModules";
            this.listModules.Size = new System.Drawing.Size(289, 329);
            this.listModules.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.listModules);
            this.panel3.Location = new System.Drawing.Point(600, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 361);
            this.panel3.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 29);
            this.panel4.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(97, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "My Modules";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(467, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 22);
            this.lblTitle.TabIndex = 43;
            this.lblTitle.Text = "Enter a new module";
            // 
            // cmbModules
            // 
            this.cmbModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModules.FormattingEnabled = true;
            this.cmbModules.Location = new System.Drawing.Point(122, 109);
            this.cmbModules.Name = "cmbModules";
            this.cmbModules.Size = new System.Drawing.Size(141, 23);
            this.cmbModules.TabIndex = 9;
            this.cmbModules.Text = "Select Module";
            // 
            // CaptureModules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "CaptureModules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaptureModules";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hackathonDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashBoard;
        private HackathonDataSet5 hackathonDataSet5;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private HackathonDataSet5TableAdapters.ModulesTableAdapter modulesTableAdapter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox listModules;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbModules;
    }
}