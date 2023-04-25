using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejodeCadenas_Aliaga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPalabra1_TextChanged(object sender, EventArgs e)
        {
            string caracteres = txtPalabra1.Text;
            int longitud = caracteres.Length;
            lblLenght.Text = longitud.ToString();
        }

        private void txtPalabra2_TextChanged(object sender, EventArgs e)
        {
            string caracteres = txtPalabra2.Text;
            int longitud = caracteres.Length;
            lblLenght2.Text = longitud.ToString();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpFecha.Value.ToUniversalTime();
            string B;
            B = dateTime.ToString("dd/MM/yyyy");
            txtConversion.Text = B;
        }

        private void btnConvertir2_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpFecha.Value.ToUniversalTime();
            string B;
            B = dateTime.ToString("HH:mm");
            txtConversion.Text = B;
        }

        private void btnConvertir3_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpFecha.Value.ToUniversalTime();
            string B;
            B = dateTime.ToString("D");
            txtConversion.Text = B;
        }
    }
}
