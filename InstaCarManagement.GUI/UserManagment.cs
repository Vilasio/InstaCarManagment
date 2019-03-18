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
    public partial class UserManagment : Form
    {
        private NpgsqlConnection connection = null;
        private Account actualUser = null;
        private List<Account> allUsers = null;
        private Account editUser = null;

        enum EnumRole
        {
            Gast = 1,
            Clerk = 2,
            Administrator = 3
        }

        enum EnumTried
        {
            Kein = 0,
            Erster = 1,
            Zweiter = 2,
            Dritter = 3
        }

        public UserManagment()
        {
            InitializeComponent();
        }

        public UserManagment(NpgsqlConnection connection, Account actualUser)
        {
            this.connection = connection;
            this.actualUser = actualUser;
            InitializeComponent();
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            if (actualUser.Admin)
            {
                this.allUsers = this.actualUser.AllUsers;
                FillListViewUser();
                ClearUser();
            }
            else
            {
                this.Close();
            }
        }

        private void FillListViewUser()
        {
            this.listViewUser.Items.Clear();
            ListViewItem item = null;
            foreach (Account user in this.allUsers)
            {
                item = new ListViewItem();
                item.Text = user.Username;
                item.SubItems.Add(user.Blocked.ToString());
                item.Tag = user;
                this.listViewUser.Items.Add(item);
            }
        }

        private void ClearUser()
        {
            this.editUser = null;
            this.textBoxUsername.Text = string.Empty;
            this.textBoxPassword.Text = string.Empty;
            this.comboBoxRole.DataSource = Enum.GetValues(typeof(EnumRole));
            this.comboBoxTried.DataSource = Enum.GetValues(typeof(EnumTried));
            this.checkBoxBlocked.Checked = false;
            this.groupBoxUserEditing.Text = "Neuen User anlegen";
        }

        private bool ValidatingUser()
        {

            bool result = false;
            if (this.textBoxUsername.Text.Length >= 4)
            {
                this.editUser.Username = this.textBoxUsername.Text;
                result = true;
            }
            else
            {
                MessageBox.Show("Benutzername muss mindestens 4 Zeichen lang sein", "Benutzername fehlerhaft!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                result = false;
            }
            if (this.editUser.AccountId.HasValue)
            {
                if (this.textBoxPassword.Text == "" )
                {
                    this.editUser.Password = null;
                }
                else
                {
                    if (this.textBoxPassword.Text.Length > 4)
                    {
                        this.editUser.Password = this.textBoxPassword.Text;
                        result = true;
                    }
                    else
                    {
                        MessageBox.Show("Passwort muss mindestens 4 Zeichen lang sein", "Passwort fehlerhaft!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        result = false;
                    }
                }
                
            }
            else
            {
                if (this.textBoxPassword.Text.Length > 4)
                {
                    this.editUser.Password = this.textBoxPassword.Text;
                    result = true;
                }
                else
                {
                    MessageBox.Show("Passwort muss mindestens 4 Zeichen lang sein", "Passwort fehlerhaft!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    result = false;
                }
            }
           

            this.editUser.Role = Convert.ToInt64(this.comboBoxRole.SelectedValue);
            this.editUser.Tried = Convert.ToInt64( this.comboBoxTried.SelectedValue);
            this.editUser.Blocked = this.checkBoxBlocked.Checked;
            return result;
        }

        private void FillUser()
        {
            this.textBoxUsername.Text = this.editUser.Username;
            //this.textBoxPassword.Text = this.editUser.Password;
            this.comboBoxRole.SelectedIndex = (Convert.ToInt32( this.editUser.Role) - 1);
            this.comboBoxTried.SelectedIndex = (int)this.editUser.Tried;
            if (this.editUser.Username == "admin")
            {
                this.textBoxUsername.Enabled = false;
                this.comboBoxTried.Enabled = false;
                this.comboBoxRole.Enabled = false;
                this.checkBoxBlocked.Enabled = false;
            }
            else
            {
                this.textBoxUsername.Enabled = true;
                this.comboBoxTried.Enabled = true;
                this.comboBoxRole.Enabled = true;
                this.checkBoxBlocked.Enabled = true;
            }
            if (this.editUser.Blocked)
            {
                this.checkBoxBlocked.Checked = true;
            }
            else
            {
                this.checkBoxBlocked.Checked = false;
            }
            this.groupBoxUserEditing.Text = $" User {this.editUser.Username} bearbeiten";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(this.editUser == null)
            {
                this.editUser = new Account(this.connection);
            }
            if (ValidatingUser())
            {
                int result;
                bool newUser = this.editUser.AccountId.HasValue;
                result = this.editUser.Save();
                if (result > 0)
                {
                    this.labelResult.Visible = true;
                    this.labelResult.Text = "Erfolg!!";
                    if(!newUser) this.allUsers.Add(editUser);
                    ClearUser();
                }
                else
                {
                    this.labelResult.Visible = true;
                    this.labelResult.Text = "Fehlgeschlagen!!";
                }
                FillListViewUser();

            }
        }

        private void listViewUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearUser();
            ListViewItem item = this.listViewUser.GetItemAt(e.X, e.Y);
            this.editUser = (Account)item.Tag;
            FillUser();
        }

        private void checkBoxBlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlocked.Checked)
            {
                this.comboBoxTried.SelectedIndex = 3;
            }
            else
            {
                this.comboBoxTried.SelectedIndex = 0;
            }
        }

        private void checkBoxPasswordVisibility_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswordVisibility.Checked)
            {
                this.textBoxPassword.PasswordChar = '*';
            }
            else
            {
                this.textBoxPassword.PasswordChar = '\0';
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearUser();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
