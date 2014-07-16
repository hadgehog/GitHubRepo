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
    public partial class Form1 : Form
    {

        float a, b;
        int n;
        public Form1()
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



        private void button11_Click(object sender, EventArgs e)
        {
            try
            {n = 1;
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
                        default: { res = a / b; textBox1.Text = res.ToString(); } break;

                    }
                }
                else MessageBox.Show("Не тупи! Натисни на циферку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FormatException)
            {
                MessageBox.Show("Дурак! Это калькулятор, а не блокнот!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



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

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {n = 2;
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
                MessageBox.Show("Дурак! Это калькулятор, а не блокнот!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {n = 3;
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
                MessageBox.Show("Дурак! Это калькулятор, а не блокнот!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
           try
            { n = 4;
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
               MessageBox.Show("Дурак! Это калькулятор, а не блокнот!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
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
                 MessageBox.Show("Дурак! Это калькулятор, а не блокнот!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form33 f2 = new Form33();
            f2.ShowDialog();
        }
    }
}
