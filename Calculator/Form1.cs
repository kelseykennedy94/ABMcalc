using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zeroBtn.Text = "0";
            oneBtn.Text = "1";
            twoBtn.Text = "2";
            threeBtn.Text = "3";
            fourBtn.Text = "4";
            fiveBtn.Text = "5";
            sixBtn.Text = "6";
            sevenBtn.Text = "7";
            eightBtn.Text = "8";
            nineBtn.Text = "9";
            clearBtn.Text = "C";
            backspaceBtn.Text = "<-";
            equalBtn.Text = "=";
            addBtn.Text = "+";
            subBtn.Text = "-";
            modulusBtn.Text = "%";
            multiplyBtn.Text = "x";
            divideBtn.Text = "÷";
            negposBtn.Text = "+/-";
            dotBtn.Text = ".";

            screen.ReadOnly = true;
        }

        private void CalculateResult()
        {
            double num1 = double.Parse(screen.Text);
            double num2 = double.Parse(screen.Text);

            double result = 0;
            if (mode == "+")
            {
                result = add(num1, num2);
            }
            else if (mode == "-")
            {
                result = subtract(num1, num2);
            }
            else if (mode == "x")
            {
                result = multiply(num1, num2);
            }
        }
    }
}
