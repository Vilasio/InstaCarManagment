namespace InstaCarManagement.GUI
{
    partial class FormLogin
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.splitContainerLogin = new System.Windows.Forms.SplitContainer();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.labelTopic = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLogin)).BeginInit();
            this.splitContainerLogin.Panel1.SuspendLayout();
            this.splitContainerLogin.Panel2.SuspendLayout();
            this.splitContainerLogin.SuspendLayout();
            this.groupBoxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(4, 15);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(38, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Name:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(4, 41);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Passwort:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(142, 8);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 20);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.Text = "admin";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(142, 34);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "admin";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(186, 98);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(267, 98);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.ForeColor = System.Drawing.Color.Red;
            this.labelMsg.Location = new System.Drawing.Point(4, 68);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(139, 13);
            this.labelMsg.TabIndex = 9;
            this.labelMsg.Text = "Name oder Passwort falsch!";
            this.labelMsg.Visible = false;
            // 
            // splitContainerLogin
            // 
            this.splitContainerLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLogin.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLogin.IsSplitterFixed = true;
            this.splitContainerLogin.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLogin.Name = "splitContainerLogin";
            this.splitContainerLogin.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLogin.Panel1
            // 
            this.splitContainerLogin.Panel1.Controls.Add(this.groupBoxHeader);
            // 
            // splitContainerLogin.Panel2
            // 
            this.splitContainerLogin.Panel2.Controls.Add(this.labelUserName);
            this.splitContainerLogin.Panel2.Controls.Add(this.labelPassword);
            this.splitContainerLogin.Panel2.Controls.Add(this.textBoxUsername);
            this.splitContainerLogin.Panel2.Controls.Add(this.textBoxPassword);
            this.splitContainerLogin.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainerLogin.Panel2.Controls.Add(this.buttonOk);
            this.splitContainerLogin.Panel2.Controls.Add(this.labelMsg);
            this.splitContainerLogin.Size = new System.Drawing.Size(373, 244);
            this.splitContainerLogin.SplitterDistance = 105;
            this.splitContainerLogin.TabIndex = 10;
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.BackColor = System.Drawing.Color.Blue;
            this.groupBoxHeader.Controls.Add(this.labelTopic);
            this.groupBoxHeader.Controls.Add(this.labelHeader);
            this.groupBoxHeader.Controls.Add(this.pictureBoxLogo);
            this.groupBoxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHeader.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(373, 500);
            this.groupBoxHeader.TabIndex = 2;
            this.groupBoxHeader.TabStop = false;
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Font = new System.Drawing.Font("Calibri", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.labelTopic.ForeColor = System.Drawing.Color.White;
            this.labelTopic.Location = new System.Drawing.Point(154, 64);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(74, 33);
            this.labelTopic.TabIndex = 2;
            this.labelTopic.Text = "Login";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Calibri", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(151, 16);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(158, 49);
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
            // FormLogin
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(373, 244);
            this.Controls.Add(this.splitContainerLogin);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.splitContainerLogin.Panel1.ResumeLayout(false);
            this.splitContainerLogin.Panel2.ResumeLayout(false);
            this.splitContainerLogin.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLogin)).EndInit();
            this.splitContainerLogin.ResumeLayout(false);
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.SplitContainer splitContainerLogin;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

