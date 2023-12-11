using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_FinalProject_ABE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void rdbFahrenheitToCelsius_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdbMetersToFeet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double input;
            bool isNumeric = double.TryParse(txtValue.Text, out input);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            double result = 0.0;
            if (rdbMetersToFeet.Checked)
            {
                result = ConvertMetersToFeet(input);
            }
            else if(rdbFeetToMeters.Checked)
            {
                result = ConvertFeetToMeters(input);
            }
            else if (rdbKilometersToMiles.Checked)
            {
                result = ConvertKilometersToMiles(input);
            }
            else if (rdbMilesToKilometers.Checked)
            {
                result = ConvertMilesToKilometers(input);
            }
            else if (rdbCelsiusToFahrenheit.Checked)
            {
                result = ConvertCelsiusToFahrenheit(input);
            }
            else if (rdbFahrenheitToCelsius.Checked)
            {
                result = ConvertFahrenheitToCelsius(input);
            }
            else if (rdbKilogramToPounds.Checked)
            {
                result = ConvertKilogramsToPounds(input);
            }
            else if (rdbPoundsToKilograms.Checked)
            {
                result = ConvertPoundsToKilograms(input);
            }
            else if (rdbGramsToOunces.Checked)
            {
                result = ConvertGramsToOunces(input);
            }
            else if (rdbOuncesToGrams.Checked)
            {
                result = ConvertOuncesToGrams(input);
            }

            lblResult.Text = result.ToString();
        }

        private void rdbFeetToMeters_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbKilomsToMiles_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbMilesToKilometers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbCelsiusToFahrenheit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbKilogramToPounds_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbPoundsToKilograms_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbGramsToOunces_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbOuncesToGrams_CheckedChanged(object sender, EventArgs e)
        {

        }

        private double ConvertMetersToFeet(double input)
        {
            return input * 3.28084;
        }

        private double ConvertFeetToMeters(double input)
        {
            return input * 0.3048;
        }

        private double ConvertKilometersToMiles(double input)
        {
            return input * 0.621371;
        }

        private double ConvertMilesToKilometers(double input)
        {
            return input * 1.60934;
        }

        private double ConvertCelsiusToFahrenheit(double input)
        {
            return ((input * 1.8) + 32);
        }

        private double ConvertFahrenheitToCelsius(double input)
        {
            return ((input - 32) * (5 / 9));        
        }

        private double ConvertKilogramsToPounds(double input)
        {
            return input * 2.20462;
        }

        private double ConvertPoundsToKilograms(double input)
        {
            return input * 0.453592;
        }

        private double ConvertGramsToOunces(double input)
        {
            return input * 0.035274;
        }

        private double ConvertOuncesToGrams(double input)
        {
            return input * 28.3495;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
