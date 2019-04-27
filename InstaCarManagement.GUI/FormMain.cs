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
        private List<Rent> rents = null;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(NpgsqlConnection connection, Account actualUser)
        {
            InitializeComponent();
            this.connection = connection;
            this.actualUser = actualUser;
            FilllistviewRent();
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

            this.groupBoxHeader.Paint += PaintBorderlessGroupBox;
        }

        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.FromArgb(00, 00, 255));
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }


        private void FilllistviewRent()
        {
            this.listViewRent.Items.Clear();
            this.rents = Rent.GetCurrentRents(this.connection);
            ListViewItem item = null;
            foreach (Rent rent in rents)
            {
                item = new ListViewItem();
                item.Text = rent.Name;
                item.SubItems.Add(rent.FamilyName);
                item.SubItems.Add(rent.Modell);
                item.SubItems.Add(rent.Brand);
                item.SubItems.Add(rent.Begin.Value.ToShortDateString());
                if(rent.End.HasValue)item.SubItems.Add(rent.End.Value.ToShortDateString());
                item.Tag = rent;
                this.listViewRent.Items.Add(item);
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
            FormEditing formEditing = new FormEditing(this.connection, 1, this.actualUser);
            formEditing.Show();
        }

        private void MenuItemEditCar_Click(object sender, EventArgs e)
        {
            FormEditing formEditing = new FormEditing(this.connection, 2, this.actualUser);
            formEditing.Show();
        }

        private void MenuItemEditLocation_Click(object sender, EventArgs e)
        {
            FormEditing formEditing = new FormEditing(this.connection, 3, this.actualUser);
            formEditing.Show();
        }

        private void passwortÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPasswordChange formPasswordChange = new FormPasswordChange(this.actualUser);
            formPasswordChange.ShowDialog();
        }

        private void MenuItemPricing_Click(object sender, EventArgs e)
        {
            FormAdminOptions formAdminOptions = new FormAdminOptions(this.connection);
            formAdminOptions.ShowDialog();
        }

        private void MenuItemPrint_Click(object sender, EventArgs e)
        {
            DataTable currentRents = Rent.GetTable(this.connection);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF-File|*.pdf";
            saveFileDialog.Title = "Pdf exportieren";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportPdf.ExportToPdfQuer(currentRents, saveFileDialog.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Leider ist etwas beim Speichern der Datei schief gelaufen.", "Fehlgeschlagen!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void timerRents_Tick(object sender, EventArgs e)
        {
            FilllistviewRent();
        }

        private void MenuItemRentCar_Click(object sender, EventArgs e)
        {
            FormRent formRent = new FormRent(this.connection);

            if (formRent.ShowDialog() == DialogResult.OK)
            {
                FilllistviewRent();
            }
        }

        private void listViewRent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewRent.GetItemAt(e.X, e.Y);
            Rent rent = (Rent)item.Tag;
            FormRent formRent = new FormRent(this.connection, rent);

            if (formRent.ShowDialog() == DialogResult.OK)
            {
                FilllistviewRent();
            }
        }
    }
}
