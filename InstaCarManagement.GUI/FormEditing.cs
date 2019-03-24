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
using System.Media;

namespace InstaCarManagement.GUI
{
    public partial class FormEditing : Form
    {
        public FormEditing()
        {
            InitializeComponent();
        }

        public FormEditing(NpgsqlConnection connection, int preselect)
        {
            InitializeComponent();
            this.connection = connection;
            this.preselect = preselect;
        }

        //----------------------------------------------------------------------------------------------
        //Shared
        //----------------------------------------------------------------------------------------------
        #region Shared
        private NpgsqlConnection connection = null;
        private int preselect = 0;

        private void FormEditing_Load(object sender, EventArgs e)
        {
            this.customers = Customer.GetAllCustomer(this.connection);
            this.vehicles = Vehicle.GetAllVehicles(this.connection);
            this.locations = LocationCar.GetAllLocation(this.connection);

            switch (this.preselect)
            {
                case 0:
                    this.tabControlBaseData.SelectedTab = tabPageCustomer;
                        break;
                case 1:
                    this.tabControlBaseData.SelectedTab = tabPageCustomer;
                    break;
                case 2:
                    this.tabControlBaseData.SelectedTab = tabPageVehicle;
                    break;
                case 3:
                    this.tabControlBaseData.SelectedTab = tabPageLocation;
                    break;
            }
        }
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
                item = new ListViewItem();
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
            this.groupBoxCustomer.Text = $"Kunde {this.customer.Name} {this.customer.Familyname} bearbeiten.";
            this.textBoxCustomerName.Text = this.customer.Name;
            this.textBoxCustomerFamilyName.Text = this.customer.Familyname;
            this.textBoxCustomerStreet.Text = this.customer.Street;
            this.textBoxCustomerHouseNr.Text = this.customer.HouseNr.ToString();
            this.textBoxCustomerPostcode.Text = this.customer.Postcode;
            this.textBoxCustomerCity.Text = this.customer.City;
        }
    

        private bool ValidateCustomer()
        {
            bool result = true;
            int hnr;
            
            this.labelCustomerStatus.Visible = false;

            if (this.textBoxCustomerName.Text != "")
            {
                this.customer.Name = this.textBoxCustomerName.Text;
            }
            else
            {
                result = false;
                this.labelCustomerStatus.Visible = true;
                this.labelCustomerStatus.Text = "Name angegeben werden.";
                SystemSounds.Asterisk.Play();
                return result;
            }

            if (this.textBoxCustomerFamilyName.Text != "")
            {
                this.customer.Familyname = this.textBoxCustomerFamilyName.Text;
            }
            else
            {
                result = false;
                this.labelCustomerStatus.Visible = true;
                this.labelCustomerStatus.Text = "Nachname angegeben werden.";
                SystemSounds.Asterisk.Play();
                return result;
            }

            if (this.textBoxCustomerStreet.Text != "")
            {
                this.customer.Street = this.textBoxCustomerStreet.Text;
            }
            else
            {
                result = false;
                this.labelCustomerStatus.Visible = true;
                this.labelCustomerStatus.Text = "Straße angegeben werden.";
                SystemSounds.Asterisk.Play();
                return result;
            }

            result = int.TryParse(this.textBoxCustomerHouseNr.Text, out hnr);
            if (result)
            {
                this.customer.HouseNr = hnr;
            }
            else
            {
                result = false;
                this.labelVehicleStatus.Visible = true;
                this.labelVehicleStatus.Text = "Hausnummer darf nur Zahlen beinhalten.";
                SystemSounds.Asterisk.Play();
                return result;

            }

            if (this.textBoxCustomerPostcode.Text != "")
            {
                this.customer.Postcode = this.textBoxCustomerPostcode.Text;
            }
            else
            {
                result = false;
                this.labelCustomerStatus.Visible = true;
                this.labelCustomerStatus.Text = "PLZ muss angegeben werden.";
                SystemSounds.Asterisk.Play();
                return result;
            }

            if (this.textBoxCustomerCity.Text != "")
            {
                this.customer.City = this.textBoxCustomerCity.Text;
            }
            else
            {
                result = false;
                this.labelCustomerStatus.Visible = true;
                this.labelCustomerStatus.Text = "Straße angegeben werden.";
                SystemSounds.Asterisk.Play();
                return result;
            }

            return result;
        }

