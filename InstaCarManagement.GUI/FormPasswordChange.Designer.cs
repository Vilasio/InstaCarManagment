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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUncheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 9);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 13);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Altes Passwort:";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(12, 48);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(87, 13);
            this.labelNewPassword.TabIndex = 1;
            this.labelNewPassword.Text = "Neues Passwort:";
            // 
            // labelNewPasswordRep
            // 
            this.labelNewPasswordRep.AutoSize = true;
            this.labelNewPasswordRep.Location = new System.Drawing.Point(12, 86);
            this.labelNewPasswordRep.Name = "labelNewPasswordRep";
            this.labelNewPasswordRep.Size = new System.Drawing.Size(147, 13);
            this.labelNewPasswordRep.TabIndex = 2;
            this.labelNewPasswordRep.Text = "Neues Passwort wiederholen:";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(165, 2);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxOldPassword.TabIndex = 3;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(165, 41);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxNewPassword.TabIndex = 4;
            this.textBoxNewPassword.Leave += new System.EventHandler(this.textBoxNewPassword_Leave);
            // 
            // textBoxNewPasswordRep
            // 
            this.textBoxNewPasswordRep.Location = new System.Drawing.Point(165, 79);
            this.textBoxNewPasswordRep.Name = "textBoxNewPasswordRep";
            this.textBoxNewPasswordRep.PasswordChar = '*';
            this.textBoxNewPasswordRep.Size = new System.Drawing.Size(200, 20);
            this.textBoxNewPasswordRep.TabIndex = 5;
            this.textBoxNewPasswordRep.Leave += new System.EventHandler(this.textBoxNewPasswordRep_Leave);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(209, 153);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "Ändern";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(290, 153);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 116);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status";
            this.labelStatus.Visible = false;
            // 
            // pictureBoxUncheck
            // 
            this.pictureBoxUncheck.Image = global::InstaCarManagement.GUI.Properties.Resources.Cancel_16x;
            this.pictureBoxUncheck.Location = new System.Drawing.Point(377, 62);
            this.pictureBoxUncheck.Name = "pictureBoxUncheck";
            this.pictureBoxUncheck.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxUncheck.TabIndex = 10;
            this.pictureBoxUncheck.TabStop = false;
            this.pictureBoxUncheck.Visible = false;
            // 
            // pictureBoxCheck
            // 
            this.pictureBoxCheck.Image = global::InstaCarManagement.GUI.Properties.Resources.Checkmark_green_12x_16x;
            this.pictureBoxCheck.Location = new System.Drawing.Point(377, 62);
            this.pictureBoxCheck.Name = "pictureBoxCheck";
            this.pictureBoxCheck.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCheck.TabIndex = 9;
            this.pictureBoxCheck.TabStop = false;
            this.pictureBoxCheck.Visible = false;
            // 
            // FormPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxUncheck);
            this.Controls.Add(this.pictureBoxCheck);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxNewPasswordRep);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.labelNewPasswordRep);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelPassword);
            this.Name = "FormPasswordChange";
            this.Text = "FormPasswordChange";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUncheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}