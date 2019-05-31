namespace InstaCarManagement.GUI
{
    partial class FormPasswordChange
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelNewPasswordRep = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPasswordRep = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBoxUncheck = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheck = new System.Windows.Forms.PictureBox();
            this.splitContainerPasswordChange = new System.Windows.Forms.SplitContainer();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUncheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPasswordChange)).BeginInit();
            this.splitContainerPasswordChange.Panel1.SuspendLayout();
            this.splitContainerPasswordChange.Panel2.SuspendLayout();
            this.splitContainerPasswordChange.SuspendLayout();
            this.groupBoxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(8, 15);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 13);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Altes Passwort:";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(8, 41);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(87, 13);
            this.labelNewPassword.TabIndex = 1;
            this.labelNewPassword.Text = "Neues Passwort:";
            // 
            // labelNewPasswordRep
            // 
            this.labelNewPasswordRep.AutoSize = true;
            this.labelNewPasswordRep.Location = new System.Drawing.Point(8, 67);
            this.labelNewPasswordRep.Name = "labelNewPasswordRep";
            this.labelNewPasswordRep.Size = new System.Drawing.Size(147, 13);
            this.labelNewPasswordRep.TabIndex = 2;
            this.labelNewPasswordRep.Text = "Neues Passwort wiederholen:";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(161, 8);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxOldPassword.TabIndex = 0;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(161, 34);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxNewPassword.TabIndex = 1;
            this.textBoxNewPassword.Leave += new System.EventHandler(this.textBoxNewPassword_Leave);
            // 
            // textBoxNewPasswordRep
            // 
            this.textBoxNewPasswordRep.Location = new System.Drawing.Point(161, 60);
            this.textBoxNewPasswordRep.Name = "textBoxNewPasswordRep";
            this.textBoxNewPasswordRep.PasswordChar = '*';
            this.textBoxNewPasswordRep.Size = new System.Drawing.Size(200, 20);
            this.textBoxNewPasswordRep.TabIndex = 2;
            this.textBoxNewPasswordRep.Leave += new System.EventHandler(this.textBoxNewPasswordRep_Leave);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(205, 106);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Ändern";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            this.buttonChange.Enter += new System.EventHandler(this.buttonChange_Enter);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(286, 106);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(12, 90);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(45, 16);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status";
            this.labelStatus.Visible = false;
            // 
            // pictureBoxUncheck
            // 
            this.pictureBoxUncheck.Image = global::InstaCarManagement.GUI.Properties.Resources.Cancel_16x;
            this.pictureBoxUncheck.Location = new System.Drawing.Point(367, 41);
            this.pictureBoxUncheck.Name = "pictureBoxUncheck";
            this.pictureBoxUncheck.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxUncheck.TabIndex = 10;
            this.pictureBoxUncheck.TabStop = false;
            this.pictureBoxUncheck.Visible = false;
            // 
            // pictureBoxCheck
            // 
            this.pictureBoxCheck.Image = global::InstaCarManagement.GUI.Properties.Resources.Checkmark_green_12x_16x;
            this.pictureBoxCheck.Location = new System.Drawing.Point(367, 41);
            this.pictureBoxCheck.Name = "pictureBoxCheck";
            this.pictureBoxCheck.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCheck.TabIndex = 9;
            this.pictureBoxCheck.TabStop = false;
            this.pictureBoxCheck.Visible = false;
            // 
            // splitContainerPasswordChange
            // 
            this.splitContainerPasswordChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPasswordChange.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerPasswordChange.IsSplitterFixed = true;
            this.splitContainerPasswordChange.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPasswordChange.Name = "splitContainerPasswordChange";
            this.splitContainerPasswordChange.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerPasswordChange.Panel1
            // 
            this.splitContainerPasswordChange.Panel1.Controls.Add(this.groupBoxHeader);
            // 
            // splitContainerPasswordChange.Panel2
            // 
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.labelPassword);
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.labelNewPassword);
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.labelNewPasswordRep);
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.textBoxOldPassword);
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.textBoxNewPassword);
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.textBoxNewPasswordRep);
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.buttonChange);
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.labelStatus);
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.pictureBoxCheck);
            this.splitContainerPasswordChange.Panel2.Controls.Add(this.pictureBoxUncheck);
            this.splitContainerPasswordChange.Size = new System.Drawing.Size(430, 266);
            this.splitContainerPasswordChange.SplitterDistance = 105;
            this.splitContainerPasswordChange.TabIndex = 11;
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.BackColor = System.Drawing.Color.Blue;
            this.groupBoxHeader.Controls.Add(this.labelHeader);
            this.groupBoxHeader.Controls.Add(this.pictureBoxLogo);
            this.groupBoxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHeader.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(430, 500);
            this.groupBoxHeader.TabIndex = 2;
            this.groupBoxHeader.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Calibri", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(151, 16);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(210, 66);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "InstaCar";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::InstaCarManagement.GUI.Properties.Resources.Logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(141, 85);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(430, 266);
            this.Controls.Add(this.splitContainerPasswordChange);
            this.Name = "FormPasswordChange";
            this.Text = "Passwort ändern";
            this.Load += new System.EventHandler(this.FormPasswordChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUncheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck)).EndInit();
            this.splitContainerPasswordChange.Panel1.ResumeLayout(false);
            this.splitContainerPasswordChange.Panel2.ResumeLayout(false);
            this.splitContainerPasswordChange.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPasswordChange)).EndInit();
            this.splitContainerPasswordChange.ResumeLayout(false);
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelNewPasswordRep;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPasswordRep;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBoxCheck;
        private System.Windows.Forms.PictureBox pictureBoxUncheck;
        private System.Windows.Forms.SplitContainer splitContainerPasswordChange;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}