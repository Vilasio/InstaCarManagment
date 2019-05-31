namespace InstaCarManagement.GUI
{
    partial class FormAdminOptions
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
            this.splitContainerPricing = new System.Windows.Forms.SplitContainer();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.labelTopic = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tabControlAdminOptions = new System.Windows.Forms.TabControl();
            this.tabPagePricing = new System.Windows.Forms.TabPage();
            this.buttonPricingClose = new System.Windows.Forms.Button();
            this.groupBoxPricingVehicle = new System.Windows.Forms.GroupBox();
            this.labelVehiclePriceStatus = new System.Windows.Forms.Label();
            this.labelEuro = new System.Windows.Forms.Label();
            this.buttonVehiclePriceCancel = new System.Windows.Forms.Button();
            this.buttonVehiclePriceSave = new System.Windows.Forms.Button();
            this.textBoxVehiclePricePerHour = new System.Windows.Forms.TextBox();
            this.labelVehiclePricePerHour = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPricing)).BeginInit();
            this.splitContainerPricing.Panel1.SuspendLayout();
            this.splitContainerPricing.Panel2.SuspendLayout();
            this.splitContainerPricing.SuspendLayout();
            this.groupBoxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabControlAdminOptions.SuspendLayout();
            this.tabPagePricing.SuspendLayout();
            this.groupBoxPricingVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerPricing
            // 
            this.splitContainerPricing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPricing.IsSplitterFixed = true;
            this.splitContainerPricing.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPricing.Name = "splitContainerPricing";
            this.splitContainerPricing.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerPricing.Panel1
            // 
            this.splitContainerPricing.Panel1.Controls.Add(this.groupBoxHeader);
            // 
            // splitContainerPricing.Panel2
            // 
            this.splitContainerPricing.Panel2.Controls.Add(this.tabControlAdminOptions);
            this.splitContainerPricing.Size = new System.Drawing.Size(800, 450);
            this.splitContainerPricing.SplitterDistance = 100;
            this.splitContainerPricing.TabIndex = 0;
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.BackColor = System.Drawing.Color.Blue;
            this.groupBoxHeader.Controls.Add(this.labelTopic);
            this.groupBoxHeader.Controls.Add(this.labelHeader);
            this.groupBoxHeader.Controls.Add(this.pictureBoxLogo);
            this.groupBoxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHeader.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(800, 103);
            this.groupBoxHeader.TabIndex = 2;
            this.groupBoxHeader.TabStop = false;
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Font = new System.Drawing.Font("Calibri", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopic.ForeColor = System.Drawing.Color.White;
            this.labelTopic.Location = new System.Drawing.Point(377, 48);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(417, 49);
            this.labelTopic.TabIndex = 2;
            this.labelTopic.Text = "Stammdatenverwaltung";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Calibri", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(151, 16);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(210, 66);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "InstaCar";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::InstaCarManagement.GUI.Properties.Resources.Logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(141, 85);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tabControlAdminOptions
            // 
            this.tabControlAdminOptions.Controls.Add(this.tabPagePricing);
            this.tabControlAdminOptions.Controls.Add(this.tabPage2);
            this.tabControlAdminOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdminOptions.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdminOptions.Name = "tabControlAdminOptions";
            this.tabControlAdminOptions.SelectedIndex = 0;
            this.tabControlAdminOptions.Size = new System.Drawing.Size(800, 346);
            this.tabControlAdminOptions.TabIndex = 0;
            // 
            // tabPagePricing
            // 
            this.tabPagePricing.Controls.Add(this.buttonPricingClose);
            this.tabPagePricing.Controls.Add(this.groupBoxPricingVehicle);
            this.tabPagePricing.Location = new System.Drawing.Point(4, 22);
            this.tabPagePricing.Name = "tabPagePricing";
            this.tabPagePricing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePricing.Size = new System.Drawing.Size(792, 320);
            this.tabPagePricing.TabIndex = 0;
            this.tabPagePricing.Text = "Preise";
            this.tabPagePricing.UseVisualStyleBackColor = true;
            this.tabPagePricing.Enter += new System.EventHandler(this.tabPagePricing_Enter);
            // 
            // buttonPricingClose
            // 
            this.buttonPricingClose.Location = new System.Drawing.Point(709, 289);
            this.buttonPricingClose.Name = "buttonPricingClose";
            this.buttonPricingClose.Size = new System.Drawing.Size(75, 23);
            this.buttonPricingClose.TabIndex = 6;
            this.buttonPricingClose.Text = "Schließen";
            this.buttonPricingClose.UseVisualStyleBackColor = true;
            this.buttonPricingClose.Click += new System.EventHandler(this.buttonPricingClose_Click);
            // 
            // groupBoxPricingVehicle
            // 
            this.groupBoxPricingVehicle.Controls.Add(this.labelVehiclePriceStatus);
            this.groupBoxPricingVehicle.Controls.Add(this.labelEuro);
            this.groupBoxPricingVehicle.Controls.Add(this.buttonVehiclePriceCancel);
            this.groupBoxPricingVehicle.Controls.Add(this.buttonVehiclePriceSave);
            this.groupBoxPricingVehicle.Controls.Add(this.textBoxVehiclePricePerHour);
            this.groupBoxPricingVehicle.Controls.Add(this.labelVehiclePricePerHour);
            this.groupBoxPricingVehicle.Location = new System.Drawing.Point(8, 6);
            this.groupBoxPricingVehicle.Name = "groupBoxPricingVehicle";
            this.groupBoxPricingVehicle.Size = new System.Drawing.Size(210, 306);
            this.groupBoxPricingVehicle.TabIndex = 0;
            this.groupBoxPricingVehicle.TabStop = false;
            this.groupBoxPricingVehicle.Text = "Fahrzeugpreise";
            // 
            // labelVehiclePriceStatus
            // 
            this.labelVehiclePriceStatus.AutoSize = true;
            this.labelVehiclePriceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehiclePriceStatus.ForeColor = System.Drawing.Color.Red;
            this.labelVehiclePriceStatus.Location = new System.Drawing.Point(6, 84);
            this.labelVehiclePriceStatus.Name = "labelVehiclePriceStatus";
            this.labelVehiclePriceStatus.Size = new System.Drawing.Size(45, 16);
            this.labelVehiclePriceStatus.TabIndex = 5;
            this.labelVehiclePriceStatus.Text = "Status";
            this.labelVehiclePriceStatus.Visible = false;
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuro.Location = new System.Drawing.Point(112, 48);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(16, 17);
            this.labelEuro.TabIndex = 4;
            this.labelEuro.Text = "€";
            // 
            // buttonVehiclePriceCancel
            // 
            this.buttonVehiclePriceCancel.Location = new System.Drawing.Point(87, 112);
            this.buttonVehiclePriceCancel.Name = "buttonVehiclePriceCancel";
            this.buttonVehiclePriceCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonVehiclePriceCancel.TabIndex = 3;
            this.buttonVehiclePriceCancel.Text = "Abbrechen";
            this.buttonVehiclePriceCancel.UseVisualStyleBackColor = true;
            this.buttonVehiclePriceCancel.Click += new System.EventHandler(this.buttonVehiclePriceCancel_Click);
            // 
            // buttonVehiclePriceSave
            // 
            this.buttonVehiclePriceSave.Location = new System.Drawing.Point(6, 112);
            this.buttonVehiclePriceSave.Name = "buttonVehiclePriceSave";
            this.buttonVehiclePriceSave.Size = new System.Drawing.Size(75, 23);
            this.buttonVehiclePriceSave.TabIndex = 2;
            this.buttonVehiclePriceSave.Text = "Ändern";
            this.buttonVehiclePriceSave.UseVisualStyleBackColor = true;
            this.buttonVehiclePriceSave.Click += new System.EventHandler(this.buttonVehiclePriceSave_Click);
            // 
            // textBoxVehiclePricePerHour
            // 
            this.textBoxVehiclePricePerHour.Location = new System.Drawing.Point(6, 45);
            this.textBoxVehiclePricePerHour.Name = "textBoxVehiclePricePerHour";
            this.textBoxVehiclePricePerHour.Size = new System.Drawing.Size(100, 20);
            this.textBoxVehiclePricePerHour.TabIndex = 1;
            // 
            // labelVehiclePricePerHour
            // 
            this.labelVehiclePricePerHour.AutoSize = true;
            this.labelVehiclePricePerHour.Location = new System.Drawing.Point(3, 29);
            this.labelVehiclePricePerHour.Name = "labelVehiclePricePerHour";
            this.labelVehiclePricePerHour.Size = new System.Drawing.Size(69, 13);
            this.labelVehiclePricePerHour.TabIndex = 0;
            this.labelVehiclePricePerHour.Text = "Preis/Stunde";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coming Soon";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormAdminOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerPricing);
            this.Name = "FormAdminOptions";
            this.Text = "Administrations Optionen";
            this.Load += new System.EventHandler(this.FormAdminOptions_Load);
            this.splitContainerPricing.Panel1.ResumeLayout(false);
            this.splitContainerPricing.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPricing)).EndInit();
            this.splitContainerPricing.ResumeLayout(false);
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabControlAdminOptions.ResumeLayout(false);
            this.tabPagePricing.ResumeLayout(false);
            this.groupBoxPricingVehicle.ResumeLayout(false);
            this.groupBoxPricingVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerPricing;
        private System.Windows.Forms.TabControl tabControlAdminOptions;
        private System.Windows.Forms.TabPage tabPagePricing;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox groupBoxPricingVehicle;
        private System.Windows.Forms.Button buttonVehiclePriceCancel;
        private System.Windows.Forms.Button buttonVehiclePriceSave;
        private System.Windows.Forms.TextBox textBoxVehiclePricePerHour;
        private System.Windows.Forms.Label labelVehiclePricePerHour;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label labelVehiclePriceStatus;
        private System.Windows.Forms.Button buttonPricingClose;
    }
}