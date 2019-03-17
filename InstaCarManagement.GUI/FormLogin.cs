using System;
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
                if(actualUser != null)
                {
                    //MessageBox.Show("hat geklappt");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.labelMsg.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Musst schon was eingeben");
            }
            
        }
    }
}
