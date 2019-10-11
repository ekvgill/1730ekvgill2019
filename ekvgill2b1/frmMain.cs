using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekvgill2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountCanada = Convert.ToDecimal(txtAmountCanada.Text);
            decimal rateCanada = 0.7566030m;
            decimal usdCanada = amountCanada * rateCanada;

            txtUSDCanada.Text = usdCanada.ToString("0.00");

            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal rateEuro = 1.10376m;
            decimal usdEuro = amountEuro * rateEuro;

            txtUSDEuro.Text = usdEuro.ToString("0.00");

            decimal amountChina = Convert.ToDecimal(txtAmountChina.Text);
            decimal rateChina = 0.139926m;
            decimal usdChina = amountChina * rateChina;

            txtUSDChina.Text = usdChina.ToString("0.00");

            decimal amountMexico = Convert.ToDecimal(txtAmountMexico.Text);
            decimal rateMexico = 0.0507102m;
            decimal usdMexico = amountMexico * rateMexico;

            txtUSDMexico.Text = usdMexico.ToString("0.00");

            decimal totalUSD = usdCanada + usdEuro + usdChina + usdMexico;

            txtUSDTotal.Text = totalUSD.ToString("0.00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
    
}
