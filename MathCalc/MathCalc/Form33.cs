using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathCalc
{
    public partial class Form33 : Form
    {
        float a, b;
        int n;
        public Form33()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                n = 1;
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                    MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                n = 2;
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                    MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                n = 3;
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                    MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                n = 4;
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    b = (float)Math.Sqrt(a);
                    textBox1.Text = b.ToString();
                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    b = float.Parse(textBox1.Text);
                    float res;

                    switch (n)
                    {
                        case 1: { res = a + b; textBox1.Text = res.ToString(); } break;
                        case 2: { res = a - b; textBox1.Text = res.ToString(); } break;
                        case 3: { res = a * b; textBox1.Text = res.ToString(); } break;
                        case 4: { res = a / b; textBox1.Text = res.ToString(); } break;
                        case 5: { res = (float)Math.Pow(a, b); textBox1.Text = res.ToString(); } break;
                        default: { res = (float)Math.Log(a, b); textBox1.Text = res.ToString(); } break;

                    }
                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    double a1 = a * 3.14159265 / 180;
                    b = (float)Math.Sin(a1);
                    textBox1.Text = b.ToString();
                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    double a1 = a * 3.14159265 / 180;
                    b = (float)Math.Cos(a1);
                    textBox1.Text = b.ToString();
                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
           try
           {
               if (textBox1.Text != "")
               {
                   a = float.Parse(textBox1.Text);
                   double a1 = a * 3.14159265 / 180;
                   b = (float)Math.Tan(a1);
                   textBox1.Text = b.ToString();
               }
               else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += Math.PI;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                n = 5;
            if (textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
            }
            else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += Math.E;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    b = (float)Math.Sinh(a);
                    textBox1.Text = b.ToString();
                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    b = (float)Math.Cosh(a);
                    textBox1.Text = b.ToString();
                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                        double a1 = a;
                        b = (float)Math.Log(a1);
                        textBox1.Text = b.ToString();
                   
            }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    double a1 = a;
                    b = (float)Math.Log10(a1);
                    textBox1.Text = b.ToString();

                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                n = 6;
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();

                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                uint _number;
                string _result="";
                if (textBox1.Text != "")
                {
                    _number = uint.Parse(textBox1.Text);
                    uint  d=_number;
	                uint  x;
	                while(_number!=0)
	                {
		                x  =  _number%2;
		                _number/=2;
		                _result+=x;
	                }
                    textBox1.Clear();
                    for (int i = _result.Length - 1; i >= 0; i--)
                        textBox1.Text += _result[i].ToString();
                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дурень! Це калькулятор, а не блокнот!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
