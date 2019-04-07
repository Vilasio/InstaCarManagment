using InstaCarManagement.Data;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaCarManagement.GUI
{
    public partial class FormImages : Form
    {
        private NpgsqlConnection connection = null;
        private Vehicle vehicle = null;
        private ImageUS selected = null;
        
        public FormImages()
        {
            InitializeComponent();
        }

        public FormImages(NpgsqlConnection connection, Vehicle vehicle)
        {
            InitializeComponent();
            this.connection = connection;
            this.vehicle = vehicle;
        }

        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.FromArgb(00, 00, 255));
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ImageUS add = new ImageUS(this.connection, this.vehicle);
            add.ImageCar = new ImageCar(this.connection, this.vehicle);
            add.Click += new EventHandler(UserControl_Click); 
            

            this.flowLayoutPanelImages.Controls.Add(add);
        }

       
        

        protected void UserControl_Click(object sender, EventArgs e)
        {
            if (this.selected != null)
            {
                this.selected.BackColor = SystemColors.Control;
            }
            this.selected = (ImageUS)sender;
            this.selected.BackColor = SystemColors.Highlight;
        }

        private bool ValidateUC()
        {
            if (this.flowLayoutPanelImages.Controls.Count != 0)
            {
                List<ImageUS> list = new List<ImageUS>();
                foreach (ImageUS uS in this.flowLayoutPanelImages.Controls)
                {
                    uS.BackColor = SystemColors.Control;
                    if (uS.Main)
                    {
                        list.Add(uS);
                    }
                }
                if (list.Count > 1)
                {
                    foreach (ImageUS uS in list)
                    {
                        uS.BackColor = Color.Red;
                    }
                    this.labelStatus.Visible = true;
                    this.labelStatus.Text = "Es kann nur ein Hauptbild definert werden.";
                    return false;
                }
                if (list.Count == 0)
                {

                    this.labelStatus.Visible = true;
                    this.labelStatus.Text = "Es wurde kein Hauptbild definiert.";
                    return false;
                }
            }
            
            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.selected != null)
            {
                if (this.selected.ImageCar != null)
                {
                    this.selected.ImageCar.Delete();
                    this.vehicle.Pictures.Remove(this.selected.ImageCar);

                }
                this.flowLayoutPanelImages.Controls.Remove(this.selected);
            }
        }

        private void FormImages_Load(object sender, EventArgs e)
        {
            this.groupBoxHeader.Paint += PaintBorderlessGroupBox;
            if (this.vehicle.Pictures.Count != 0)
            {
                ImageUS uS = null;
                foreach (ImageCar pic in this.vehicle.Pictures)
                {
                    uS = new ImageUS();
                    uS.ImageCar = pic;
                    uS.Kind = pic.Kind;
                    uS.Main = pic.Main;
                    uS.Picture = pic.Image;
                    uS.Description = pic.Description;
                    uS.Click += new EventHandler(UserControl_Click);
                    this.flowLayoutPanelImages.Controls.Add(uS);

                }
            }
            else
            {
                ImageUS add = new ImageUS(this.connection, this.vehicle);
                add.ImageCar = new ImageCar(this.connection, this.vehicle);
                add.Click += new EventHandler(UserControl_Click);


                this.flowLayoutPanelImages.Controls.Add(add);
            }
            if (this.vehicle.CarId.HasValue)
            {
                this.groupBoxImages.Text = $"Bilder für {this.vehicle.Brand} {this.vehicle.Modell}";
            }
            else
            {
                this.groupBoxImages.Text = $"Bilder für neues Auto";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateUC())
            {
                foreach (ImageUS uS in this.flowLayoutPanelImages.Controls)
                {
                    if (uS.Picture != null)
                    {

                        MemoryStream memoryStream = new MemoryStream();
                        uS.Picture.Save(memoryStream, ImageFormat.Png);
                        memoryStream.Seek(0, SeekOrigin.Begin);
                        memoryStream.Close();
                        uS.ImageCar.Picture = memoryStream.GetBuffer();



                        uS.ImageCar.Image = uS.Picture;
                        uS.ImageCar.Main = uS.Main;
                        uS.ImageCar.Kind = uS.Kind;
                        uS.ImageCar.Description = uS.Description;
                        if (!this.vehicle.Pictures.Contains(uS.ImageCar))
                        {
                            this.vehicle.Pictures.Add(uS.ImageCar);
                        }
                    }

                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