        private void ClearCustomer()
        {
            this.customer = new Customer(this.connection);
            this.textBoxCustomerName.Text = string.Empty;
            this.textBoxCustomerFamilyName.Text = string.Empty;
            this.textBoxCustomerStreet.Text = string.Empty;
            this.textBoxCustomerHouseNr.Text = string.Empty;
            this.textBoxCustomerPostcode.Text = string.Empty;
            this.textBoxCustomerCity.Text = string.Empty;

        }

        #endregion
        #region CustomerPageEvents
        private void tabPageCustomer_Enter(object sender, EventArgs e)
        {
            FillListViewCustomer();
            ClearCustomer();
        }

        private void tabPageCustomer_Leave(object sender, EventArgs e)
        {

        }
        private void buttonCustomerSave_Click(object sender, EventArgs e)
        {
            if (ValidateCustomer())
            {
                this.customer.Save();
                if (!this.editCust)
                {
                    this.customers.Add(this.customer);
                }
                ClearCustomer();
                FillListViewCustomer();
                this.labelCustomerStatus.Text = "Erfolg!";
                this.labelCustomerStatus.Visible = true;
                this.editCust = false;
            }
        }

        private void buttonCustomerCancel_Click(object sender, EventArgs e)
        {
            ClearCustomer();
        }

