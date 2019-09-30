using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekvgill2a1
{
    public partial class frmMain1 : Form
    {
        public frmMain1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            //txtDiscountamount.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");

            //txtTotal.Text =
            //      (Convert.ToDecimal(txtSubtotal.Text)
            //      - Convert.ToDecimal(txtDiscountamount.Text)).ToString("0.00");

            decimal Subtotal = Convert.ToInt32(txtSubtotal.Text);
            decimal DiscountPercent = Convert.ToInt32(txtDiscountPercent.Text);
            decimal Discountamount = (Subtotal * DiscountPercent) / 100;
            decimal Total = Subtotal - Discountamount;

            txtDiscountamount.Text = Discountamount.ToString("0.00");
            txtTotal.Text = Total.ToString("0.00");

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
