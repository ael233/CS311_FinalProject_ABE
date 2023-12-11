namespace CS311_FinalProject_ABE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDescription = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rdbOuncesToGrams = new System.Windows.Forms.RadioButton();
            this.rdbPoundsToKilograms = new System.Windows.Forms.RadioButton();
            this.rdbFahrenheitToCelsius = new System.Windows.Forms.RadioButton();
            this.rdbMilesToKilometers = new System.Windows.Forms.RadioButton();
            this.rdbFeetToMeters = new System.Windows.Forms.RadioButton();
            this.rdbGramsToOunces = new System.Windows.Forms.RadioButton();
            this.rdbKilogramToPounds = new System.Windows.Forms.RadioButton();
            this.rdbCelsiusToFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdbKilometersToMiles = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMetersToFeet = new System.Windows.Forms.RadioButton();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblResultLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(61, 103);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(329, 144);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rdbOuncesToGrams);
            this.gb1.Controls.Add(this.rdbPoundsToKilograms);
            this.gb1.Controls.Add(this.rdbFahrenheitToCelsius);
            this.gb1.Controls.Add(this.rdbMilesToKilometers);
            this.gb1.Controls.Add(this.rdbFeetToMeters);
            this.gb1.Controls.Add(this.rdbGramsToOunces);
            this.gb1.Controls.Add(this.rdbKilogramToPounds);
            this.gb1.Controls.Add(this.rdbCelsiusToFahrenheit);
            this.gb1.Controls.Add(this.rdbKilometersToMiles);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.rdbMetersToFeet);
            this.gb1.Location = new System.Drawing.Point(64, 343);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(327, 284);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Enter += new System.EventHandler(this.gb1_Enter);
            // 
            // rdbOuncesToGrams
            // 
            this.rdbOuncesToGrams.AutoSize = true;
            this.rdbOuncesToGrams.Location = new System.Drawing.Point(178, 238);
            this.rdbOuncesToGrams.Name = "rdbOuncesToGrams";
            this.rdbOuncesToGrams.Size = new System.Drawing.Size(107, 17);
            this.rdbOuncesToGrams.TabIndex = 10;
            this.rdbOuncesToGrams.TabStop = true;
            this.rdbOuncesToGrams.Text = "Ounces to Grams";
            this.rdbOuncesToGrams.UseVisualStyleBackColor = true;
            this.rdbOuncesToGrams.CheckedChanged += new System.EventHandler(this.rdbOuncesToGrams_CheckedChanged);
            // 
            // rdbPoundsToKilograms
            // 
            this.rdbPoundsToKilograms.AutoSize = true;
            this.rdbPoundsToKilograms.Location = new System.Drawing.Point(178, 201);
            this.rdbPoundsToKilograms.Name = "rdbPoundsToKilograms";
            this.rdbPoundsToKilograms.Size = new System.Drawing.Size(121, 17);
            this.rdbPoundsToKilograms.TabIndex = 9;
            this.rdbPoundsToKilograms.TabStop = true;
            this.rdbPoundsToKilograms.Text = "Pounds to Kilograms";
            this.rdbPoundsToKilograms.UseVisualStyleBackColor = true;
            this.rdbPoundsToKilograms.CheckedChanged += new System.EventHandler(this.rdbPoundsToKilograms_CheckedChanged);
            // 
            // rdbFahrenheitToCelsius
            // 
            this.rdbFahrenheitToCelsius.AutoSize = true;
            this.rdbFahrenheitToCelsius.Location = new System.Drawing.Point(178, 165);
            this.rdbFahrenheitToCelsius.Name = "rdbFahrenheitToCelsius";
            this.rdbFahrenheitToCelsius.Size = new System.Drawing.Size(123, 17);
            this.rdbFahrenheitToCelsius.TabIndex = 8;
            this.rdbFahrenheitToCelsius.TabStop = true;
            this.rdbFahrenheitToCelsius.Text = "Fahrenheit to Celsius";
            this.rdbFahrenheitToCelsius.UseVisualStyleBackColor = true;
            this.rdbFahrenheitToCelsius.CheckedChanged += new System.EventHandler(this.rdbFahrenheitToCelsius_CheckedChanged);
            // 
            // rdbMilesToKilometers
            // 
            this.rdbMilesToKilometers.AutoSize = true;
            this.rdbMilesToKilometers.Location = new System.Drawing.Point(178, 128);
            this.rdbMilesToKilometers.Name = "rdbMilesToKilometers";
            this.rdbMilesToKilometers.Size = new System.Drawing.Size(112, 17);
            this.rdbMilesToKilometers.TabIndex = 7;
            this.rdbMilesToKilometers.TabStop = true;
            this.rdbMilesToKilometers.Text = "Miles to Kilometers";
            this.rdbMilesToKilometers.UseVisualStyleBackColor = true;
            this.rdbMilesToKilometers.CheckedChanged += new System.EventHandler(this.rdbMilesToKilometers_CheckedChanged);
            // 
            // rdbFeetToMeters
            // 
            this.rdbFeetToMeters.AutoSize = true;
            this.rdbFeetToMeters.Location = new System.Drawing.Point(178, 94);
            this.rdbFeetToMeters.Name = "rdbFeetToMeters";
            this.rdbFeetToMeters.Size = new System.Drawing.Size(93, 17);
            this.rdbFeetToMeters.TabIndex = 6;
            this.rdbFeetToMeters.TabStop = true;
            this.rdbFeetToMeters.Text = "Feet to Meters";
            this.rdbFeetToMeters.UseVisualStyleBackColor = true;
            this.rdbFeetToMeters.CheckedChanged += new System.EventHandler(this.rdbFeetToMeters_CheckedChanged);
            // 
            // rdbGramsToOunces
            // 
            this.rdbGramsToOunces.AutoSize = true;
            this.rdbGramsToOunces.Location = new System.Drawing.Point(23, 238);
            this.rdbGramsToOunces.Name = "rdbGramsToOunces";
            this.rdbGramsToOunces.Size = new System.Drawing.Size(107, 17);
            this.rdbGramsToOunces.TabIndex = 5;
            this.rdbGramsToOunces.TabStop = true;
            this.rdbGramsToOunces.Text = "Grams to Ounces";
            this.rdbGramsToOunces.UseVisualStyleBackColor = true;
            this.rdbGramsToOunces.CheckedChanged += new System.EventHandler(this.rdbGramsToOunces_CheckedChanged);
            // 
            // rdbKilogramToPounds
            // 
            this.rdbKilogramToPounds.AutoSize = true;
            this.rdbKilogramToPounds.Location = new System.Drawing.Point(23, 201);
            this.rdbKilogramToPounds.Name = "rdbKilogramToPounds";
            this.rdbKilogramToPounds.Size = new System.Drawing.Size(121, 17);
            this.rdbKilogramToPounds.TabIndex = 4;
            this.rdbKilogramToPounds.TabStop = true;
            this.rdbKilogramToPounds.Text = "Kilograms to Pounds\r\n";
            this.rdbKilogramToPounds.UseVisualStyleBackColor = true;
            this.rdbKilogramToPounds.CheckedChanged += new System.EventHandler(this.rdbKilogramToPounds_CheckedChanged);
            // 
            // rdbCelsiusToFahrenheit
            // 
            this.rdbCelsiusToFahrenheit.AutoSize = true;
            this.rdbCelsiusToFahrenheit.Location = new System.Drawing.Point(23, 165);
            this.rdbCelsiusToFahrenheit.Name = "rdbCelsiusToFahrenheit";
            this.rdbCelsiusToFahrenheit.Size = new System.Drawing.Size(123, 17);
            this.rdbCelsiusToFahrenheit.TabIndex = 3;
            this.rdbCelsiusToFahrenheit.TabStop = true;
            this.rdbCelsiusToFahrenheit.Text = "Celsius to Fahrenheit";
            this.rdbCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            this.rdbCelsiusToFahrenheit.CheckedChanged += new System.EventHandler(this.rdbCelsiusToFahrenheit_CheckedChanged);
            // 
            // rdbKilometersToMiles
            // 
            this.rdbKilometersToMiles.AutoSize = true;
            this.rdbKilometersToMiles.Location = new System.Drawing.Point(23, 128);
            this.rdbKilometersToMiles.Name = "rdbKilometersToMiles";
            this.rdbKilometersToMiles.Size = new System.Drawing.Size(112, 17);
            this.rdbKilometersToMiles.TabIndex = 2;
            this.rdbKilometersToMiles.TabStop = true;
            this.rdbKilometersToMiles.Text = "Kilometers to Miles\r\n";
            this.rdbKilometersToMiles.UseVisualStyleBackColor = true;
            this.rdbKilometersToMiles.CheckedChanged += new System.EventHandler(this.rdbKilomsToMiles_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "What type of conversion \r\nwould you like to tackle?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rdbMetersToFeet
            // 
            this.rdbMetersToFeet.AutoSize = true;
            this.rdbMetersToFeet.Location = new System.Drawing.Point(23, 94);
            this.rdbMetersToFeet.Name = "rdbMetersToFeet";
            this.rdbMetersToFeet.Size = new System.Drawing.Size(93, 17);
            this.rdbMetersToFeet.TabIndex = 0;
            this.rdbMetersToFeet.TabStop = true;
            this.rdbMetersToFeet.Text = "Meters to Feet";
            this.rdbMetersToFeet.UseVisualStyleBackColor = true;
            this.rdbMetersToFeet.CheckedChanged += new System.EventHandler(this.rdbMetersToFeet_CheckedChanged);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(258, 653);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(132, 20);
            this.txtValue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input the value you\'d like to convert \r\nfrom the first unit to the second.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConvert.Location = new System.Drawing.Point(141, 699);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(137, 57);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Initialize the \r\nConvert-O-Matic!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(194, 784);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(64, 270);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(278, 52);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(60, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 42);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Convert-O-Matic";
            // 
            // lblResultLabel
            // 
            this.lblResultLabel.AutoSize = true;
            this.lblResultLabel.Location = new System.Drawing.Point(138, 784);
            this.lblResultLabel.Name = "lblResultLabel";
            this.lblResultLabel.Size = new System.Drawing.Size(40, 13);
            this.lblResultLabel.TabIndex = 8;
            this.lblResultLabel.Text = "Result:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CS311_FinalProject_ABE.Properties.Resources.ruler_PNG78;
            this.pictureBox1.Location = new System.Drawing.Point(246, -72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(449, 832);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultLabel);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.gb1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Convert-O-Matic";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rdbCelsiusToFahrenheit;
        private System.Windows.Forms.RadioButton rdbKilometersToMiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMetersToFeet;
        private System.Windows.Forms.RadioButton rdbGramsToOunces;
        private System.Windows.Forms.RadioButton rdbKilogramToPounds;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rdbOuncesToGrams;
        private System.Windows.Forms.RadioButton rdbPoundsToKilograms;
        private System.Windows.Forms.RadioButton rdbFahrenheitToCelsius;
        private System.Windows.Forms.RadioButton rdbMilesToKilometers;
        private System.Windows.Forms.RadioButton rdbFeetToMeters;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResultLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

