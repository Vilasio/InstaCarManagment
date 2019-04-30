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
using System.IO;

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
                if (rent.Begin.HasValue) item.SubItems.Add($"{rent.Begin.Value.ToShortDateString()} - {rent.Begin.Value.ToShortTimeString()}");
                else item.SubItems.Add("");
                if (rent.End.HasValue)item.SubItems.Add($"{rent.End.Value.ToShortDateString()} - {rent.End.Value.ToShortTimeString()}");
                else item.SubItems.Add("");
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
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = this.printDocument;
            ((ToolStrip)(dialog.Controls[1])).Items.RemoveAt(0);

            ToolStripButton b = new ToolStripButton();
            //b.Image = Properties.Resources.PrintDialog;
            b.DisplayStyle = ToolStripItemDisplayStyle.Image;
            b.Click += dialogPrint_Click;
            ((ToolStrip)(dialog.Controls[1])).Items.Insert(0, b);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Erfolg");
            }

            /*this.timerRents.Enabled = false;
            DataTable currentRents = Rent.GetTable(this.connection);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF-File|*.pdf";
            saveFileDialog.Title = "Pdf exportieren";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportPdf.ExportToPdfQuerMitPic(rents, saveFileDialog.FileName, this.connection);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Leider ist etwas beim Speichern der Datei schief gelaufen.", "Fehlgeschlagen!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            this.timerRents.Enabled = true;
            */
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

        private void toolStripMenuItemTest_Click(object sender, EventArgs e)
        {
            
        }

        private void dialogPrint_Click(object sender, EventArgs e)
        {
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lastIndex = 0;
                this.printDocument.PrinterSettings = dialog.PrinterSettings;
                this.printDocument.Print();
            }

        }

        private int lastIndex = 0;

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.timerRents.Enabled = false;
            Image image = null;
            float top = 10;
            float ratio = 0;
            float nHeight = 0;
            float topOffset = 0;
            Rent rent = null;

            Font fontStd = new Font("Verdana", 10f, FontStyle.Regular);
            Font fontHead = new Font("Arial Black", 20f, FontStyle.Regular);
            Font fontLabel = new Font("Verdana", 10f, FontStyle.Bold | FontStyle.Underline);

            e.Graphics.DrawString($"Vermietungs Liste vom {DateTime.Now.ToShortDateString()}", fontHead, Brushes.Black, new PointF(20f, top));
            SizeF textSize = e.Graphics.MeasureString($"Personen Liste vom {DateTime.Now.ToShortDateString()}", fontHead);
            top += textSize.Height + 10f;
            e.Graphics.DrawLine(new Pen(Brushes.Blue, 3f), new PointF(20f, top), new PointF(e.PageSettings.PaperSize.Width - 20, top));
            top += 13f;

            for (int idx = lastIndex; idx < this.rents.Count; idx++)
            {
                rent = this.rents[idx];
                image = ImageCar.GetMainImage(this.connection, rent.CarId);
                if (image != null)
                {
                    ratio = (float)image.Width / 150f;
                    nHeight = (float)image.Height / ratio;
                    e.Graphics.DrawImage(image, new RectangleF(30f, top, 150, nHeight), new RectangleF(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
                }
                else
                {
                    nHeight = 150f;
                }

                topOffset = 30f;
                e.Graphics.DrawString("Name: ", fontLabel, Brushes.Black, new PointF(220f, top + topOffset));
                e.Graphics.DrawString($"{rent.Name} {rent.FamilyName}", fontStd, Brushes.Black, new PointF(350f, top + topOffset));
                textSize = e.Graphics.MeasureString($"{rent.Name} {rent.FamilyName}", fontStd);

                topOffset += textSize.Height + 10f;
                e.Graphics.DrawString("Fahrzeug: ", fontLabel, Brushes.Black, new PointF(220f, top + topOffset));
                e.Graphics.DrawString($"{(rent.Brand != String.Empty ? rent.Brand : string.Empty)} {(rent.Modell != String.Empty ? rent.Modell : string.Empty)}", fontStd, Brushes.Black, new PointF(350f, top + topOffset));

                topOffset += textSize.Height + 10f;
                e.Graphics.DrawString("Vermietet: ", fontLabel, Brushes.Black, new PointF(220f, top + topOffset));
                e.Graphics.DrawString($"{(rent.Begin.HasValue ? rent.Begin.Value.ToShortDateString() : string.Empty)} {(rent.Begin.HasValue ? rent.Begin.Value.ToShortTimeString() : string.Empty)} " +
                    $"- {(rent.End.HasValue ? rent.End.Value.ToShortDateString() : "noch offen")} {(rent.End.HasValue ? rent.End.Value.ToShortTimeString() : "")}", fontStd, Brushes.Black, new PointF(350f, top + topOffset));

                top += nHeight + 20f;


                if (top > (float)e.PageSettings.PaperSize.Height / 3f * 2f)
                {
                    lastIndex = idx + 1;
                    e.HasMorePages = true;
                    break;
                }
            }

            this.timerRents.Enabled = true;
        }
    }
}
