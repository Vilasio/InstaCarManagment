using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstaCarManagement.Data;
using Npgsql;

namespace InstaCarManagement.GUI
{
    public partial class ImageUS : UserControl
    {
        

        private Vehicle vehicle = null;
        private NpgsqlConnection connection = null;
        public ImageUS()
        {
            InitializeComponent();
        }

        public ImageUS(NpgsqlConnection connection, Vehicle vehicle)
        {
            InitializeComponent();
            this.connection = connection;
            this.vehicle = vehicle;
        }

        public ImageCar ImageCar { get; set; }


        public Image Picture
        {
            get {
                return this.pictureBoxImage.Image;
                }
            set { this.pictureBoxImage.Image = value; }
        }

        public string Kind
        {
            get
            {
                if (this.checkBoxOfficial.Checked)
                {
                    return "Public";
                }
                else
                {
                    return "Intern";
                }
                
            }
            set
            {
                if (value == "Public")
                {
                    this.checkBoxOfficial.Checked = true;
                }
                else
                {
                    this.checkBoxOfficial.Checked = false;
                } }
        }

        public bool Main
        {
            get
            {
                return this.checkBoxMainImage.Checked;
            }
            set { this.checkBoxMainImage.Checked = value; }
        }

        public string Description
        {
            get
            {

                return this.textBoxDescription.Text;
            }
            set { this.textBoxDescription.Text = value; }
        }

        public bool Accident
        {
            get
            {
                return this.checkBoxAccident.Checked;
            }
            set { this.checkBoxAccident.Checked = value; }
        }

        private void pictureBoxImage_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void pictureBoxImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;

            this.pictureBoxImage.Image = Image.FromFile(files[0]);
        }

        public event EventHandler SelectClick;

        protected void Select_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.SelectClick != null)
                this.SelectClick(this, e);
        }

        private void ImageUS_Load(object sender, EventArgs e)
        {
            this.pictureBoxImage.AllowDrop = true;
        }

        private void checkBoxAccident_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAccident.Checked)
            {
                checkBoxMainImage.Checked = false;
                checkBoxOfficial.Checked = false;
                checkBoxMainImage.Enabled = false;
                checkBoxOfficial.Enabled = false;
            }
            else
            {
                checkBoxMainImage.Checked = false;
                checkBoxOfficial.Checked = false;
                checkBoxMainImage.Enabled = true;
                checkBoxOfficial.Enabled = true;
            }
        }
    }
}
