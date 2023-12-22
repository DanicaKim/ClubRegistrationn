namespace ClubRegistration
{
    partial class FrmUpdateMember
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
            this.cBoxProgram = new System.Windows.Forms.ComboBox();
            this.cbBoxGender = new System.Windows.Forms.ComboBox();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.tXtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBoxProgram
            // 
            this.cBoxProgram.FormattingEnabled = true;
            this.cBoxProgram.Location = new System.Drawing.Point(16, 344);
            this.cBoxProgram.Name = "cBoxProgram";
            this.cBoxProgram.Size = new System.Drawing.Size(206, 21);
            this.cBoxProgram.TabIndex = 30;
            // 
            // cbBoxGender
            // 
            this.cbBoxGender.FormattingEnabled = true;
            this.cbBoxGender.Location = new System.Drawing.Point(16, 293);
            this.cbBoxGender.Name = "cbBoxGender";
            this.cbBoxGender.Size = new System.Drawing.Size(171, 21);
            this.cbBoxGender.TabIndex = 29;
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(16, 187);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(209, 20);
            this.txtBoxMiddleName.TabIndex = 28;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(15, 132);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(209, 20);
            this.txtBoxFirstName.TabIndex = 27;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(16, 239);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(97, 20);
            this.txtBoxAge.TabIndex = 26;
            // 
            // tXtBoxLastName
            // 
            this.tXtBoxLastName.Location = new System.Drawing.Point(12, 82);
            this.tXtBoxLastName.Name = "tXtBoxLastName";
            this.tXtBoxLastName.Size = new System.Drawing.Size(209, 20);
            this.tXtBoxLastName.TabIndex = 25;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(13, 278);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 23;
            this.lblGender.Text = "Gender:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 116);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(12, 171);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(72, 13);
            this.lblMiddleName.TabIndex = 21;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(13, 328);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(49, 13);
            this.lblProgram.TabIndex = 20;
            this.lblProgram.Text = "Program:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(19, 223);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 19;
            this.lblAge.Text = "Age:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(9, 19);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 17;
            this.lblStudentID.Text = "Student ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(69, 383);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(101, 36);
            this.btnConfirm.TabIndex = 32;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(250, 442);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cBoxProgram);
            this.Controls.Add(this.cbBoxGender);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.tXtBoxLastName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxProgram;
        private System.Windows.Forms.ComboBox cbBoxGender;
        private System.Windows.Forms.TextBox txtBoxMiddleName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox tXtBoxLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConfirm;
    }
}