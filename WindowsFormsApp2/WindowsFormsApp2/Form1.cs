using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float farenheit = float.Parse(txtFarenheit.Text);
                float celsius = (farenheit - 32) * 5f / 9;
                txtCelsius.Text = celsius.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en Fahrenheit.");
            }
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            try
            {
                float celsius = float.Parse(txtCelsius.Text);
                float farenheit = (celsius * 9 / 5f) + 32;
                txtFarenheit.Text = farenheit.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en Celsius.");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtFarenheit.Text = "0.0";
            txtCelsius.Text = "0.0";
            MessageBox.Show("Reset de valores");
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}