namespace Autogarage_Database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CarPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectedCarPriceLabel = new System.Windows.Forms.Label();
            this.SelectedCarDoorsLabel = new System.Windows.Forms.Label();
            this.SelectedCarColorLabel = new System.Windows.Forms.Label();
            this.SelectedCarLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CarSelector = new System.Windows.Forms.ComboBox();
            this.LocationSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModifyPictureBox = new System.Windows.Forms.PictureBox();
            this.PictureNameLabel = new System.Windows.Forms.Label();
            this.UploadPictureButton = new System.Windows.Forms.Button();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Locations = new System.Windows.Forms.Label();
            this.LocationsBox = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.DoorBox = new System.Windows.Forms.TextBox();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.BrandType_UpdateBox = new System.Windows.Forms.TextBox();
            this.carPreset_box = new System.Windows.Forms.ComboBox();
            this.Preset_Label = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.DeleteLocationButton = new System.Windows.Forms.Button();
            this.NewLocationBox = new System.Windows.Forms.TextBox();
            this.ExistingLocationsBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CarPictureBox);
            this.panel1.Controls.Add(this.SelectedCarPriceLabel);
            this.panel1.Controls.Add(this.SelectedCarDoorsLabel);
            this.panel1.Controls.Add(this.SelectedCarColorLabel);
            this.panel1.Controls.Add(this.SelectedCarLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CarSelector);
            this.panel1.Controls.Add(this.LocationSelector);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 253);
            this.panel1.TabIndex = 0;
            // 
            // CarPictureBox
            // 
            this.CarPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CarPictureBox.ErrorImage")));
            this.CarPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("CarPictureBox.InitialImage")));
            this.CarPictureBox.Location = new System.Drawing.Point(379, 3);
            this.CarPictureBox.Name = "CarPictureBox";
            this.CarPictureBox.Size = new System.Drawing.Size(393, 245);
            this.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPictureBox.TabIndex = 13;
            this.CarPictureBox.TabStop = false;
            // 
            // SelectedCarPriceLabel
            // 
            this.SelectedCarPriceLabel.AutoSize = true;
            this.SelectedCarPriceLabel.Location = new System.Drawing.Point(146, 158);
            this.SelectedCarPriceLabel.Name = "SelectedCarPriceLabel";
            this.SelectedCarPriceLabel.Size = new System.Drawing.Size(17, 15);
            this.SelectedCarPriceLabel.TabIndex = 12;
            this.SelectedCarPriceLabel.Text = "--";
            // 
            // SelectedCarDoorsLabel
            // 
            this.SelectedCarDoorsLabel.AutoSize = true;
            this.SelectedCarDoorsLabel.Location = new System.Drawing.Point(146, 134);
            this.SelectedCarDoorsLabel.Name = "SelectedCarDoorsLabel";
            this.SelectedCarDoorsLabel.Size = new System.Drawing.Size(17, 15);
            this.SelectedCarDoorsLabel.TabIndex = 11;
            this.SelectedCarDoorsLabel.Text = "--";
            // 
            // SelectedCarColorLabel
            // 
            this.SelectedCarColorLabel.AutoSize = true;
            this.SelectedCarColorLabel.Location = new System.Drawing.Point(146, 110);
            this.SelectedCarColorLabel.Name = "SelectedCarColorLabel";
            this.SelectedCarColorLabel.Size = new System.Drawing.Size(17, 15);
            this.SelectedCarColorLabel.TabIndex = 10;
            this.SelectedCarColorLabel.Text = "--";
            // 
            // SelectedCarLabel
            // 
            this.SelectedCarLabel.AutoSize = true;
            this.SelectedCarLabel.Location = new System.Drawing.Point(146, 86);
            this.SelectedCarLabel.Name = "SelectedCarLabel";
            this.SelectedCarLabel.Size = new System.Drawing.Size(17, 15);
            this.SelectedCarLabel.TabIndex = 9;
            this.SelectedCarLabel.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gem vraagprijs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vraagprijs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Aantal deuren:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kleur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Merk en type:";
            // 
            // CarSelector
            // 
            this.CarSelector.FormattingEnabled = true;
            this.CarSelector.Location = new System.Drawing.Point(146, 37);
            this.CarSelector.Name = "CarSelector";
            this.CarSelector.Size = new System.Drawing.Size(173, 23);
            this.CarSelector.TabIndex = 3;
            this.CarSelector.SelectedIndexChanged += new System.EventHandler(this.CarSelector_SelectedIndexChanged);
            // 
            // LocationSelector
            // 
            this.LocationSelector.FormattingEnabled = true;
            this.LocationSelector.Location = new System.Drawing.Point(146, 9);
            this.LocationSelector.Name = "LocationSelector";
            this.LocationSelector.Size = new System.Drawing.Size(173, 23);
            this.LocationSelector.TabIndex = 2;
            this.LocationSelector.SelectedIndexChanged += new System.EventHandler(this.LocationSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecteer een Auto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteer een locatie:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ModifyPictureBox);
            this.panel2.Controls.Add(this.PictureNameLabel);
            this.panel2.Controls.Add(this.UploadPictureButton);
            this.panel2.Controls.Add(this.PictureLabel);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.Locations);
            this.panel2.Controls.Add(this.LocationsBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.PriceBox);
            this.panel2.Controls.Add(this.DoorBox);
            this.panel2.Controls.Add(this.ColorBox);
            this.panel2.Controls.Add(this.BrandType_UpdateBox);
            this.panel2.Controls.Add(this.carPreset_box);
            this.panel2.Controls.Add(this.Preset_Label);
            this.panel2.Controls.Add(this.Save_Button);
            this.panel2.Controls.Add(this.Delete_Button);
            this.panel2.Controls.Add(this.Update_Button);
            this.panel2.Location = new System.Drawing.Point(12, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 350);
            this.panel2.TabIndex = 1;
            // 
            // ModifyPictureBox
            // 
            this.ModifyPictureBox.Location = new System.Drawing.Point(379, 3);
            this.ModifyPictureBox.Name = "ModifyPictureBox";
            this.ModifyPictureBox.Size = new System.Drawing.Size(393, 342);
            this.ModifyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModifyPictureBox.TabIndex = 19;
            this.ModifyPictureBox.TabStop = false;
            // 
            // PictureNameLabel
            // 
            this.PictureNameLabel.AutoSize = true;
            this.PictureNameLabel.Location = new System.Drawing.Point(227, 258);
            this.PictureNameLabel.Name = "PictureNameLabel";
            this.PictureNameLabel.Size = new System.Drawing.Size(17, 15);
            this.PictureNameLabel.TabIndex = 18;
            this.PictureNameLabel.Text = "--";
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Location = new System.Drawing.Point(146, 254);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(75, 23);
            this.UploadPictureButton.TabIndex = 17;
            this.UploadPictureButton.Text = "Upload";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            this.UploadPictureButton.Click += new System.EventHandler(this.UploadPictureButton_Click);
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PictureLabel.Location = new System.Drawing.Point(12, 258);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(92, 15);
            this.PictureLabel.TabIndex = 16;
            this.PictureLabel.Text = "Upload Picture:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(272, 11);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Locations
            // 
            this.Locations.AutoSize = true;
            this.Locations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Locations.Location = new System.Drawing.Point(12, 156);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(62, 15);
            this.Locations.TabIndex = 14;
            this.Locations.Text = "Locations:";
            // 
            // LocationsBox
            // 
            this.LocationsBox.FormattingEnabled = true;
            this.LocationsBox.Location = new System.Drawing.Point(146, 156);
            this.LocationsBox.Name = "LocationsBox";
            this.LocationsBox.Size = new System.Drawing.Size(120, 94);
            this.LocationsBox.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Vraagprijs:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Aantal Deuren:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Kleur:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Merk en Type:";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(146, 127);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(201, 23);
            this.PriceBox.TabIndex = 8;
            // 
            // DoorBox
            // 
            this.DoorBox.Location = new System.Drawing.Point(146, 98);
            this.DoorBox.Name = "DoorBox";
            this.DoorBox.Size = new System.Drawing.Size(201, 23);
            this.DoorBox.TabIndex = 7;
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(146, 69);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(201, 23);
            this.ColorBox.TabIndex = 6;
            // 
            // BrandType_UpdateBox
            // 
            this.BrandType_UpdateBox.Location = new System.Drawing.Point(146, 40);
            this.BrandType_UpdateBox.Name = "BrandType_UpdateBox";
            this.BrandType_UpdateBox.Size = new System.Drawing.Size(201, 23);
            this.BrandType_UpdateBox.TabIndex = 5;
            // 
            // carPreset_box
            // 
            this.carPreset_box.FormattingEnabled = true;
            this.carPreset_box.Location = new System.Drawing.Point(146, 11);
            this.carPreset_box.Name = "carPreset_box";
            this.carPreset_box.Size = new System.Drawing.Size(120, 23);
            this.carPreset_box.TabIndex = 4;
            this.carPreset_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Preset_Label
            // 
            this.Preset_Label.AutoSize = true;
            this.Preset_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Preset_Label.Location = new System.Drawing.Point(12, 14);
            this.Preset_Label.Name = "Preset_Label";
            this.Preset_Label.Size = new System.Drawing.Size(75, 15);
            this.Preset_Label.TabIndex = 3;
            this.Preset_Label.Text = "Load Preset:";
            this.Preset_Label.Click += new System.EventHandler(this.label8_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(255, 324);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(117, 23);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(133, 324);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(116, 23);
            this.Delete_Button.TabIndex = 1;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(3, 324);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(124, 23);
            this.Update_Button.TabIndex = 0;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AddLocationButton);
            this.panel3.Controls.Add(this.DeleteLocationButton);
            this.panel3.Controls.Add(this.NewLocationBox);
            this.panel3.Controls.Add(this.ExistingLocationsBox);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(795, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 253);
            this.panel3.TabIndex = 2;
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Location = new System.Drawing.Point(259, 33);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(75, 23);
            this.AddLocationButton.TabIndex = 5;
            this.AddLocationButton.Text = "Toevoegen";
            this.AddLocationButton.UseVisualStyleBackColor = true;
            this.AddLocationButton.Click += new System.EventHandler(this.AddLocationButton_Click);
            // 
            // DeleteLocationButton
            // 
            this.DeleteLocationButton.Location = new System.Drawing.Point(259, 3);
            this.DeleteLocationButton.Name = "DeleteLocationButton";
            this.DeleteLocationButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteLocationButton.TabIndex = 4;
            this.DeleteLocationButton.Text = "Delete";
            this.DeleteLocationButton.UseVisualStyleBackColor = true;
            this.DeleteLocationButton.Click += new System.EventHandler(this.DeleteLocationButton_Click);
            // 
            // NewLocationBox
            // 
            this.NewLocationBox.Location = new System.Drawing.Point(132, 34);
            this.NewLocationBox.Name = "NewLocationBox";
            this.NewLocationBox.Size = new System.Drawing.Size(121, 23);
            this.NewLocationBox.TabIndex = 3;
            // 
            // ExistingLocationsBox
            // 
            this.ExistingLocationsBox.FormattingEnabled = true;
            this.ExistingLocationsBox.Location = new System.Drawing.Point(132, 4);
            this.ExistingLocationsBox.Name = "ExistingLocationsBox";
            this.ExistingLocationsBox.Size = new System.Drawing.Size(121, 23);
            this.ExistingLocationsBox.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(13, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nieuwe locatie:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(13, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Bestaande locaties:";
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.DebugLabel.ForeColor = System.Drawing.Color.Red;
            this.DebugLabel.Location = new System.Drawing.Point(849, 345);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(208, 45);
            this.DebugLabel.TabIndex = 3;
            this.DebugLabel.Text = "Debug Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 633);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox CarSelector;
        private ComboBox LocationSelector;
        private Label label2;
        private Label SelectedCarPriceLabel;
        private Label SelectedCarDoorsLabel;
        private Label SelectedCarColorLabel;
        private Label SelectedCarLabel;
        private Panel panel2;
        private Label Preset_Label;
        private Button Save_Button;
        private Button Delete_Button;
        private Button Update_Button;
        private ComboBox carPreset_box;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox PriceBox;
        private TextBox DoorBox;
        private TextBox ColorBox;
        private TextBox BrandType_UpdateBox;
        private Label Locations;
        private CheckedListBox LocationsBox;
        private PictureBox CarPictureBox;
        private Label PictureNameLabel;
        private Button UploadPictureButton;
        private Label PictureLabel;
        private Button ClearButton;
        private PictureBox ModifyPictureBox;
        private Panel panel3;
        private Button AddLocationButton;
        private Button DeleteLocationButton;
        private TextBox NewLocationBox;
        private ComboBox ExistingLocationsBox;
        private Label label13;
        private Label label12;
        private Label DebugLabel;
    }
}