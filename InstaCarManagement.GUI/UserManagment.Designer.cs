namespace InstaCarManagement.GUI
{
    partial class UserManagment
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.columnHeaderUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBlocked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxUserEditing = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxBlocked = new System.Windows.Forms.CheckBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTried = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.comboBoxTried = new System.Windows.Forms.ComboBox();
            this.checkBoxPasswordVisibility = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxUserEditing.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewUser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonClose);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxUserEditing);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // listViewUser
            // 
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUser,
            this.columnHeaderBlocked});
            this.listViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUser.FullRowSelect = true;
            this.listViewUser.GridLines = true;
            this.listViewUser.Location = new System.Drawing.Point(0, 0);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(266, 450);
            this.listViewUser.TabIndex = 0;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            this.listViewUser.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewUser_MouseDoubleClick);
            // 
            // columnHeaderUser
            // 
            this.columnHeaderUser.Text = "Benutzer";
            this.columnHeaderUser.Width = 200;
            // 
            // columnHeaderBlocked
            // 
            this.columnHeaderBlocked.Text = "Gesperrt";
            // 
            // groupBoxUserEditing
            // 
            this.groupBoxUserEditing.Controls.Add(this.checkBoxPasswordVisibility);
            this.groupBoxUserEditing.Controls.Add(this.labelResult);
            this.groupBoxUserEditing.Controls.Add(this.buttonCancel);
            this.groupBoxUserEditing.Controls.Add(this.buttonSave);
            this.groupBoxUserEditing.Controls.Add(this.checkBoxBlocked);
            this.groupBoxUserEditing.Controls.Add(this.textBoxUsername);
            this.groupBoxUserEditing.Controls.Add(this.labelRole);
            this.groupBoxUserEditing.Controls.Add(this.labelUsername);
            this.groupBoxUserEditing.Controls.Add(this.labelTried);
            this.groupBoxUserEditing.Controls.Add(this.comboBoxRole);
            this.groupBoxUserEditing.Controls.Add(this.textBoxPassword);
            this.groupBoxUserEditing.Controls.Add(this.labelPassword);
            this.groupBoxUserEditing.Controls.Add(this.comboBoxTried);
            this.groupBoxUserEditing.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserEditing.Location = new System.Drawing.Point(3, 12);
            this.groupBoxUserEditing.Name = "groupBoxUserEditing";
            this.groupBoxUserEditing.Size = new System.Drawing.Size(528, 284);
            this.groupBoxUserEditing.TabIndex = 0;
            this.groupBoxUserEditing.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.Red;
            this.labelResult.Location = new System.Drawing.Point(212, 39);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(54, 17);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Result";
            this.labelResult.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(87, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(6, 217);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxBlocked
            // 
            this.checkBoxBlocked.AutoSize = true;
            this.checkBoxBlocked.Location = new System.Drawing.Point(6, 162);
            this.checkBoxBlocked.Name = "checkBoxBlocked";
            this.checkBoxBlocked.Size = new System.Drawing.Size(77, 21);
            this.checkBoxBlocked.TabIndex = 4;
            this.checkBoxBlocked.Text = "Gesperrt";
            this.checkBoxBlocked.UseVisualStyleBackColor = true;
            this.checkBoxBlocked.CheckedChanged += new System.EventHandler(this.checkBoxBlocked_CheckedChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(6, 39);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 24);
            this.textBoxUsername.TabIndex = 0;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(130, 108);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(37, 17);
            this.labelRole.TabIndex = 7;
            this.labelRole.Text = "Role:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(3, 23);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(64, 17);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Benutzer:";
            // 
            // labelTried
            // 
            this.labelTried.AutoSize = true;
            this.labelTried.Location = new System.Drawing.Point(3, 108);
            this.labelTried.Name = "labelTried";
            this.labelTried.Size = new System.Drawing.Size(63, 17);
            this.labelTried.TabIndex = 8;
            this.labelTried.Text = "Versuche:";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(133, 124);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRole.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 80);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 24);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(3, 64);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 17);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Passwort:";
            // 
            // comboBoxTried
            // 
            this.comboBoxTried.FormattingEnabled = true;
            this.comboBoxTried.Location = new System.Drawing.Point(6, 124);
            this.comboBoxTried.Name = "comboBoxTried";
            this.comboBoxTried.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTried.TabIndex = 2;
            // 
            // checkBoxPasswordVisibility
            // 
            this.checkBoxPasswordVisibility.AutoSize = true;
            this.checkBoxPasswordVisibility.Checked = true;
            this.checkBoxPasswordVisibility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPasswordVisibility.Location = new System.Drawing.Point(215, 83);
            this.checkBoxPasswordVisibility.Name = "checkBoxPasswordVisibility";
            this.checkBoxPasswordVisibility.Size = new System.Drawing.Size(132, 21);
            this.checkBoxPasswordVisibility.TabIndex = 11;
            this.checkBoxPasswordVisibility.Text = "Passwort anzeigen";
            this.checkBoxPasswordVisibility.UseVisualStyleBackColor = true;
            this.checkBoxPasswordVisibility.CheckedChanged += new System.EventHandler(this.checkBoxPasswordVisibility_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(443, 415);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Schließen";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserManagment";
            this.Text = "UserManagment";
            this.Load += new System.EventHandler(this.UserManagment_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxUserEditing.ResumeLayout(false);
            this.groupBoxUserEditing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ColumnHeader columnHeaderUser;
        private System.Windows.Forms.ColumnHeader columnHeaderBlocked;
        private System.Windows.Forms.GroupBox groupBoxUserEditing;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxBlocked;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTried;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ComboBox comboBoxTried;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.CheckBox checkBoxPasswordVisibility;
        private System.Windows.Forms.Button buttonClose;
    }
}