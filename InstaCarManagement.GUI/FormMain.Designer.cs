namespace InstaCarManagement.GUI
{
    partial class FormMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabelDescrip1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelDescrip2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelDbName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditCar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRentCar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUserManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFamilyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateBegin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelDescrip1,
            this.StatusLabelUser,
            this.StatusLabelSpace,
            this.StatusLabelDescrip2,
            this.StatusLabelDbName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.UseWaitCursor = true;
            // 
            // StatusLabelDescrip1
            // 
            this.StatusLabelDescrip1.Name = "StatusLabelDescrip1";
            this.StatusLabelDescrip1.Size = new System.Drawing.Size(92, 17);
            this.StatusLabelDescrip1.Text = "Angemeldet als:";
            // 
            // StatusLabelUser
            // 
            this.StatusLabelUser.Name = "StatusLabelUser";
            this.StatusLabelUser.Size = new System.Drawing.Size(90, 17);
            this.StatusLabelUser.Text = "StatusLabelUser";
            // 
            // StatusLabelSpace
            // 
            this.StatusLabelSpace.Name = "StatusLabelSpace";
            this.StatusLabelSpace.Size = new System.Drawing.Size(61, 17);
            this.StatusLabelSpace.Text = "|                |";
            // 
            // StatusLabelDescrip2
            // 
            this.StatusLabelDescrip2.Name = "StatusLabelDescrip2";
            this.StatusLabelDescrip2.Size = new System.Drawing.Size(148, 17);
            this.StatusLabelDescrip2.Text = "Verbunden mit Datenbank:";
            // 
            // StatusLabelDbName
            // 
            this.StatusLabelDbName.Name = "StatusLabelDbName";
            this.StatusLabelDbName.Size = new System.Drawing.Size(114, 17);
            this.StatusLabelDbName.Text = "StatusLabelDbName";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemData,
            this.MenuItemEdit,
            this.MenuItemAdministration});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemData
            // 
            this.MenuItemData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExit});
            this.MenuItemData.Name = "MenuItemData";
            this.MenuItemData.Size = new System.Drawing.Size(46, 20);
            this.MenuItemData.Text = "Datei";
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemExit.Size = new System.Drawing.Size(134, 22);
            this.MenuItemExit.Text = "Exit";
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEditCar,
            this.MenuItemEditCustomer,
            this.MenuItemEditLocation,
            this.MenuItemRentCar});
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(75, 20);
            this.MenuItemEdit.Text = "Bearbeiten";
            // 
            // MenuItemEditCar
            // 
            this.MenuItemEditCar.Name = "MenuItemEditCar";
            this.MenuItemEditCar.Size = new System.Drawing.Size(234, 22);
            this.MenuItemEditCar.Text = "Fahrzeuge anlegen/bearbeiten";
            this.MenuItemEditCar.Click += new System.EventHandler(this.MenuItemEditCar_Click);
            // 
            // MenuItemEditCustomer
            // 
            this.MenuItemEditCustomer.Name = "MenuItemEditCustomer";
            this.MenuItemEditCustomer.Size = new System.Drawing.Size(234, 22);
            this.MenuItemEditCustomer.Text = "Kunden anlegen/bearbeiten";
            this.MenuItemEditCustomer.Click += new System.EventHandler(this.MenuItemEditCustomer_Click);
            // 
            // MenuItemEditLocation
            // 
            this.MenuItemEditLocation.Name = "MenuItemEditLocation";
            this.MenuItemEditLocation.Size = new System.Drawing.Size(234, 22);
            this.MenuItemEditLocation.Text = "Standorte anlegen/bearbeiten";
            this.MenuItemEditLocation.Click += new System.EventHandler(this.MenuItemEditLocation_Click);
            // 
            // MenuItemRentCar
            // 
            this.MenuItemRentCar.Name = "MenuItemRentCar";
            this.MenuItemRentCar.Size = new System.Drawing.Size(234, 22);
            this.MenuItemRentCar.Text = "Fahrzeug vermieten";
            // 
            // MenuItemAdministration
            // 
            this.MenuItemAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUserManagment});
            this.MenuItemAdministration.Enabled = false;
            this.MenuItemAdministration.Name = "MenuItemAdministration";
            this.MenuItemAdministration.Size = new System.Drawing.Size(98, 20);
            this.MenuItemAdministration.Text = "Administration";
            this.MenuItemAdministration.Visible = false;
            // 
            // MenuItemUserManagment
            // 
            this.MenuItemUserManagment.Name = "MenuItemUserManagment";
            this.MenuItemUserManagment.Size = new System.Drawing.Size(174, 22);
            this.MenuItemUserManagment.Text = "Benutzer verwalten";
            this.MenuItemUserManagment.Click += new System.EventHandler(this.MenuItemUserManagment_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderFamilyName,
            this.columnHeaderBrand,
            this.columnHeaderModell,
            this.columnHeaderDateBegin,
            this.columnHeaderDateEnd});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 404);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Vorname";
            this.columnHeaderName.Width = 100;
            // 
            // columnHeaderFamilyName
            // 
            this.columnHeaderFamilyName.Text = "Nachname";
            this.columnHeaderFamilyName.Width = 100;
            // 
            // columnHeaderBrand
            // 
            this.columnHeaderBrand.Text = "Marke";
            this.columnHeaderBrand.Width = 100;
            // 
            // columnHeaderModell
            // 
            this.columnHeaderModell.Text = "Model";
            this.columnHeaderModell.Width = 100;
            // 
            // columnHeaderDateBegin
            // 
            this.columnHeaderDateBegin.Text = "Beginn";
            this.columnHeaderDateBegin.Width = 100;
            // 
            // columnHeaderDateEnd
            // 
            this.columnHeaderDateEnd.Text = "Ende";
            this.columnHeaderDateEnd.Width = 100;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "InstaCar Managementtool";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelDescrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelUser;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelSpace;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelDescrip2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelDbName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemData;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditCar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditCustomer;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditLocation;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRentCar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdministration;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUserManagment;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderFamilyName;
        private System.Windows.Forms.ColumnHeader columnHeaderBrand;
        private System.Windows.Forms.ColumnHeader columnHeaderModell;
        private System.Windows.Forms.ColumnHeader columnHeaderDateBegin;
        private System.Windows.Forms.ColumnHeader columnHeaderDateEnd;
    }
}