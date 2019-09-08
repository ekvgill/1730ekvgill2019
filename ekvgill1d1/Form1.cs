using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekvgill1d1
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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountCanada.Text = "0.00";
            txtRateCanada.Text = "0.7566030";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.10376";
            txtAmountChina.Text = "0.00";
            txtRateChina.Text = "0.139926";
            txtAmountMexico.Text = "0.00";
            txtRateMexico.Text = "0.0507102";
            txtUSDTotal.Text = "";

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void canadaTextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (
                Convert.ToDecimal(txtAmountCanada.Text) 
                * Convert.ToDecimal(txtRateCanada.Text)
                ).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
               Convert.ToDecimal(txtAmountEuro.Text)
                * Convert.ToDecimal(txtRateEuro.Text)
                ).ToString("0.00");
        }

        private void chinaTextChanged(object sender, EventArgs e)
        {
            txtUSDChina.Text = (
                Convert.ToDecimal(txtAmountChina.Text)
                * Convert.ToDecimal(txtRateChina.Text)
                ).ToString("0.00");
        }

        private void mexicoTextChanged(object sender, EventArgs e)
        {
            txtUSDMexico.Text = (
                Convert.ToDecimal(txtAmountMexico.Text)
                * Convert.ToDecimal(txtRateMexico.Text)
                ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtUSDTotal.Text = (
                Convert.ToDecimal(txtUSDCanada.Text)
                + Convert.ToDecimal(txtUSDEuro.Text)
                + Convert.ToDecimal(txtUSDChina.Text)
                + Convert.ToDecimal(txtUSDMexico.Text)
                ).ToString("0.00");
        }
    }
}
