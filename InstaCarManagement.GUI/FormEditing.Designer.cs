namespace InstaCarManagement.GUI
{
    partial class FormEditing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlBaseData = new System.Windows.Forms.TabControl();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.labelCustomerCity = new System.Windows.Forms.Label();
            this.labelCustomerPostcode = new System.Windows.Forms.Label();
            this.labelCustomerHouseNr = new System.Windows.Forms.Label();
            this.labelCustomerStreet = new System.Windows.Forms.Label();
            this.labelCustomerFamilyName = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerCity = new System.Windows.Forms.TextBox();
            this.textBoxCustomerPostcode = new System.Windows.Forms.TextBox();
            this.textBoxCustomerHouseNr = new System.Windows.Forms.TextBox();
            this.textBoxCustomerStreet = new System.Windows.Forms.TextBox();
            this.textBoxCustomerFamilyName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.listViewCustomer = new System.Windows.Forms.ListView();
            this.tabPageVehicle = new System.Windows.Forms.TabPage();
            this.splitContainerVehicle = new System.Windows.Forms.SplitContainer();
            this.groupBoxVehicles = new System.Windows.Forms.GroupBox();
            this.pictureBoxVehicleImage = new System.Windows.Forms.PictureBox();
            this.buttonVehicleClose = new System.Windows.Forms.Button();
            this.buttonVehicleCancel = new System.Windows.Forms.Button();
            this.buttonVehicleSave = new System.Windows.Forms.Button();
            this.labelVehicleFeature3 = new System.Windows.Forms.Label();
            this.labelVehicleFeature4 = new System.Windows.Forms.Label();
            this.labelVehicleBrand = new System.Windows.Forms.Label();
            this.labelVehicleHP = new System.Windows.Forms.Label();
            this.labelVehicleFeature2 = new System.Windows.Forms.Label();
            this.labelVehiclePrice = new System.Windows.Forms.Label();
            this.labelVehicleFeature1 = new System.Windows.Forms.Label();
            this.labelVehicleModell = new System.Windows.Forms.Label();
            this.comboBoxVehicleFeature2 = new System.Windows.Forms.ComboBox();
            this.comboBoxVehicleFeature3 = new System.Windows.Forms.ComboBox();
            this.comboBoxVehicleFeature4 = new System.Windows.Forms.ComboBox();
            this.comboBoxVehicleFeature1 = new System.Windows.Forms.ComboBox();
            this.checkBoxVehicleNotAvailable = new System.Windows.Forms.CheckBox();
            this.textBoxVehiclePrice = new System.Windows.Forms.TextBox();
            this.textBoxVehicleHP = new System.Windows.Forms.TextBox();
            this.textBoxVehicleBrand = new System.Windows.Forms.TextBox();
            this.textBoxVehicleModell = new System.Windows.Forms.TextBox();
            this.listViewVehicle = new System.Windows.Forms.ListView();
            this.tabPageLocation = new System.Windows.Forms.TabPage();
            this.splitContainerLocation = new System.Windows.Forms.SplitContainer();
            this.groupBoxLocation = new System.Windows.Forms.GroupBox();
            this.labelLocationCity = new System.Windows.Forms.Label();
            this.labelLocationPostcode = new System.Windows.Forms.Label();
            this.labelLocationHouseNr = new System.Windows.Forms.Label();
            this.labelLocationStreet = new System.Windows.Forms.Label();
            this.labelLocationName = new System.Windows.Forms.Label();
            this.textBoxLocationCity = new System.Windows.Forms.TextBox();
            this.textBoxLocationPostcode = new System.Windows.Forms.TextBox();
            this.textBoxLocationHouseNr = new System.Windows.Forms.TextBox();
            this.textBoxLocationStreet = new System.Windows.Forms.TextBox();
            this.textBoxLocationName = new System.Windows.Forms.TextBox();
            this.listViewLocation = new System.Windows.Forms.ListView();
            this.buttonCustomerSave = new System.Windows.Forms.Button();
            this.buttonCustomerCancel = new System.Windows.Forms.Button();
            this.buttonCustomerClose = new System.Windows.Forms.Button();
            this.buttonLocationSave = new System.Windows.Forms.Button();
            this.buttonLocationCancel = new System.Windows.Forms.Button();
            this.buttonLocationClose = new System.Windows.Forms.Button();
            this.tabControlBaseData.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            this.tabPageVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVehicle)).BeginInit();
            this.splitContainerVehicle.Panel1.SuspendLayout();
            this.splitContainerVehicle.Panel2.SuspendLayout();
            this.splitContainerVehicle.SuspendLayout();
            this.groupBoxVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicleImage)).BeginInit();
            this.tabPageLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLocation)).BeginInit();
            this.splitContainerLocation.Panel1.SuspendLayout();
            this.splitContainerLocation.Panel2.SuspendLayout();
            this.splitContainerLocation.SuspendLayout();
            this.groupBoxLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBaseData
            // 
            this.tabControlBaseData.Controls.Add(this.tabPageCustomer);
            this.tabControlBaseData.Controls.Add(this.tabPageVehicle);
            this.tabControlBaseData.Controls.Add(this.tabPageLocation);
            this.tabControlBaseData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBaseData.Location = new System.Drawing.Point(0, 0);
            this.tabControlBaseData.Name = "tabControlBaseData";
            this.tabControlBaseData.SelectedIndex = 0;
            this.tabControlBaseData.Size = new System.Drawing.Size(800, 450);
            this.tabControlBaseData.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.splitContainer2);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(792, 424);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Kunde";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxCustomer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listViewCustomer);
            this.splitContainer2.Size = new System.Drawing.Size(786, 418);
            this.splitContainer2.SplitterDistance = 262;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.buttonCustomerClose);
            this.groupBoxCustomer.Controls.Add(this.buttonCustomerCancel);
            this.groupBoxCustomer.Controls.Add(this.buttonCustomerSave);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerCity);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerPostcode);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerHouseNr);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerStreet);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerFamilyName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerCity);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerPostcode);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerHouseNr);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerStreet);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerFamilyName);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerName);
            this.groupBoxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCustomer.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(262, 418);
            this.groupBoxCustomer.TabIndex = 0;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Kunde";
            // 
            // labelCustomerCity
            // 
            this.labelCustomerCity.AutoSize = true;
            this.labelCustomerCity.Location = new System.Drawing.Point(3, 169);
            this.labelCustomerCity.Name = "labelCustomerCity";
            this.labelCustomerCity.Size = new System.Drawing.Size(32, 13);
            this.labelCustomerCity.TabIndex = 11;
            this.labelCustomerCity.Text = "Stadt";
            // 
            // labelCustomerPostcode
            // 
            this.labelCustomerPostcode.AutoSize = true;
            this.labelCustomerPostcode.Location = new System.Drawing.Point(3, 130);
            this.labelCustomerPostcode.Name = "labelCustomerPostcode";
            this.labelCustomerPostcode.Size = new System.Drawing.Size(27, 13);
            this.labelCustomerPostcode.TabIndex = 10;
            this.labelCustomerPostcode.Text = "PLZ";
            // 
            // labelCustomerHouseNr
            // 
            this.labelCustomerHouseNr.AutoSize = true;
            this.labelCustomerHouseNr.Location = new System.Drawing.Point(189, 91);
            this.labelCustomerHouseNr.Name = "labelCustomerHouseNr";
            this.labelCustomerHouseNr.Size = new System.Drawing.Size(49, 13);
            this.labelCustomerHouseNr.TabIndex = 9;
            this.labelCustomerHouseNr.Text = "Haus Nr.";
            // 
            // labelCustomerStreet
            // 
            this.labelCustomerStreet.AutoSize = true;
            this.labelCustomerStreet.Location = new System.Drawing.Point(3, 91);
            this.labelCustomerStreet.Name = "labelCustomerStreet";
            this.labelCustomerStreet.Size = new System.Drawing.Size(38, 13);
            this.labelCustomerStreet.TabIndex = 8;
            this.labelCustomerStreet.Text = "Straße";
            // 
            // labelCustomerFamilyName
            // 
            this.labelCustomerFamilyName.AutoSize = true;
            this.labelCustomerFamilyName.Location = new System.Drawing.Point(3, 52);
            this.labelCustomerFamilyName.Name = "labelCustomerFamilyName";
            this.labelCustomerFamilyName.Size = new System.Drawing.Size(59, 13);
            this.labelCustomerFamilyName.TabIndex = 7;
            this.labelCustomerFamilyName.Text = "Nachname";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(3, 13);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(49, 13);
            this.labelCustomerName.TabIndex = 6;
            this.labelCustomerName.Text = "Vorname";
            // 
            // textBoxCustomerCity
            // 
            this.textBoxCustomerCity.Location = new System.Drawing.Point(6, 185);
            this.textBoxCustomerCity.Name = "textBoxCustomerCity";
            this.textBoxCustomerCity.Size = new System.Drawing.Size(200, 20);
            this.textBoxCustomerCity.TabIndex = 5;
            // 
            // textBoxCustomerPostcode
            // 
            this.textBoxCustomerPostcode.Location = new System.Drawing.Point(6, 146);
            this.textBoxCustomerPostcode.Name = "textBoxCustomerPostcode";
            this.textBoxCustomerPostcode.Size = new System.Drawing.Size(200, 20);
            this.textBoxCustomerPostcode.TabIndex = 4;
            // 
            // textBoxCustomerHouseNr
            // 
            this.textBoxCustomerHouseNr.Location = new System.Drawing.Point(192, 107);
            this.textBoxCustomerHouseNr.Name = "textBoxCustomerHouseNr";
            this.textBoxCustomerHouseNr.Size = new System.Drawing.Size(50, 20);
            this.textBoxCustomerHouseNr.TabIndex = 3;
            // 
            // textBoxCustomerStreet
            // 
            this.textBoxCustomerStreet.Location = new System.Drawing.Point(6, 107);
            this.textBoxCustomerStreet.Name = "textBoxCustomerStreet";
            this.textBoxCustomerStreet.Size = new System.Drawing.Size(180, 20);
            this.textBoxCustomerStreet.TabIndex = 2;
            // 
            // textBoxCustomerFamilyName
            // 
            this.textBoxCustomerFamilyName.Location = new System.Drawing.Point(6, 68);
            this.textBoxCustomerFamilyName.Name = "textBoxCustomerFamilyName";
            this.textBoxCustomerFamilyName.Size = new System.Drawing.Size(200, 20);
            this.textBoxCustomerFamilyName.TabIndex = 1;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(6, 29);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(200, 20);
            this.textBoxCustomerName.TabIndex = 0;
            // 
            // listViewCustomer
            // 
            this.listViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCustomer.FullRowSelect = true;
            this.listViewCustomer.GridLines = true;
            this.listViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.listViewCustomer.Name = "listViewCustomer";
            this.listViewCustomer.Size = new System.Drawing.Size(520, 418);
            this.listViewCustomer.TabIndex = 0;
            this.listViewCustomer.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageVehicle
            // 
            this.tabPageVehicle.Controls.Add(this.splitContainerVehicle);
            this.tabPageVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabPageVehicle.Name = "tabPageVehicle";
            this.tabPageVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVehicle.Size = new System.Drawing.Size(792, 424);
            this.tabPageVehicle.TabIndex = 1;
            this.tabPageVehicle.Text = "Fahrzeuge";
            this.tabPageVehicle.UseVisualStyleBackColor = true;
            // 
            // splitContainerVehicle
            // 
            this.splitContainerVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVehicle.Location = new System.Drawing.Point(3, 3);
            this.splitContainerVehicle.Name = "splitContainerVehicle";
            // 
            // splitContainerVehicle.Panel1
            // 
            this.splitContainerVehicle.Panel1.Controls.Add(this.groupBoxVehicles);
            // 
            // splitContainerVehicle.Panel2
            // 
            this.splitContainerVehicle.Panel2.Controls.Add(this.listViewVehicle);
            this.splitContainerVehicle.Size = new System.Drawing.Size(786, 418);
            this.splitContainerVehicle.SplitterDistance = 321;
            this.splitContainerVehicle.TabIndex = 0;
            // 
            // groupBoxVehicles
            // 
            this.groupBoxVehicles.Controls.Add(this.pictureBoxVehicleImage);
            this.groupBoxVehicles.Controls.Add(this.buttonVehicleClose);
            this.groupBoxVehicles.Controls.Add(this.buttonVehicleCancel);
            this.groupBoxVehicles.Controls.Add(this.buttonVehicleSave);
            this.groupBoxVehicles.Controls.Add(this.labelVehicleFeature3);
            this.groupBoxVehicles.Controls.Add(this.labelVehicleFeature4);
            this.groupBoxVehicles.Controls.Add(this.labelVehicleBrand);
            this.groupBoxVehicles.Controls.Add(this.labelVehicleHP);
            this.groupBoxVehicles.Controls.Add(this.labelVehicleFeature2);
            this.groupBoxVehicles.Controls.Add(this.labelVehiclePrice);
            this.groupBoxVehicles.Controls.Add(this.labelVehicleFeature1);
            this.groupBoxVehicles.Controls.Add(this.labelVehicleModell);
            this.groupBoxVehicles.Controls.Add(this.comboBoxVehicleFeature2);
            this.groupBoxVehicles.Controls.Add(this.comboBoxVehicleFeature3);
            this.groupBoxVehicles.Controls.Add(this.comboBoxVehicleFeature4);
            this.groupBoxVehicles.Controls.Add(this.comboBoxVehicleFeature1);
            this.groupBoxVehicles.Controls.Add(this.checkBoxVehicleNotAvailable);
            this.groupBoxVehicles.Controls.Add(this.textBoxVehiclePrice);
            this.groupBoxVehicles.Controls.Add(this.textBoxVehicleHP);
            this.groupBoxVehicles.Controls.Add(this.textBoxVehicleBrand);
            this.groupBoxVehicles.Controls.Add(this.textBoxVehicleModell);
            this.groupBoxVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVehicles.Location = new System.Drawing.Point(0, 0);
            this.groupBoxVehicles.Name = "groupBoxVehicles";
            this.groupBoxVehicles.Size = new System.Drawing.Size(321, 418);
            this.groupBoxVehicles.TabIndex = 0;
            this.groupBoxVehicles.TabStop = false;
            this.groupBoxVehicles.Text = "Fahrzeuge";
            // 
            // pictureBoxVehicleImage
            // 
            this.pictureBoxVehicleImage.Location = new System.Drawing.Point(215, 19);
            this.pictureBoxVehicleImage.Name = "pictureBoxVehicleImage";
            this.pictureBoxVehicleImage.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxVehicleImage.TabIndex = 21;
            this.pictureBoxVehicleImage.TabStop = false;
            // 
            // buttonVehicleClose
            // 
            this.buttonVehicleClose.Location = new System.Drawing.Point(184, 390);
            this.buttonVehicleClose.Name = "buttonVehicleClose";
            this.buttonVehicleClose.Size = new System.Drawing.Size(75, 23);
            this.buttonVehicleClose.TabIndex = 20;
            this.buttonVehicleClose.Text = "Schließen";
            this.buttonVehicleClose.UseVisualStyleBackColor = true;
            // 
            // buttonVehicleCancel
            // 
            this.buttonVehicleCancel.Location = new System.Drawing.Point(83, 237);
            this.buttonVehicleCancel.Name = "buttonVehicleCancel";
            this.buttonVehicleCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonVehicleCancel.TabIndex = 19;
            this.buttonVehicleCancel.Text = "Abrechen";
            this.buttonVehicleCancel.UseVisualStyleBackColor = true;
            // 
            // buttonVehicleSave
            // 
            this.buttonVehicleSave.Location = new System.Drawing.Point(2, 237);
            this.buttonVehicleSave.Name = "buttonVehicleSave";
            this.buttonVehicleSave.Size = new System.Drawing.Size(75, 23);
            this.buttonVehicleSave.TabIndex = 18;
            this.buttonVehicleSave.Text = "Speichern";
            this.buttonVehicleSave.UseVisualStyleBackColor = true;
            // 
            // labelVehicleFeature3
            // 
            this.labelVehicleFeature3.AutoSize = true;
            this.labelVehicleFeature3.Location = new System.Drawing.Point(1, 171);
            this.labelVehicleFeature3.Name = "labelVehicleFeature3";
            this.labelVehicleFeature3.Size = new System.Drawing.Size(56, 13);
            this.labelVehicleFeature3.TabIndex = 17;
            this.labelVehicleFeature3.Text = "Merkmal 3";
            // 
            // labelVehicleFeature4
            // 
            this.labelVehicleFeature4.AutoSize = true;
            this.labelVehicleFeature4.Location = new System.Drawing.Point(128, 171);
            this.labelVehicleFeature4.Name = "labelVehicleFeature4";
            this.labelVehicleFeature4.Size = new System.Drawing.Size(56, 13);
            this.labelVehicleFeature4.TabIndex = 16;
            this.labelVehicleFeature4.Text = "Merkmal 4";
            // 
            // labelVehicleBrand
            // 
            this.labelVehicleBrand.AutoSize = true;
            this.labelVehicleBrand.Location = new System.Drawing.Point(4, 55);
            this.labelVehicleBrand.Name = "labelVehicleBrand";
            this.labelVehicleBrand.Size = new System.Drawing.Size(37, 13);
            this.labelVehicleBrand.TabIndex = 15;
            this.labelVehicleBrand.Text = "Marke";
            // 
            // labelVehicleHP
            // 
            this.labelVehicleHP.AutoSize = true;
            this.labelVehicleHP.Location = new System.Drawing.Point(4, 94);
            this.labelVehicleHP.Name = "labelVehicleHP";
            this.labelVehicleHP.Size = new System.Drawing.Size(21, 13);
            this.labelVehicleHP.TabIndex = 14;
            this.labelVehicleHP.Text = "PS";
            // 
            // labelVehicleFeature2
            // 
            this.labelVehicleFeature2.AutoSize = true;
            this.labelVehicleFeature2.Location = new System.Drawing.Point(128, 131);
            this.labelVehicleFeature2.Name = "labelVehicleFeature2";
            this.labelVehicleFeature2.Size = new System.Drawing.Size(56, 13);
            this.labelVehicleFeature2.TabIndex = 13;
            this.labelVehicleFeature2.Text = "Merkmal 2";
            // 
            // labelVehiclePrice
            // 
            this.labelVehiclePrice.AutoSize = true;
            this.labelVehiclePrice.Location = new System.Drawing.Point(100, 94);
            this.labelVehiclePrice.Name = "labelVehiclePrice";
            this.labelVehiclePrice.Size = new System.Drawing.Size(30, 13);
            this.labelVehiclePrice.TabIndex = 12;
            this.labelVehiclePrice.Text = "Preis";
            // 
            // labelVehicleFeature1
            // 
            this.labelVehicleFeature1.AutoSize = true;
            this.labelVehicleFeature1.Location = new System.Drawing.Point(4, 131);
            this.labelVehicleFeature1.Name = "labelVehicleFeature1";
            this.labelVehicleFeature1.Size = new System.Drawing.Size(56, 13);
            this.labelVehicleFeature1.TabIndex = 11;
            this.labelVehicleFeature1.Text = "Merkmal 1";
            // 
            // labelVehicleModell
            // 
            this.labelVehicleModell.AutoSize = true;
            this.labelVehicleModell.Location = new System.Drawing.Point(6, 16);
            this.labelVehicleModell.Name = "labelVehicleModell";
            this.labelVehicleModell.Size = new System.Drawing.Size(38, 13);
            this.labelVehicleModell.TabIndex = 10;
            this.labelVehicleModell.Text = "Modell";
            // 
            // comboBoxVehicleFeature2
            // 
            this.comboBoxVehicleFeature2.FormattingEnabled = true;
            this.comboBoxVehicleFeature2.Location = new System.Drawing.Point(131, 147);
            this.comboBoxVehicleFeature2.Name = "comboBoxVehicleFeature2";
            this.comboBoxVehicleFeature2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVehicleFeature2.TabIndex = 9;
            // 
            // comboBoxVehicleFeature3
            // 
            this.comboBoxVehicleFeature3.FormattingEnabled = true;
            this.comboBoxVehicleFeature3.Location = new System.Drawing.Point(4, 187);
            this.comboBoxVehicleFeature3.Name = "comboBoxVehicleFeature3";
            this.comboBoxVehicleFeature3.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVehicleFeature3.TabIndex = 8;
            // 
            // comboBoxVehicleFeature4
            // 
            this.comboBoxVehicleFeature4.FormattingEnabled = true;
            this.comboBoxVehicleFeature4.Location = new System.Drawing.Point(131, 187);
            this.comboBoxVehicleFeature4.Name = "comboBoxVehicleFeature4";
            this.comboBoxVehicleFeature4.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVehicleFeature4.TabIndex = 7;
            // 
            // comboBoxVehicleFeature1
            // 
            this.comboBoxVehicleFeature1.FormattingEnabled = true;
            this.comboBoxVehicleFeature1.Location = new System.Drawing.Point(4, 147);
            this.comboBoxVehicleFeature1.Name = "comboBoxVehicleFeature1";
            this.comboBoxVehicleFeature1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVehicleFeature1.TabIndex = 6;
            // 
            // checkBoxVehicleNotAvailable
            // 
            this.checkBoxVehicleNotAvailable.AutoSize = true;
            this.checkBoxVehicleNotAvailable.Location = new System.Drawing.Point(4, 214);
            this.checkBoxVehicleNotAvailable.Name = "checkBoxVehicleNotAvailable";
            this.checkBoxVehicleNotAvailable.Size = new System.Drawing.Size(99, 17);
            this.checkBoxVehicleNotAvailable.TabIndex = 5;
            this.checkBoxVehicleNotAvailable.Text = "Nicht verfügbar";
            this.checkBoxVehicleNotAvailable.UseVisualStyleBackColor = true;
            // 
            // textBoxVehiclePrice
            // 
            this.textBoxVehiclePrice.Location = new System.Drawing.Point(103, 110);
            this.textBoxVehiclePrice.Name = "textBoxVehiclePrice";
            this.textBoxVehiclePrice.Size = new System.Drawing.Size(90, 20);
            this.textBoxVehiclePrice.TabIndex = 4;
            // 
            // textBoxVehicleHP
            // 
            this.textBoxVehicleHP.Location = new System.Drawing.Point(7, 110);
            this.textBoxVehicleHP.Name = "textBoxVehicleHP";
            this.textBoxVehicleHP.Size = new System.Drawing.Size(90, 20);
            this.textBoxVehicleHP.TabIndex = 3;
            // 
            // textBoxVehicleBrand
            // 
            this.textBoxVehicleBrand.Location = new System.Drawing.Point(7, 71);
            this.textBoxVehicleBrand.Name = "textBoxVehicleBrand";
            this.textBoxVehicleBrand.Size = new System.Drawing.Size(200, 20);
            this.textBoxVehicleBrand.TabIndex = 2;
            // 
            // textBoxVehicleModell
            // 
            this.textBoxVehicleModell.Location = new System.Drawing.Point(9, 32);
            this.textBoxVehicleModell.Name = "textBoxVehicleModell";
            this.textBoxVehicleModell.Size = new System.Drawing.Size(200, 20);
            this.textBoxVehicleModell.TabIndex = 1;
            // 
            // listViewVehicle
            // 
            this.listViewVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVehicle.FullRowSelect = true;
            this.listViewVehicle.GridLines = true;
            this.listViewVehicle.Location = new System.Drawing.Point(0, 0);
            this.listViewVehicle.Name = "listViewVehicle";
            this.listViewVehicle.Size = new System.Drawing.Size(461, 418);
            this.listViewVehicle.TabIndex = 0;
            this.listViewVehicle.UseCompatibleStateImageBehavior = false;
            this.listViewVehicle.View = System.Windows.Forms.View.Details;
            // 
            // tabPageLocation
            // 
            this.tabPageLocation.Controls.Add(this.splitContainerLocation);
            this.tabPageLocation.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocation.Name = "tabPageLocation";
            this.tabPageLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocation.Size = new System.Drawing.Size(792, 424);
            this.tabPageLocation.TabIndex = 2;
            this.tabPageLocation.Text = "Standort";
            this.tabPageLocation.UseVisualStyleBackColor = true;
            // 
            // splitContainerLocation
            // 
            this.splitContainerLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLocation.Location = new System.Drawing.Point(3, 3);
            this.splitContainerLocation.Name = "splitContainerLocation";
            // 
            // splitContainerLocation.Panel1
            // 
            this.splitContainerLocation.Panel1.Controls.Add(this.groupBoxLocation);
            // 
            // splitContainerLocation.Panel2
            // 
            this.splitContainerLocation.Panel2.Controls.Add(this.listViewLocation);
            this.splitContainerLocation.Size = new System.Drawing.Size(786, 418);
            this.splitContainerLocation.SplitterDistance = 262;
            this.splitContainerLocation.TabIndex = 0;
            // 
            // groupBoxLocation
            // 
            this.groupBoxLocation.Controls.Add(this.buttonLocationClose);
            this.groupBoxLocation.Controls.Add(this.buttonLocationCancel);
            this.groupBoxLocation.Controls.Add(this.buttonLocationSave);
            this.groupBoxLocation.Controls.Add(this.labelLocationCity);
            this.groupBoxLocation.Controls.Add(this.labelLocationPostcode);
            this.groupBoxLocation.Controls.Add(this.labelLocationHouseNr);
            this.groupBoxLocation.Controls.Add(this.labelLocationStreet);
            this.groupBoxLocation.Controls.Add(this.labelLocationName);
            this.groupBoxLocation.Controls.Add(this.textBoxLocationCity);
            this.groupBoxLocation.Controls.Add(this.textBoxLocationPostcode);
            this.groupBoxLocation.Controls.Add(this.textBoxLocationHouseNr);
            this.groupBoxLocation.Controls.Add(this.textBoxLocationStreet);
            this.groupBoxLocation.Controls.Add(this.textBoxLocationName);
            this.groupBoxLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLocation.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(262, 418);
            this.groupBoxLocation.TabIndex = 0;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Location";
            // 
            // labelLocationCity
            // 
            this.labelLocationCity.AutoSize = true;
            this.labelLocationCity.Location = new System.Drawing.Point(3, 171);
            this.labelLocationCity.Name = "labelLocationCity";
            this.labelLocationCity.Size = new System.Drawing.Size(32, 13);
            this.labelLocationCity.TabIndex = 11;
            this.labelLocationCity.Text = "Stadt";
            // 
            // labelLocationPostcode
            // 
            this.labelLocationPostcode.AutoSize = true;
            this.labelLocationPostcode.Location = new System.Drawing.Point(3, 132);
            this.labelLocationPostcode.Name = "labelLocationPostcode";
            this.labelLocationPostcode.Size = new System.Drawing.Size(27, 13);
            this.labelLocationPostcode.TabIndex = 10;
            this.labelLocationPostcode.Text = "PLZ";
            this.labelLocationPostcode.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelLocationHouseNr
            // 
            this.labelLocationHouseNr.AutoSize = true;
            this.labelLocationHouseNr.Location = new System.Drawing.Point(3, 93);
            this.labelLocationHouseNr.Name = "labelLocationHouseNr";
            this.labelLocationHouseNr.Size = new System.Drawing.Size(49, 13);
            this.labelLocationHouseNr.TabIndex = 9;
            this.labelLocationHouseNr.Text = "Haus Nr.";
            // 
            // labelLocationStreet
            // 
            this.labelLocationStreet.AutoSize = true;
            this.labelLocationStreet.Location = new System.Drawing.Point(5, 54);
            this.labelLocationStreet.Name = "labelLocationStreet";
            this.labelLocationStreet.Size = new System.Drawing.Size(38, 13);
            this.labelLocationStreet.TabIndex = 8;
            this.labelLocationStreet.Text = "Straße";
            // 
            // labelLocationName
            // 
            this.labelLocationName.AutoSize = true;
            this.labelLocationName.Location = new System.Drawing.Point(5, 15);
            this.labelLocationName.Name = "labelLocationName";
            this.labelLocationName.Size = new System.Drawing.Size(35, 13);
            this.labelLocationName.TabIndex = 7;
            this.labelLocationName.Text = "Name";
            // 
            // textBoxLocationCity
            // 
            this.textBoxLocationCity.Location = new System.Drawing.Point(6, 187);
            this.textBoxLocationCity.Name = "textBoxLocationCity";
            this.textBoxLocationCity.Size = new System.Drawing.Size(200, 20);
            this.textBoxLocationCity.TabIndex = 6;
            // 
            // textBoxLocationPostcode
            // 
            this.textBoxLocationPostcode.Location = new System.Drawing.Point(6, 148);
            this.textBoxLocationPostcode.Name = "textBoxLocationPostcode";
            this.textBoxLocationPostcode.Size = new System.Drawing.Size(200, 20);
            this.textBoxLocationPostcode.TabIndex = 5;
            // 
            // textBoxLocationHouseNr
            // 
            this.textBoxLocationHouseNr.Location = new System.Drawing.Point(6, 109);
            this.textBoxLocationHouseNr.Name = "textBoxLocationHouseNr";
            this.textBoxLocationHouseNr.Size = new System.Drawing.Size(200, 20);
            this.textBoxLocationHouseNr.TabIndex = 4;
            // 
            // textBoxLocationStreet
            // 
            this.textBoxLocationStreet.Location = new System.Drawing.Point(6, 70);
            this.textBoxLocationStreet.Name = "textBoxLocationStreet";
            this.textBoxLocationStreet.Size = new System.Drawing.Size(200, 20);
            this.textBoxLocationStreet.TabIndex = 3;
            // 
            // textBoxLocationName
            // 
            this.textBoxLocationName.Location = new System.Drawing.Point(6, 31);
            this.textBoxLocationName.Name = "textBoxLocationName";
            this.textBoxLocationName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLocationName.TabIndex = 2;
            // 
            // listViewLocation
            // 
            this.listViewLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLocation.FullRowSelect = true;
            this.listViewLocation.GridLines = true;
            this.listViewLocation.Location = new System.Drawing.Point(0, 0);
            this.listViewLocation.Name = "listViewLocation";
            this.listViewLocation.Size = new System.Drawing.Size(520, 418);
            this.listViewLocation.TabIndex = 0;
            this.listViewLocation.UseCompatibleStateImageBehavior = false;
            this.listViewLocation.View = System.Windows.Forms.View.Details;
            // 
            // buttonCustomerSave
            // 
            this.buttonCustomerSave.Location = new System.Drawing.Point(6, 211);
            this.buttonCustomerSave.Name = "buttonCustomerSave";
            this.buttonCustomerSave.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerSave.TabIndex = 12;
            this.buttonCustomerSave.Text = "Speichern";
            this.buttonCustomerSave.UseVisualStyleBackColor = true;
            // 
            // buttonCustomerCancel
            // 
            this.buttonCustomerCancel.Location = new System.Drawing.Point(87, 211);
            this.buttonCustomerCancel.Name = "buttonCustomerCancel";
            this.buttonCustomerCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerCancel.TabIndex = 13;
            this.buttonCustomerCancel.Text = "Abbrechen";
            this.buttonCustomerCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCustomerClose
            // 
            this.buttonCustomerClose.Location = new System.Drawing.Point(181, 392);
            this.buttonCustomerClose.Name = "buttonCustomerClose";
            this.buttonCustomerClose.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerClose.TabIndex = 14;
            this.buttonCustomerClose.Text = "Schließen";
            this.buttonCustomerClose.UseVisualStyleBackColor = true;
            // 
            // buttonLocationSave
            // 
            this.buttonLocationSave.Location = new System.Drawing.Point(6, 213);
            this.buttonLocationSave.Name = "buttonLocationSave";
            this.buttonLocationSave.Size = new System.Drawing.Size(75, 23);
            this.buttonLocationSave.TabIndex = 12;
            this.buttonLocationSave.Text = "Speichern";
            this.buttonLocationSave.UseVisualStyleBackColor = true;
            // 
            // buttonLocationCancel
            // 
            this.buttonLocationCancel.Location = new System.Drawing.Point(87, 213);
            this.buttonLocationCancel.Name = "buttonLocationCancel";
            this.buttonLocationCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonLocationCancel.TabIndex = 13;
            this.buttonLocationCancel.Text = "Abbrechen";
            this.buttonLocationCancel.UseVisualStyleBackColor = true;
            // 
            // buttonLocationClose
            // 
            this.buttonLocationClose.Location = new System.Drawing.Point(181, 389);
            this.buttonLocationClose.Name = "buttonLocationClose";
            this.buttonLocationClose.Size = new System.Drawing.Size(75, 23);
            this.buttonLocationClose.TabIndex = 14;
            this.buttonLocationClose.Text = "Schließen";
            this.buttonLocationClose.UseVisualStyleBackColor = true;
            // 
            // FormEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlBaseData);
            this.Name = "FormEditing";
            this.Text = "Stammdaten";
            this.tabControlBaseData.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.tabPageVehicle.ResumeLayout(false);
            this.splitContainerVehicle.Panel1.ResumeLayout(false);
            this.splitContainerVehicle.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVehicle)).EndInit();
            this.splitContainerVehicle.ResumeLayout(false);
            this.groupBoxVehicles.ResumeLayout(false);
            this.groupBoxVehicles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicleImage)).EndInit();
            this.tabPageLocation.ResumeLayout(false);
            this.splitContainerLocation.Panel1.ResumeLayout(false);
            this.splitContainerLocation.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLocation)).EndInit();
            this.splitContainerLocation.ResumeLayout(false);
            this.groupBoxLocation.ResumeLayout(false);
            this.groupBoxLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBaseData;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.TabPage tabPageVehicle;
        private System.Windows.Forms.TabPage tabPageLocation;
        private System.Windows.Forms.SplitContainer splitContainerLocation;
        private System.Windows.Forms.GroupBox groupBoxLocation;
        private System.Windows.Forms.ListView listViewLocation;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.ListView listViewCustomer;
        private System.Windows.Forms.SplitContainer splitContainerVehicle;
        private System.Windows.Forms.GroupBox groupBoxVehicles;
        private System.Windows.Forms.ListView listViewVehicle;
        private System.Windows.Forms.TextBox textBoxCustomerCity;
        private System.Windows.Forms.TextBox textBoxCustomerPostcode;
        private System.Windows.Forms.TextBox textBoxCustomerHouseNr;
        private System.Windows.Forms.TextBox textBoxCustomerStreet;
        private System.Windows.Forms.TextBox textBoxCustomerFamilyName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.ComboBox comboBoxVehicleFeature2;
        private System.Windows.Forms.ComboBox comboBoxVehicleFeature3;
        private System.Windows.Forms.ComboBox comboBoxVehicleFeature4;
        private System.Windows.Forms.ComboBox comboBoxVehicleFeature1;
        private System.Windows.Forms.CheckBox checkBoxVehicleNotAvailable;
        private System.Windows.Forms.TextBox textBoxVehiclePrice;
        private System.Windows.Forms.TextBox textBoxVehicleHP;
        private System.Windows.Forms.TextBox textBoxVehicleBrand;
        private System.Windows.Forms.TextBox textBoxVehicleModell;
        private System.Windows.Forms.Label labelLocationCity;
        private System.Windows.Forms.Label labelLocationPostcode;
        private System.Windows.Forms.Label labelLocationHouseNr;
        private System.Windows.Forms.Label labelLocationStreet;
        private System.Windows.Forms.Label labelLocationName;
        private System.Windows.Forms.TextBox textBoxLocationCity;
        private System.Windows.Forms.TextBox textBoxLocationPostcode;
        private System.Windows.Forms.TextBox textBoxLocationHouseNr;
        private System.Windows.Forms.TextBox textBoxLocationStreet;
        private System.Windows.Forms.TextBox textBoxLocationName;
        private System.Windows.Forms.PictureBox pictureBoxVehicleImage;
        private System.Windows.Forms.Button buttonVehicleClose;
        private System.Windows.Forms.Button buttonVehicleCancel;
        private System.Windows.Forms.Button buttonVehicleSave;
        private System.Windows.Forms.Label labelVehicleFeature3;
        private System.Windows.Forms.Label labelVehicleFeature4;
        private System.Windows.Forms.Label labelVehicleBrand;
        private System.Windows.Forms.Label labelVehicleHP;
        private System.Windows.Forms.Label labelVehicleFeature2;
        private System.Windows.Forms.Label labelVehiclePrice;
        private System.Windows.Forms.Label labelVehicleFeature1;
        private System.Windows.Forms.Label labelVehicleModell;
        private System.Windows.Forms.Label labelCustomerCity;
        private System.Windows.Forms.Label labelCustomerPostcode;
        private System.Windows.Forms.Label labelCustomerHouseNr;
        private System.Windows.Forms.Label labelCustomerStreet;
        private System.Windows.Forms.Label labelCustomerFamilyName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Button buttonCustomerClose;
        private System.Windows.Forms.Button buttonCustomerCancel;
        private System.Windows.Forms.Button buttonCustomerSave;
        private System.Windows.Forms.Button buttonLocationClose;
        private System.Windows.Forms.Button buttonLocationCancel;
        private System.Windows.Forms.Button buttonLocationSave;
    }
}