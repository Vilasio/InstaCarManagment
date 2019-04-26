namespace InstaCarManagement.GUI
{
    partial class FormImages
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
            this.flowLayoutPanelImages = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxImages = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.splitContainerImages = new System.Windows.Forms.SplitContainer();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.labelTopic = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImages)).BeginInit();
            this.splitContainerImages.Panel1.SuspendLayout();
            this.splitContainerImages.Panel2.SuspendLayout();
            this.splitContainerImages.SuspendLayout();
            this.groupBoxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelImages
            // 
            this.flowLayoutPanelImages.AutoScroll = true;
            this.flowLayoutPanelImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelImages.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelImages.Location = new System.Drawing.Point(206, 0);
            this.flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            this.flowLayoutPanelImages.Size = new System.Drawing.Size(430, 526);
            this.flowLayoutPanelImages.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 50);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Hinzufügen";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(6, 465);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 50);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(11, 356);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status";
            this.labelStatus.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(6, 237);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 50);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Markierte Löschen";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxImages
            // 
            this.groupBoxImages.Controls.Add(this.buttonCancel);
            this.groupBoxImages.Controls.Add(this.buttonAdd);
            this.groupBoxImages.Controls.Add(this.labelStatus);
            this.groupBoxImages.Controls.Add(this.buttonDelete);
            this.groupBoxImages.Controls.Add(this.buttonSave);
            this.groupBoxImages.Location = new System.Drawing.Point(0, 0);
            this.groupBoxImages.Name = "groupBoxImages";
            this.groupBoxImages.Size = new System.Drawing.Size(200, 521);
            this.groupBoxImages.TabIndex = 5;
            this.groupBoxImages.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(125, 465);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 50);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // splitContainerImages
            // 
            this.splitContainerImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerImages.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerImages.IsSplitterFixed = true;
            this.splitContainerImages.Location = new System.Drawing.Point(0, 0);
            this.splitContainerImages.Name = "splitContainerImages";
            this.splitContainerImages.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerImages.Panel1
            // 
            this.splitContainerImages.Panel1.Controls.Add(this.groupBoxHeader);
            // 
            // splitContainerImages.Panel2
            // 
            this.splitContainerImages.Panel2.Controls.Add(this.flowLayoutPanelImages);
            this.splitContainerImages.Panel2.Controls.Add(this.groupBoxImages);
            this.splitContainerImages.Size = new System.Drawing.Size(636, 635);
            this.splitContainerImages.SplitterDistance = 105;
            this.splitContainerImages.TabIndex = 6;
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
            this.groupBoxHeader.Size = new System.Drawing.Size(636, 500);
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
            this.labelTopic.Size = new System.Drawing.Size(116, 49);
            this.labelTopic.TabIndex = 2;
            this.labelTopic.Text = "Bilder";
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
            // FormImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 635);
            this.Controls.Add(this.splitContainerImages);
            this.Name = "FormImages";
            this.Text = "Bilder hinzufügen/löschen";
            this.Load += new System.EventHandler(this.FormImages_Load);
            this.groupBoxImages.ResumeLayout(false);
            this.groupBoxImages.PerformLayout();
            this.splitContainerImages.Panel1.ResumeLayout(false);
            this.splitContainerImages.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImages)).EndInit();
            this.splitContainerImages.ResumeLayout(false);
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImages;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxImages;
        private System.Windows.Forms.SplitContainer splitContainerImages;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonCancel;
    }
}