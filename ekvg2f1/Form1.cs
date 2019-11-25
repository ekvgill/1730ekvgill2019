using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekvg2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            // #1 if
          
            result1TextBox.Text = Ex2fCalculations.Calc01(input1aTextBox.Text);

            // #2 if {block}
        
            result2TextBox.Text = Ex2fCalculations.Calc02(input2aTextBox.Text);

            // #3 if else
        
            result3TextBox.Text = Ex2fCalculations.Calc03(input3aTextBox.Text);

            // #4 if else if
            
            result4TextBox.Text = Ex2fCalculations.Calc04(input4aTextBox.Text);

            // #5 Better range test
            
            result5TextBox.Text = Ex2fCalculations.Calc05(input5aTextBox.Text);

            // #6 nested if statements
           
            result6TextBox.Text = Ex2fCalculations.Calc06(input6aTextBox.Text, input6bTextBox.Text);



        }
    }
}
