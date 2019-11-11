using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekvgill2d2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "Frank";
            textBox2input.Text = "";
            textBox3input.Text = "2.3";
            textBox4input.Text = "false";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "2";
            textBox6input.Text = "xyz";
            textBox7input.Text = "1";
            textBox8inputA.Text = "1";
            textBox8inputB.Text = "2";
            textBox9input.Text = "500";
            textBox10inputA.Text = "3";
            textBox10inputB.Text = "3";
        }

        private void SetFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "xyz";
            textBox2input.Text = "xyz";
            textBox3input.Text = "2.4";
            textBox4input.Text = "true";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "3";
            textBox6input.Text = "Jones";
            textBox7input.Text = "-1";
            textBox8inputA.Text = "2";
            textBox8inputB.Text = "1";
            textBox9input.Text = "499";
            textBox10inputA.Text = "4";
            textBox10inputB.Text = "3";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "Fail";
            textBox2ResultA.Text = "Fail";
            textBox3ResultA.Text = "Fail";
            textBox4ResultA.Text = "Fail";
            textBox5ResultA.Text = "Fail";
            textBox6ResultA.Text = "Fail";
            textBox7ResultA.Text = "Fail";
            textBox8ResultA.Text = "Fail";
            textBox9ResultA.Text = "Fail";
            textBox10ResultA.Text = "Fail";

            textBox1ResultB.Text = "Success";
            textBox2ResultB.Text = "Success";
            textBox3ResultB.Text = "Success";
            textBox4ResultB.Text = "Success";
            textBox5ResultB.Text = "Success";
            textBox6ResultB.Text = "Success";
            textBox7ResultB.Text = "Success";
            textBox8ResultB.Text = "Success";
            textBox9ResultB.Text = "Success";
            textBox10ResultB.Text = "Success";

            if (textBox1input.Text == "Frank")
                textBox1ResultA.Text = "Success";
            if (textBox1input.Text != "Frank")
                textBox1ResultB.Text = "Fail";

            if (textBox2input.Text == "")
                textBox2ResultA.Text = "Success";
            if (textBox2input.Text != "")
                textBox2ResultB.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3input.Text);
            if (val3 == 2.3m)
                textBox3ResultA.Text = "Success";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4input.Text);
            if (val4 == false)
                textBox4ResultA.Text = "Success";
            if (val4 != false)
                textBox4ResultB.Text = "Fail";

            decimal val5a = Convert.ToDecimal(textBox5inputA.Text);
            decimal val5b = Convert.ToDecimal(textBox5inputB.Text);
            if (val5a == val5b)
                textBox5ResultA.Text = "Success";
            if (val5a != val5b)
                textBox5ResultB.Text = "Fail";

            if (textBox6input.Text != "Jones")
                textBox6ResultA.Text = "Success";
            if (textBox6input.Text == "Jones")
                textBox6ResultB.Text = "Fail";

            decimal val7 = Convert.ToDecimal(textBox7input.Text);
            if (val7 > 0)
                textBox7ResultA.Text = "Success";
            if (val7 < 0)
                textBox7ResultB.Text = "Fail";

            decimal val8a = Convert.ToDecimal(textBox8inputA.Text);
            decimal val8b = Convert.ToDecimal(textBox8inputB.Text);
            if (val8a < val8b)
                textBox8ResultA.Text = "Success";
            if (val8a > val8b)
                textBox8ResultB.Text = "Fail";

            decimal val9 = Convert.ToDecimal(textBox9input.Text);
            if (val9 >= 500m)
                textBox9ResultA.Text = "Success";
            if (val9 < 500m)
                textBox9ResultB.Text = "Fail";

            decimal val10a = Convert.ToDecimal(textBox10inputA.Text);
            decimal val10b = Convert.ToDecimal(textBox10inputB.Text);
            if (val10a <= val10b)
                textBox10ResultA.Text = "Success";
            if (val10a > val10b)
                textBox10ResultB.Text = "Fail";



        }
    }
}