        private void listViewCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewCustomer.GetItemAt(e.X, e.Y);
            this.customer = null;
            this.customer = (Customer)item.Tag;
            this.editCust = true;
            FillCustomer();
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
                item = new ListViewItem();
                item.Text = vehicle.Modell;
                item.SubItems.Add(vehicle.Brand);
                item.SubItems.Add(vehicle.HP.ToString());
                item.SubItems.Add(Enum.GetName(typeof(enumFeatures), vehicle.Feature1));
                item.SubItems.Add(Enum.GetName(typeof(enumFeatures), vehicle.Feature2));
                item.SubItems.Add(Enum.GetName(typeof(enumFeatures), vehicle.Feature3));
                item.SubItems.Add(Enum.GetName(typeof(enumFeatures), vehicle.Feature4));
                item.Tag = vehicle;
                this.listViewVehicle.Items.Add(item);
            }
        }

        private void FillVehicle()
        {
            this.groupBoxVehicles.Text = $"Fahrzeug {this.vehicle.Brand} {this.vehicle.Modell} bearbeiten";
            this.textBoxVehicleModell.Text = this.vehicle.Modell;
            this.textBoxVehicleBrand.Text = this.vehicle.Brand;
            this.textBoxVehicleHP.Text = this.vehicle.HP.ToString();
            this.comboBoxVehicleFeature1.SelectedIndex = Convert.ToInt32( this.vehicle.Feature1);
            this.comboBoxVehicleFeature2.SelectedIndex = Convert.ToInt32(this.vehicle.Feature2);
            this.comboBoxVehicleFeature3.SelectedIndex = Convert.ToInt32(this.vehicle.Feature3);
            this.comboBoxVehicleFeature4.SelectedIndex = Convert.ToInt32(this.vehicle.Feature4);

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
            int hp;
            this.labelVehicleStatus.Visible = false;
            if (this.textBoxVehicleModell.Text.Length >= 2)
            {
                this.vehicle.Modell = this.textBoxVehicleModell.Text;
            }
            else
            {
                result = false;
                this.labelVehicleStatus.Visible = true;
                this.labelVehicleStatus.Text = "Modell muss mindestens 2 Zeichen lang sein.";
                SystemSounds.Asterisk.Play();
                return result;
            }
            if (this.textBoxVehicleBrand.Text.Length >= 2)
            {
                this.vehicle.Brand = this.textBoxVehicleBrand.Text;
            }
            else
            {
                result = false;
                this.labelVehicleStatus.Visible = true;
                this.labelVehicleStatus.Text = "Modell muss mindestens 2 Zeichen lang sein.";
                SystemSounds.Asterisk.Play();
                return result;
            }
            

            result = int.TryParse(this.textBoxVehicleHP.Text, out hp);
            if (result)
            {
                this.vehicle.HP = hp;
            }
            else
            {

                this.labelVehicleStatus.Visible = true;
                this.labelVehicleStatus.Text = "PS darf nur zahlen beinhalte.";
                SystemSounds.Asterisk.Play();
                return result;
               
            }

            this.vehicle.Feature1 = Convert.ToInt64(this.comboBoxVehicleFeature1.SelectedValue);
            this.vehicle.Feature2 = Convert.ToInt64(this.comboBoxVehicleFeature2.SelectedValue);
            this.vehicle.Feature3 = Convert.ToInt64(this.comboBoxVehicleFeature3.SelectedValue);
            this.vehicle.Feature4 = Convert.ToInt64(this.comboBoxVehicleFeature4.SelectedValue);

            this.vehicle.NotAvailable =  this.checkBoxVehicleNotAvailable.Checked;
            return result;
        }

        public void ClearVehicle()
        {
            this.vehicle = new Vehicle(this.connection);
            this.editVehic = false;
            this.textBoxVehicleModell.Text = string.Empty;
            this.textBoxVehicleBrand.Text = string.Empty;
            this.textBoxVehicleHP.Text = string.Empty;
            this.textBoxVehiclePrice.Text = string.Empty;
            this.comboBoxVehicleFeature1.DataSource = Enum.GetValues(typeof(enumFeatures));
            this.comboBoxVehicleFeature2.DataSource = Enum.GetValues(typeof(enumFeatures));
            this.comboBoxVehicleFeature3.DataSource = Enum.GetValues(typeof(enumFeatures));
            this.comboBoxVehicleFeature4.DataSource = Enum.GetValues(typeof(enumFeatures));

            this.groupBoxVehicles.Text = "Neues Fahrzeug anlegen";

            this.labelVehicleStatus.Visible = false;
        }
        #endregion
        #region VehiclePageEvents
        private void tabPageVehicle_Enter(object sender, EventArgs e)
        {
            FillListViewVehicle();
            ClearVehicle();
        }

        private void tabPageVehicle_Leave(object sender, EventArgs e)
        {

        }

        private void buttonVehicleSave_Click(object sender, EventArgs e)
        {
            if (ValidateVehicle())
            {
                this.vehicle.Save();
                if (!this.editVehic)
                {
                    this.vehicles.Add(this.vehicle);
                }
                ClearVehicle();
                FillListViewVehicle();
                this.labelVehicleStatus.Text = "Erfolg!";
                this.labelVehicleStatus.Visible = true;
                this.editVehic = false;
            }
        }

        private void buttonVehicleCancel_Click(object sender, EventArgs e)
        {
            ClearVehicle();
        }

        private void buttonCustomerClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewVehicle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewVehicle.GetItemAt(e.X, e.Y);
            this.vehicle = null;
            this.vehicle = (Vehicle)item.Tag;
            this.editVehic = true;
            FillVehicle();
            
        }
        #endregion
        #endregion

        //----------------------------------------------------------------------------------------------
        //Location
        //----------------------------------------------------------------------------------------------
        #region Location
        List<LocationCar> locations = null;
        LocationCar location = null;
        bool editLocat = false;



        #region Methods Location
        private void FillListViewLocation()
        {
            this.listViewLocation.Items.Clear();
            ListViewItem item = null;

            foreach (LocationCar location in locations)
            {
                item = new ListViewItem();
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
            this.groupBoxLocation.Text = $"Standort {this.location.Name} bearbeiten.";
            this.textBoxLocationName.Text = this.location.Name;
            this.textBoxLocationStreet.Text = this.location.Street;
            this.textBoxLocationHouseNr.Text = this.location.HouseNr.ToString();
            this.textBoxLocationPostcode.Text = this.location.Postcode;
            this.textBoxLocationCity.Text = this.location.City;
        }

        private bool ValidateLocation()
        {
            bool result = true;
            int hnr;

            this.labelLocationStatus.Visible = false;

            if (this.textBoxLocationName.Text != "")
            {
                this.location.Name = this.textBoxLocationName.Text;
            }
            else
            {
                result = false;
                this.labelLocationStatus.Visible = true;
                this.labelLocationStatus.Text = "Name angegeben werden.";
                SystemSounds.Asterisk.Play();
                return result;
            }

            if (this.textBoxLocationStreet.Text != "")
            {
                this.location.Street = this.textBoxLocationStreet.Text;
            }
            else
            {
                result = false;
                this.labelLocationStatus.Visible = true;
                this.labelLocationStatus.Text = "Straße angegeben werden.";
                SystemSounds.Asterisk.Play();
                return result;
            }

            result = int.TryParse(this.textBoxLocationHouseNr.Text, out hnr);
            if (result)
            {
                this.location.HouseNr = hnr;
            }
            else
            {
                result = false;
                this.labelVehicleStatus.Visible = true;
                this.labelVehicleStatus.Text = "Hausnummer darf nur Zahlen beinhalten.";
                SystemSounds.Asterisk.Play();
                return result;

            }

            if (this.textBoxLocationPostcode.Text != "")
            {
                this.location.Postcode = this.textBoxLocationPostcode.Text;
            }
            else
            {
                result = false;
                this.labelLocationStatus.Visible = true;
                this.labelLocationStatus.Text = "PLZ muss angegeben werden.";
                SystemSounds.Asterisk.Play();
                return result;
            }

            if (this.textBoxLocationCity.Text != "")
            {
                this.location.City = this.textBoxLocationCity.Text;
            }
            else
            {
                result = false;
                this.labelLocationStatus.Visible = true;
                this.labelLocationStatus.Text = "Straße angegeben werden.";
                SystemSounds.Asterisk.Play();
                return result;
            }

            return result;
        }

        private void ClearLocation()
        {
            this.location = new LocationCar(this.connection);
            this.editLocat = false;
            this.textBoxLocationName.Text = string.Empty;
            this.textBoxLocationStreet.Text = string.Empty;
            this.textBoxLocationHouseNr.Text = string.Empty;
            this.textBoxLocationPostcode.Text = string.Empty;
            this.textBoxLocationCity.Text = string.Empty;

            this.groupBoxLocation.Text = "Neuen Standort anlegen";
            this.labelLocationStatus.Visible = false;
        }
        #endregion
        #region LocationPageEvents
        private void tabPageLocation_Enter(object sender, EventArgs e)
        {
            FillListViewLocation();
            ClearLocation();
        }

        private void tabPageLocation_Leave(object sender, EventArgs e)
        {

        }

        private void buttonLocationSave_Click(object sender, EventArgs e)
        {
            if (ValidateLocation())
            {
                this.location.Save();
                if (!this.editLocat)
                {
                    this.locations.Add(this.location);
                }
                ClearLocation();
                FillListViewLocation();
                this.labelLocationStatus.Text = "Erfolg!";
                this.labelLocationStatus.Visible = true;
                this.editLocat = false;
            }
        }

        private void buttonLocationCancel_Click(object sender, EventArgs e)
        {
            ClearCustomer();
        }

        private void buttonLocationClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewLocation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewLocation.GetItemAt(e.X, e.Y);
            this.location = null;
            this.location = (LocationCar)item.Tag;
            this.editLocat = true;
            FillLocation();
        }

        #endregion

        #endregion


    }
}
