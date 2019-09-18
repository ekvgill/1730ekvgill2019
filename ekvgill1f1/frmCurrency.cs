using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekvgill1f1
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;

            lblCurrency.Text = btnCanada.Text + ": ";
            txtRate.Text = "0.7566030";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();

        }

        private void BtnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;

            lblCurrency.Text = btnCanada.Text + ": ";
            txtRate.Text = "0.7566030";
            txtCurrency.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnEU_Click(object sender, EventArgs e)
        {
            btnEU.BackgroundImage = picEU.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;

            lblCurrency.Text = btnEU.Text + ": ";
            txtRate.Text = "1.10376";
            txtCurrency.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnMexico_Click(object sender, EventArgs e)
        {
            btnMexico.BackgroundImage = picMexico.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;

            lblCurrency.Text = btnMexico.Text + ": ";
            txtRate.Text = "0.0507102";
            txtCurrency.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnChina_Click(object sender, EventArgs e)
        {
            btnChina.BackgroundImage = picChina.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;

            lblCurrency.Text = btnChina.Text + ": ";
            txtRate.Text = "0.139926";
            txtCurrency.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
                Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");

        }

        /// <summary>
        /// automatically highlights text when cursor enters box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        /// <summary>
        /// button to add the converted currency total to the ongoing total; 
        /// label equation text prints its current value as well as the US dollars text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;

            txtTotalUSD.Text = ( 
                Convert.ToDecimal(txtTotalUSD.Text)
                + Convert.ToDecimal(txtUSDollars.Text)
                ).ToString("0.00");

            txtCurrency.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;

            lblCurrency.Text = btnCanada.Text + ": ";
            txtRate.Text = "0.7566030";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Text = "0.00";
            txtCurrency.Focus();
            lblEquation.Text = "";
        }
    }
}
