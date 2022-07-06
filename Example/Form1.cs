using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {

        double FirstNumber, SecondNumber;
        string Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(textBox1.Text.Length - 1);
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void Number7Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void Number8Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void Number4Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void Number5Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void Number6Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void Number1Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void Number2Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void Number3Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void Number0Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(textBox1.Text);
            Operator = "+";
            textBox1.Text = "";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(textBox1.Text);
            Operator = "-";
            textBox1.Text = "";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(textBox1.Text);
            Operator = "*";
            textBox1.Text = "";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(textBox1.Text);
            Operator = "/";
            textBox1.Text = "";
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            double tmp = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(-1 * tmp);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            SecondNumber = double.Parse(textBox1.Text);

            switch (Operator)
            {
                case "+":
                    textBox1.Text = (FirstNumber + SecondNumber).ToString();
                    break;
                case "-":
                    textBox1.Text = (FirstNumber - SecondNumber).ToString();
                    break;
                case "*":
                    textBox1.Text = (FirstNumber * SecondNumber).ToString();
                    break;
                case "/":
                    textBox1.Text = (FirstNumber / SecondNumber).ToString();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            string f, s;

            f = Convert.ToString(FirstNumber);
            s = Convert.ToString(SecondNumber);

            f = "";
            s = "";
        }
    }
}
