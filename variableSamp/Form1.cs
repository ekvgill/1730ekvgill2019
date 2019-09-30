using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variableSamp
{
    public partial class variableSamp : Form
    {
        public variableSamp()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //txtHotdogsSubtotal.Text = (
            // 4.0m * Convert.ToDecimal(txtHotdogs.Text)
            // ).ToString("0.00");

            int Hotdogs = Convert.ToInt32(txtHotdogs.Text);
            decimal HotdogPrice = 4.0m;
            decimal HotdogSubtotal = Hotdogs * HotdogPrice;
            txtHotdogsSubtotal.Text = HotdogSubtotal.ToString("0.00");

            //txtHamburgersSubtotal.Text = (
            //   5.0m * Convert.ToDecimal(txtHamburgers.Text)
            //   ).ToString("0.00");

            int Hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal HamburgerPrice = 5.0m;
            decimal HamburgerSubtotal = Hamburgers * HamburgerPrice;
            txtHamburgersSubtotal.Text = HamburgerSubtotal.ToString("0.00");


            //txtPretaxtotal.Text = (
            //    Convert.ToDecimal(txtHotdogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
            //    ).ToString("0.00");

            decimal Pretaxtotal = HotdogSubtotal + HamburgerSubtotal;
            txtPretaxtotal.Text = Pretaxtotal.ToString("0.00");

            //txtTax.Text = (
            //    .06875m * Convert.ToDecimal(txtPretaxtotal.Text)
            //    ).ToString("0.00");

            decimal Tax = .06875m * Pretaxtotal;
            txtTax.Text = Tax.ToString("0.00");

            //txtTotal.Text = (
            //   Convert.ToDecimal(txtPretaxtotal.Text) + Convert.ToDecimal(txtTax.Text)
            //    ).ToString("0.00");

            decimal Total = Pretaxtotal + Tax;
            txtTotal.Text = Total.ToString("0.00");

            btnClear.Focus();
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
