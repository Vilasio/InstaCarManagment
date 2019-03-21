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
    public partial class FormEditing : Form
    {
        public FormEditing()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------------
        //Shared
        //----------------------------------------------------------------------------------------------
        #region Shared
        NpgsqlConnection connection = null;


        #endregion

        //----------------------------------------------------------------------------------------------
        //Customer
        //----------------------------------------------------------------------------------------------
        #region Customer
        List<Customer> customers = null;
        Customer customer = null;
        bool editCust = false;

        #region Methods Customer
        private void FillListViewCustomer()
        {
            this.listViewCustomer.Items.Clear();
            ListViewItem item = null;

            foreach (Customer customer in customers)
            {
                item.Text = customer.Name;
                item.SubItems.Add(customer.Familyname);
                item.SubItems.Add(customer.Street);
                item.SubItems.Add(customer.HouseNr.ToString());
                item.SubItems.Add(customer.Postcode);
                item.SubItems.Add(customer.City);
                item.Tag = customer;
                this.listViewCustomer.Items.Add(item);
            }
        }

        private void FillCustomer()
        {
            this.textBoxCustomerName.Text = this.customer.Name;
            this.textBoxCustomerFamilyName.Text = this.customer.Familyname;
            this.textBoxCustomerStreet.Text = this.customer.Street;
            this.textBoxCustomerHouseNr.Text = this.customer.HouseNr.ToString();
            this.textBoxCustomerPostcode.Text = this.customer.Postcode;
            this.textBoxCustomerCity.Text = this.customer.City;
        }
    

        private bool ValidateCustomer()
        {
            bool result = false;


            return result;
        }


        #endregion
        #region CustomerPageEvents
        private void tabPageCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageCustomer_Leave(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion

        //----------------------------------------------------------------------------------------------
        //Vehicle
        //----------------------------------------------------------------------------------------------
        #region Vehicle
        List<Vehicle> vehicles = null;
        Vehicle vehicle = null;
        bool editVehic = false;

        enum enumFeatures
        {
            Kein = 0,
            Klimaanlage = 1,
            Multifunktionslenkrad = 2,
            Freispreckeinrichtung = 3
        }

        #region Methods Vehicle
        private void FillListViewVehicle()
        {
            this.listViewVehicle.Items.Clear();
            ListViewItem item = null;

            foreach (Vehicle vehicle in vehicles)
            {
                item.Text = vehicle.Modell;
                item.SubItems.Add(vehicle.Brand);
                item.SubItems.Add(vehicle.HP.ToString());
                item.SubItems.Add(vehicle.Feature1);
                item.SubItems.Add(vehicle.Feature2);
                item.SubItems.Add(vehicle.Feature3);
                item.SubItems.Add(vehicle.Feature4);
                item.Tag = vehicle;
                this.listViewVehicle.Items.Add(item);
            }
        }

        private void FillVehicle()
        {
            this.textBoxVehicleModell.Text = this.vehicle.Modell;
            this.textBoxVehicleBrand.Text = this.vehicle.Brand;
            this.textBoxVehicleHP.Text = this.vehicle.HP.ToString();
            this.comboBoxVehicleFeature1.SelectedIndex = this.vehicle.Feature1;
            this.comboBoxVehicleFeature2.SelectedIndex = this.vehicle.Feature2;
            this.comboBoxVehicleFeature3.SelectedIndex = this.vehicle.Feature3;
            this.comboBoxVehicleFeature4.SelectedIndex = this.vehicle.Feature4;

            if (this.vehicle.NotAvailable)
            {
                this.checkBoxVehicleNotAvailable.Checked = true;
            }
            else
            {
                this.checkBoxVehicleNotAvailable.Checked = false;
            }
        }

        private bool ValidateVehicle()
        {
            bool result = false;


            return result;
        }
        #endregion
        #region VehiclePageEvents
        private void tabPageVehicle_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageVehicle_Leave(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion

        //----------------------------------------------------------------------------------------------
        //Location
        //----------------------------------------------------------------------------------------------
        #region Location
        List<Location> locations = null;
        Location location = null;
        bool editLocat = false;



        #region Methods Location
        private void FillListViewLocation()
        {
            this.listViewLocation.Items.Clear();
            ListViewItem item = null;

            foreach (Location location in locations)
            {
                item.Text = location.Name;
                item.SubItems.Add(location.Street);
                item.SubItems.Add(location.HouseNr.ToString());
                item.SubItems.Add(location.Postcode);
                item.SubItems.Add(location.City);
                item.Tag = location;
                this.listViewLocation.Items.Add(item);
            }
        }

        private void FillLocation()
        {
            this.textBoxLocationName.Text = this.location.Name;
            this.textBoxLocationStreet.Text = this.location.Street;
            this.textBoxLocationHouseNr.Text = this.location.HouseNr.ToString();
            this.textBoxLocationPostcode.Text = this.location.Postcode;
            this.textBoxLocationCity.Text = this.location.City;
        }

        private bool ValidateLocation()
        {
            bool result = false;


            return result;
        }
        #endregion
        #region LocationPageEvents
        private void tabPageLocation_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageLocation_Leave(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion


    }
}
