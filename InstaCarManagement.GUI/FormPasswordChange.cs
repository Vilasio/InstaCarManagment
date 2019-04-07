using InstaCarManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaCarManagement.GUI
{
    public partial class FormPasswordChange : Form
    {
        private Account actualUser;


        public FormPasswordChange()
        {
            InitializeComponent();
        }

        public FormPasswordChange(Account actualUser)
        {
            InitializeComponent();
            this.actualUser = actualUser;
        }

        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.FromArgb(00, 00, 255));
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void textBoxNewPasswordRep_Leave(object sender, EventArgs e)
        {
            if (this.textBoxNewPassword.Text == this.textBoxNewPasswordRep.Text)
            {
                this.pictureBoxCheck.Visible = true;
                this.pictureBoxUncheck.Visible = false;
                this.labelStatus.Visible = false;
            }
            else
            {
                this.pictureBoxCheck.Visible = false;
                this.pictureBoxUncheck.Visible = true;
                this.labelStatus.Visible = true;
                this.labelStatus.Text = "Die Passwörter stimmen nicht überein.";
            }
        }

        private void textBoxNewPassword_Leave(object sender, EventArgs e)
        {
            if (this.textBoxNewPassword.Text == this.textBoxNewPasswordRep.Text)
            {
                this.pictureBoxCheck.Visible = true;
                this.pictureBoxUncheck.Visible = false;
                this.labelStatus.Visible = false;

            }
            else
            {
                this.pictureBoxCheck.Visible = false;
                this.pictureBoxUncheck.Visible = true;
                this.labelStatus.Visible = true;
                this.labelStatus.Text = "Die Passwörter stimmen nicht überein.";
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int result;
            this.labelStatus.Visible = false;
            if (this.textBoxNewPassword.Text != "")
            {
                if (this.textBoxNewPassword.Text == this.textBoxNewPasswordRep.Text)
                {
                    if (this.textBoxNewPassword.Text.Length >= 4)
                    {
                       result =  this.actualUser.ChangePassword(this.textBoxOldPassword.Text, this.textBoxNewPassword.Text);
                        if (result != 0)
                        {
                            this.labelStatus.Visible = true;
                            this.labelStatus.Text = "Erfolg!\nPasswort wurde geändert";
                        }
                        else
                        {
                            this.labelStatus.Visible = true;
                            this.labelStatus.Text = "Das alte Passwort war fehlerhaft.";
                        }
                    }
                    else
                    {
                        this.labelStatus.Visible = true;
                        this.labelStatus.Text = "Das neue Passwort muss mindestens";
                    }
                }
                else
                {
                    this.labelStatus.Visible = true;
                    this.labelStatus.Text = "Das neue Passwort ist fehlerhaft";
                }
            }
            else
            {
                this.labelStatus.Visible = true;
                this.labelStatus.Text = "Passwort wurde nicht eingeben.";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPasswordChange_Load(object sender, EventArgs e)
        {
            this.groupBoxHeader.Paint += PaintBorderlessGroupBox;
        }
    }
}
