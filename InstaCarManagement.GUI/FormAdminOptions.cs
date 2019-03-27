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
    public partial class FormAdminOptions : Form
    {
        private NpgsqlConnection connection;

        public FormAdminOptions()
        {
            InitializeComponent();
        }

        public FormAdminOptions(NpgsqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            
        }


        private void FormAdminOptions_Load(object sender, EventArgs e)
        {
            this.groupBoxHeader.Paint += PaintBorderlessGroupBox;
            FillPrice();
        }

        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.FromArgb(00, 00, 255));
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }
        //----------------------------------------------------------------------------------------------
        //Pricing
        //----------------------------------------------------------------------------------------------
        #region pricing
        private void FillPrice()
        {
            this.textBoxVehiclePricePerHour.Text = Vehicle.Getprice(this.connection).ToString();
        }

        private void buttonVehiclePriceSave_Click(object sender, EventArgs e)
        {
            this.labelVehiclePriceStatus.Visible = false;
            double price;
            bool parse = double.TryParse(this.textBoxVehiclePricePerHour.Text, out price);
            if (parse)
            {
               int result = Vehicle.Changeprice(this.connection, price);
                if (result != 0)
                {
                    this.labelVehiclePriceStatus.Text = "Erfolg!";
                    this.labelVehiclePriceStatus.Visible = true;
                }
                else
                {
                    this.labelVehiclePriceStatus.Text = "Fehlgeschlagen";
                    this.labelVehiclePriceStatus.Visible = true;
                }
            }
            else
            {
                this.labelVehiclePriceStatus.Text = "Die Eingabe muss eine Zahl sein";
                this.labelVehiclePriceStatus.Visible = true;
            }
        }

        private void buttonVehiclePriceCancel_Click(object sender, EventArgs e)
        {
            FillPrice();
        }

        private void tabPagePricing_Enter(object sender, EventArgs e)
        {
            FillPrice();
        }



        #endregion

        private void buttonPricingClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
