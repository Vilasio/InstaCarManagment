using InstaCarManagement.Data;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaCarManagement.GUI
{
    public partial class FormRent : Form
    {
        private NpgsqlConnection connection = null;
        

        enum enumFeatures
        {
            Kein = 0,
            Klimaanlage = 1,
            Multifunktionslenkrad = 2,
            Freispreckeinrichtung = 3,
            Tempomat = 4
        }

        public FormRent()
        {
            InitializeComponent();
        }

        public FormRent(NpgsqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.rent = new Rent(this.connection);
            this.editRent = false;
        }

        public FormRent(NpgsqlConnection connection, Rent rent)
        {
            InitializeComponent();
            this.connection = connection;
            this.rent = rent;
            this.editRent = true;
        }


        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.FromArgb(00, 00, 255));
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void FormRent_Load(object sender, EventArgs e)
        {
            this.groupBoxHeader.Paint += PaintBorderlessGroupBox;
            this.customers = Customer.GetAllCustomer(this.connection);
            this.vehicles = Vehicle.GetAvailableVehicles(this.connection, this.dateTimePickerBegin.Value);
            this.locations = LocationCar.GetAllLocation(this.connection);
            
            ClearVehicle();
            ClearCustomer();

            this.comboBoxVehicleLocation.DataSource = this.locations;
            this.comboBoxVehicleLocation.DisplayMember = "Name";
            this.comboBoxVehicleLocation.ValueMember = "LocationId";

            if (this.editRent)
            {
                this.vehicle = Vehicle.GetSpecificVehicles(this.connection, (int)this.rent.CarId);
                this.customer = customers.Find(x => x.CustomerId.Equals(this.rent.CustomerId));
                this.vehicles.Add(vehicle);
                FillCustomer();
                FillVehicle();
                
                if (this.rent.Begin.HasValue)
                {
                    this.dateTimePickerBegin.Value = this.rent.Begin.Value;
                    this.dateTimePickerBegin.Checked = true;
                }
                if (this.rent.End.HasValue)
                {
                    this.dateTimePickerEnd.Value = this.rent.End.Value;
                    this.dateTimePickerEnd.Checked = true;
                }
                this.listViewCustomer.Enabled = false;
                if (this.rent.Begin.Value < DateTime.Now)
                {
                    this.listViewVehicle.Enabled = false;
                }
            }
            FillListViewCustomer();
            FillListViewVehicle();
        }

        private bool editRent = false;
        private Rent rent = null;
        private List<Customer> customers = null;
        private Customer customer = null;
        private List<Vehicle> vehicles = null;
        private Vehicle vehicle = null;
        private List<LocationCar> locations = null;


        private void FillListViewCustomer()
        {
            this.listViewCustomer.Items.Clear();
            ListViewItem item = null;

            foreach (Customer customer in customers)
            {
                item = new ListViewItem();
                item.Text = customer.CustomerNo;
                item.SubItems.Add(customer.Name);
                item.SubItems.Add(customer.Familyname);
                item.SubItems.Add(customer.Street);
                item.SubItems.Add(customer.HouseNr.ToString());
                item.SubItems.Add(customer.Postcode);
                item.SubItems.Add(customer.City);
                item.Tag = customer;
                this.listViewCustomer.Items.Add(item);
            }
        }

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

        private void FillCustomer()
        {
            this.textBoxCustomerCustomerNo.Text = this.customer.CustomerNo;
            this.textBoxCustomerName.Text = this.customer.Name;
            this.textBoxCustomerFamilyName.Text = this.customer.Familyname;
            this.textBoxCustomerStreet.Text = this.customer.Street;
            this.textBoxCustomerHouseNr.Text = this.customer.HouseNr.ToString();
            this.textBoxCustomerPostcode.Text = this.customer.Postcode;
            this.textBoxCustomerCity.Text = this.customer.City;
            this.textBoxCustomerEmail.Text = this.customer.Email;
            this.textBoxCustomerTelefon.Text = this.customer.Telefon;
        }

        private void ClearCustomer()
        {
            this.customer = new Customer(this.connection);
            this.textBoxCustomerName.Text = string.Empty;
            this.textBoxCustomerCustomerNo.Text = string.Empty;
            this.textBoxCustomerFamilyName.Text = string.Empty;
            this.textBoxCustomerStreet.Text = string.Empty;
            this.textBoxCustomerHouseNr.Text = string.Empty;
            this.textBoxCustomerPostcode.Text = string.Empty;
            this.textBoxCustomerCity.Text = string.Empty;
            this.textBoxCustomerTelefon.Text = string.Empty;
            this.textBoxCustomerEmail.Text = string.Empty;
        }


        private void FillVehicle()
        {

            if (this.vehicle.Pictures.Count != 0)
            {
                foreach (ImageCar imageCar in this.vehicle.Pictures)
                {
                    if (imageCar.Main)
                    {
                        this.pictureBoxVehicleImage.Image = imageCar.Image;

                    }
                }
            }
            else
            {
                this.pictureBoxVehicleImage.Image = null;
            }
            this.textBoxVehicleModell.Text = this.vehicle.Modell;
            this.textBoxVehicleBrand.Text = this.vehicle.Brand;
            this.textBoxVehicleHP.Text = this.vehicle.HP.ToString();
            this.textBoxVehiclePrice.Text = this.vehicle.Price.ToString();
            this.comboBoxVehicleFeature1.SelectedIndex = Convert.ToInt32(this.vehicle.Feature1);
            this.comboBoxVehicleFeature2.SelectedIndex = Convert.ToInt32(this.vehicle.Feature2);
            this.comboBoxVehicleFeature3.SelectedIndex = Convert.ToInt32(this.vehicle.Feature3);
            this.comboBoxVehicleFeature4.SelectedIndex = Convert.ToInt32(this.vehicle.Feature4);


            this.comboBoxVehicleLocation.SelectedValue = this.vehicle.LocationId;


        }

        public void ClearVehicle()
        {
            this.vehicle = new Vehicle(this.connection);

            this.textBoxVehicleModell.Text = string.Empty;
            this.textBoxVehicleBrand.Text = string.Empty;
            this.textBoxVehicleHP.Text = string.Empty;
            this.textBoxVehiclePrice.Text = Vehicle.Getprice(connection).ToString();
            this.comboBoxVehicleFeature1.DataSource = Enum.GetValues(typeof(enumFeatures));
            this.comboBoxVehicleFeature2.DataSource = Enum.GetValues(typeof(enumFeatures));
            this.comboBoxVehicleFeature3.DataSource = Enum.GetValues(typeof(enumFeatures));
            this.comboBoxVehicleFeature4.DataSource = Enum.GetValues(typeof(enumFeatures));
            this.comboBoxVehicleLocation.SelectedValue = (long)1;

            this.pictureBoxVehicleImage.Image = null;

        }

        private void listViewCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            ClearCustomer();
            ListViewItem item = this.listViewCustomer.GetItemAt(e.X, e.Y);
            this.customer = null;
            this.customer = (Customer)item.Tag;
            FillCustomer();
        }

        private void listViewVehicle_MouseClick(object sender, MouseEventArgs e)
        {
            ClearVehicle();
            ListViewItem item = this.listViewVehicle.GetItemAt(e.X, e.Y);
            this.vehicle = null;
            this.vehicle = (Vehicle)item.Tag;
            FillVehicle();
        }

        private void listViewCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearCustomer();
            ListViewItem item = this.listViewCustomer.GetItemAt(e.X, e.Y);
            this.customer = null;
            this.customer = (Customer)item.Tag;
            FillCustomer();
            this.tabControlRent.SelectedTab = tabPageVehicle;
        }

        private void listViewVehicle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearVehicle();
            ListViewItem item = this.listViewVehicle.GetItemAt(e.X, e.Y);
            this.vehicle = null;
            this.vehicle = (Vehicle)item.Tag;
            FillVehicle();
        }

        private bool ValidateRent()
        {
            bool result = true;
            this.labelStatus.Visible = false;
            if (this.vehicle == null)
            {
                this.labelStatus.Visible = true;
                this.labelStatus.Text = "Es wurde kein Fahrzeug ausgewählt";
                SystemSounds.Asterisk.Play();
                return false;
            }
            else
            {
                this.rent.CarId = this.vehicle.CarId;
                this.rent.Modell = this.vehicle.Modell;
                this.rent.Brand = this.vehicle.Brand;
            }
            if (this.customer == null)
            {
                this.labelStatus.Visible = true;
                this.labelStatus.Text = "Es wurde kein Kunde ausgewählt";
                SystemSounds.Asterisk.Play();
                return false;
            }
            else
            {
                this.rent.CustomerId = this.customer.CustomerId;
                this.rent.Name = this.customer.Name;
                this.rent.FamilyName = this.customer.Familyname;
            }

            if (this.dateTimePickerBegin.Value > this.dateTimePickerEnd.Value )
            {
                this.labelStatus.Visible = true;
                this.labelStatus.Text = "Das Beginndatum kann nicht nach dem EndeDatum stattfinden";
                SystemSounds.Asterisk.Play();
                return false;
            }

            if (this.dateTimePickerBegin.Checked)
            {
                this.rent.Begin = this.dateTimePickerBegin.Value;
            }
            if (this.dateTimePickerEnd.Checked)
            {
                this.rent.End = this.dateTimePickerEnd.Value;
            }

            if (this.rent.Begin != null && this.rent.End != null)
            {
                double units = (this.rent.End.Value - this.rent.Begin.Value).TotalHours;
                this.rent.Units = (long?)Math.Ceiling(units);
                this.rent.SumPrice = this.vehicle.Price * this.rent.Units;
            }

            return result;
        }

        private void ClearRent()
        {
            this.rent = new Rent(this.connection);
            this.dateTimePickerBegin.Value = DateTime.Now;
            this.dateTimePickerEnd.Value = DateTime.Now;
            this.dateTimePickerBegin.Checked = false;
            this.dateTimePickerEnd.Checked = false;
            this.customers = Customer.GetAllCustomer(this.connection);
            this.vehicles = Vehicle.GetAvailableVehicles(this.connection, this.dateTimePickerBegin.Value);
            FillListViewCustomer();
            FillListViewVehicle();
        }

        private void buttonBeginNow_Click(object sender, EventArgs e)
        {
            this.dateTimePickerBegin.Checked = true;
            this.dateTimePickerBegin.Value = DateTime.Now;
        }

        private void buttonEndNow_Click(object sender, EventArgs e)
        {
            this.dateTimePickerEnd.Checked = true;
            this.dateTimePickerEnd.Value = DateTime.Now;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateRent())
            {
                this.rent.Save();
                //this.vehicle.InUse = true;
                //this.vehicle.Save();
                this.editRent = false;
                this.listViewCustomer.Enabled = true;
                this.listViewVehicle.Enabled = true;
                ClearVehicle();
                ClearCustomer();
                ClearRent();
                this.labelStatus.Visible = true;
                this.labelStatus.Text = "Erfolg!";
                

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dateTimePickerBegin_ValueChanged(object sender, EventArgs e)
        {
            this.vehicles = Vehicle.GetAvailableVehicles(this.connection, this.dateTimePickerBegin.Value);
            if (editRent)
            {
                this.vehicles.Add(vehicle);
            }
            FillListViewVehicle();
            bool contains = false;
            foreach (Vehicle vehicle in vehicles)
            {
                if (this.vehicle.CarId == vehicle.CarId || !this.vehicle.CarId.HasValue)
                {
                    contains = true;
                }
            }

            if (!contains)
            {
                this.labelStatus.Visible = true;
                this.labelStatus.Text = "Das Fahrzeug ist zu diesen Zeitpunkt vermietet";
                SystemSounds.Asterisk.Play();
                ClearVehicle();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.rent.RentId.HasValue)
            {
                if (!this.rent.End.HasValue)
                {
                    this.rent.DeleteAndEnd();
                }
                else
                {
                    this.rent.Delete();
                }
                this.rent.Delete();
                ClearRent();
                ClearVehicle();
                ClearCustomer();
                this.labelStatus.Visible = true;
                this.labelStatus.Text = "Erfolg";
            }
            else
            {
                ClearRent();
                ClearVehicle();
                ClearCustomer();
                this.labelStatus.Visible = true;
                this.labelStatus.Text = "Erfolg";
            }
        }
    }
}
