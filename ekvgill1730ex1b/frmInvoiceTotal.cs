using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekvgill1730ex1b
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
         
            txtDiscountamount.Text = 
                (Convert.ToDecimal(txtSubtotal.Text) 
                * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");

            txtTotal.Text =
                  (Convert.ToDecimal(txtSubtotal.Text)
                  - Convert.ToDecimal(txtDiscountamount.Text)).ToString("0.00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
