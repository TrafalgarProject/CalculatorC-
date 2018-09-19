using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double a, b;
        int count;
        bool znak = true;
        public Form1()
        {
            InitializeComponent();
            refresh();
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    // b = a / float.Parse(textBox1.Text);
                    a = Math.Sqrt(double.Parse(textBox1.Text));
                    textBox1.Text = a.ToString();
                    break;
                default:
                    break;
            }

        }
        public void refresh()
        {
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;

            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;

            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;

            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;

            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;

            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;

            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;

            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;

            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;

            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;

            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;

            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;

            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;

            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;

            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;

            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;

            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;

            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;

            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Math.Sqrt(Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(a);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | (e.KeyChar == Convert.ToChar("+")) | (e.KeyChar == Convert.ToChar("-")) | (e.KeyChar == Convert.ToChar("/")) | (e.KeyChar == Convert.ToChar("*")) || (e.KeyChar == Convert.ToChar("V")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

    }
}
