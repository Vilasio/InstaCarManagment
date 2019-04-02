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

        public event EventHandler ButtonClick;

        protected void Button1_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
