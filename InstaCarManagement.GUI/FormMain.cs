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
    public partial class FormMain : Form
    {
        private NpgsqlConnection connection = null;
        private Account actualUser = null;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(NpgsqlConnection connection, Account actualUser)
        {
            InitializeComponent();
            this.connection = connection;
            this.actualUser = actualUser;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.StatusLabelUser.Text = actualUser.Username;
            this.StatusLabelDbName.Text = this.connection.Database;

            if (this.actualUser.Admin)
            {
                this.MenuItemAdministration.Enabled = true;
                this.MenuItemAdministration.Visible = true;

            }
        }

        private void MenuItemUserManagment_Click(object sender, EventArgs e)
        {
            UserManagment userManagment = new UserManagment(this.connection, this.actualUser);

            if (userManagment.ShowDialog() == DialogResult.OK)
            {

            }
        }

        

        private void MenuItemEditCustomer_Click(object sender, EventArgs e)
        {
            FormEditing formEditing = new FormEditing(this.connection, 1);
            formEditing.Show();
        }

        private void MenuItemEditCar_Click(object sender, EventArgs e)
        {
            FormEditing formEditing = new FormEditing(this.connection, 2);
            formEditing.Show();
        }

        private void MenuItemEditLocation_Click(object sender, EventArgs e)
        {
            FormEditing formEditing = new FormEditing(this.connection, 3);
            formEditing.Show();
        }

        private void passwortÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPasswordChange formPasswordChange = new FormPasswordChange(this.actualUser);
            formPasswordChange.ShowDialog();
        }
    }
}
