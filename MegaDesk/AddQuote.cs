using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            // Populate ComboBox with material options
            comboBoxMaterials.Items.Add("Oak - $200");
            comboBoxMaterials.Items.Add("Laminate - $100");
            comboBoxMaterials.Items.Add("Pine - $50");
            comboBoxMaterials.Items.Add("Rosewood - $300");
            comboBoxMaterials.Items.Add("Veneer - $125");

            // Wire up the SelectedIndexChanged event
            comboBoxMaterials.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Define base desk price
            int basePrice = 200;
            int materialPrice = 0;

            // Get the selected material
            string selectedMaterial = comboBoxMaterials.SelectedItem.ToString();

            // Determine material price based on selection
            switch (selectedMaterial)
            {
                case "Oak - $200":
                    materialPrice = 200;
                    break;
                case "Laminate - $100":
                    materialPrice = 100;
                    break;
                case "Pine - $50":
                    materialPrice = 50;
                    break;
                case "Rosewood - $300":
                    materialPrice = 300;
                    break;
                case "Veneer - $125":
                    materialPrice = 125;
                    break;
                default:
                    materialPrice = 0;
                    break;
            }

            // Calculate the total price (Base price + material price)
            int totalPrice = basePrice + materialPrice;

            // Display the total in a label or textbox
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Define base desk price
            int basePrice = 200;
            int materialPrice = 0;

            // Get the selected material
            string selectedMaterial = comboBoxMaterials.SelectedItem.ToString();

            // Determine material price based on selection
            switch (selectedMaterial)
            {
                case "Width - 48":
                    materialPrice = 125;
                    break;
                default:
                    materialPrice = 0;
                    break;
            }

            // Calculate the total price (Base price + material price)
            int totalPrice = basePrice + materialPrice;
        }
    }
}
