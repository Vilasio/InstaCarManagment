namespace InstaCarManagement.GUI
{
    partial class ImageUS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.checkBoxMainImage = new System.Windows.Forms.CheckBox();
            this.checkBoxOfficial = new System.Windows.Forms.CheckBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDragAndDrop = new System.Windows.Forms.Label();
            this.checkBoxAccident = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxImage_DragDrop);
            this.pictureBoxImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxImage_DragEnter);
            // 
            // checkBoxMainImage
            // 
            this.checkBoxMainImage.AutoSize = true;
            this.checkBoxMainImage.Location = new System.Drawing.Point(3, 130);
            this.checkBoxMainImage.Name = "checkBoxMainImage";
            this.checkBoxMainImage.Size = new System.Drawing.Size(71, 17);
            this.checkBoxMainImage.TabIndex = 1;
            this.checkBoxMainImage.Text = "Hauptbild";
            this.checkBoxMainImage.UseVisualStyleBackColor = true;
            this.checkBoxMainImage.CheckedChanged += new System.EventHandler(this.checkBoxMainImage_CheckedChanged);
            // 
            // checkBoxOfficial
            // 
            this.checkBoxOfficial.AutoSize = true;
            this.checkBoxOfficial.Location = new System.Drawing.Point(80, 130);
            this.checkBoxOfficial.Name = "checkBoxOfficial";
            this.checkBoxOfficial.Size = new System.Drawing.Size(127, 17);
            this.checkBoxOfficial.TabIndex = 2;
            this.checkBoxOfficial.Text = "Für Kunden anzeigen";
            this.checkBoxOfficial.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(109, 22);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(274, 87);
            this.textBoxDescription.TabIndex = 0;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(109, 6);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(118, 13);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Beschreibung (optional)";
            // 
            // labelDragAndDrop
            // 
            this.labelDragAndDrop.AutoSize = true;
            this.labelDragAndDrop.Location = new System.Drawing.Point(3, 106);
            this.labelDragAndDrop.Name = "labelDragAndDrop";
            this.labelDragAndDrop.Size = new System.Drawing.Size(77, 13);
            this.labelDragAndDrop.TabIndex = 6;
            this.labelDragAndDrop.Text = "Drag and Drop";
            // 
            // checkBoxAccident
            // 
            this.checkBoxAccident.AutoSize = true;
            this.checkBoxAccident.Location = new System.Drawing.Point(342, 130);
            this.checkBoxAccident.Name = "checkBoxAccident";
            this.checkBoxAccident.Size = new System.Drawing.Size(53, 17);
            this.checkBoxAccident.TabIndex = 7;
            this.checkBoxAccident.Text = "Unfall";
            this.checkBoxAccident.UseVisualStyleBackColor = true;
            this.checkBoxAccident.CheckedChanged += new System.EventHandler(this.checkBoxAccident_CheckedChanged);
            // 
            // ImageUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.checkBoxAccident);
            this.Controls.Add(this.labelDragAndDrop);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxOfficial);
            this.Controls.Add(this.checkBoxMainImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Name = "ImageUS";
            this.Size = new System.Drawing.Size(398, 148);
            this.Load += new System.EventHandler(this.ImageUS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.CheckBox checkBoxMainImage;
        private System.Windows.Forms.CheckBox checkBoxOfficial;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDragAndDrop;
        private System.Windows.Forms.CheckBox checkBoxAccident;
    }
}
