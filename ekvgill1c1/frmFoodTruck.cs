using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekvgill1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtHotdogsSubtotal.Text = (
               4.0m * Convert.ToDecimal(txtHotdogs.Text)
               ).ToString("0.00");

            txtHamburgersSubtotal.Text = (
               5.0m * Convert.ToDecimal(txtHamburgers.Text)
               ).ToString("0.00");

            txtPretaxtotal.Text = (
                Convert.ToDecimal(txtHotdogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
                ).ToString("0.00");

            txtTax.Text = (
                .06875m * Convert.ToDecimal(txtPretaxtotal.Text)
                ).ToString("0.00");

            txtTotal.Text = (
               Convert.ToDecimal(txtPretaxtotal.Text) + Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");

            btnClear.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtHotdogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotdogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotdogs.Focus();
        }
    }
}
