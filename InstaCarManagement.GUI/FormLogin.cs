﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using InstaCarManagement.Data;
using System.Media;

namespace InstaCarManagement.GUI
{
    public partial class FormLogin : Form
    {
        private NpgsqlConnection connection = null;

        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(NpgsqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();

        }

        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.FromArgb(00, 00, 255));
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }


        public Account actualUser { get; set; }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(this.textBoxUsername.Text != "" && this.textBoxPassword.Text != "")
            {
                this.labelMsg.Visible = false;
                this.actualUser = Account.LoginCheck(this.connection, this.textBoxUsername.Text, this.textBoxPassword.Text);
                if (actualUser != null)
                {
                    if (actualUser.Verfication)
                    {
                        //MessageBox.Show("hat geklappt");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        if (actualUser.Blocked)
                        {
                            this.labelMsg.Text = $"Benutzer {actualUser.Username} wurde gesperrt.\nWenden Sie sich bitte an den Administrator" ;
                            SystemSounds.Asterisk.Play();
                            this.labelMsg.Visible = true;
                        }
                        else
                        {
                            if (this.actualUser.Username != "admin")
                            {
                                this.labelMsg.Text = $"Passwort wurde falsch eingegeben!\n" +
                                $"Noch {(3 - actualUser.Tried)} Versuche";
                                SystemSounds.Asterisk.Play();
                                this.labelMsg.Visible = true;
                            }
                            else
                            {
                                this.labelMsg.Text = $"Passwort wurde falsch eingegeben!";
                                SystemSounds.Asterisk.Play();
                                this.labelMsg.Visible = true;
                            }
                            
                        }
                    }
                }
                else
                {
                    this.labelMsg.Text = "Benutzername ist falsch!";
                    SystemSounds.Asterisk.Play();
                    this.labelMsg.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Musst schon was eingeben");
            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.groupBoxHeader.Paint += PaintBorderlessGroupBox;

        }
    }
}
