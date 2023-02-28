
namespace HackathonApplication
{
    partial class EditAssessments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.cmbAssessment = new System.Windows.Forms.ComboBox();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErr2 = new System.Windows.Forms.Label();
            this.lblErr1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblErr1);
            this.panel1.Controls.Add(this.lblErr2);
            this.panel1.Controls.Add(this.txtMark);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnProceed);
            this.panel1.Controls.Add(this.cmbAssessment);
            this.panel1.Controls.Add(this.cmbModule);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(224, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 428);
            this.panel1.TabIndex = 2;
            // 
            // txtMark
            // 
            this.txtMark.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMark.Location = new System.Drawing.Point(171, 303);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(120, 24);
            this.txtMark.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter the Mark";
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Poppins Light", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProceed.Location = new System.Drawing.Point(175, 340);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(102, 34);
            this.btnProceed.TabIndex = 7;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // cmbAssessment
            // 
            this.cmbAssessment.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssessment.FormattingEnabled = true;
            this.cmbAssessment.Items.AddRange(new object[] {
            "Assignment/Task1",
            "Test/Task2",
            "Exam/Final Poe",
            "Ice"});
            this.cmbAssessment.Location = new System.Drawing.Point(159, 218);
            this.cmbAssessment.Name = "cmbAssessment";
            this.cmbAssessment.Size = new System.Drawing.Size(141, 27);
            this.cmbAssessment.TabIndex = 6;
            this.cmbAssessment.Text = "Select Assessment";
            // 
            // cmbModule
            // 
            this.cmbModule.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Items.AddRange(new object[] {
            "Software development"});
            this.cmbModule.Location = new System.Drawing.Point(152, 118);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(148, 27);
            this.cmbModule.TabIndex = 5;
            this.cmbModule.Text = "Select module";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "What would you like to edit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Module";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Assessments";
            // 
            // lblErr2
            // 
            this.lblErr2.AutoSize = true;
            this.lblErr2.ForeColor = System.Drawing.Color.Maroon;
            this.lblErr2.Location = new System.Drawing.Point(172, 248);
            this.lblErr2.Name = "lblErr2";
            this.lblErr2.Size = new System.Drawing.Size(112, 13);
            this.lblErr2.TabIndex = 10;
            this.lblErr2.Text = "*select an assessment";
            // 
            // lblErr1
            // 
            this.lblErr1.AutoSize = true;
            this.lblErr1.ForeColor = System.Drawing.Color.Maroon;
            this.lblErr1.Location = new System.Drawing.Point(187, 148);
            this.lblErr1.Name = "lblErr1";
            this.lblErr1.Size = new System.Drawing.Size(77, 13);
            this.lblErr1.TabIndex = 11;
            this.lblErr1.Text = "*select Module";
            // 
            // EditAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.panel1);
            this.Name = "EditAssessments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAssessments";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.ComboBox cmbAssessment;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErr1;
        private System.Windows.Forms.Label lblErr2;
    }
}