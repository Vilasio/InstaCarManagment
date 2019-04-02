using InstaCarManagement.Data;
using Npgsql;
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
    public partial class FormImages : Form
    {
        private NpgsqlConnection connection = null;
        private Vehicle vehicle = null;
        private ImageUS delete = null;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ImageUS add = new ImageUS(this.connection, this.vehicle);
            add.Click += new EventHandler(UserControl_ButtonClick); ;

            this.flowLayoutPanelImages.Controls.Add(add);
        }

       
        

        protected void UserControl_ButtonClick(object sender, EventArgs e)
        {
            this.delete = (ImageUS)sender;
            this.flowLayoutPanelImages.Controls.Remove(delete);
        }
    }
}
