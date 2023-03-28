using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string op = string.Empty;

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
            nineBtn.Text= "9";
            clearBtn.Text= "C";
            backspaceBtn.Text= "<-";
            equalBtn.Text= "=";
            addBtn.Text= "+";
            subBtn.Text= "-";
            modulusBtn.Text = "%";
            multiplyBtn.Text = "x";
            divideBtn.Text = "÷";
            negposBtn.Text = "+/-";
            dotBtn.Text = ".";

            screen.ReadOnly = true;
        }


        public float Calculate(string mode)
        {
            float result = 0;
            string numbers = screen.Text;
            char[] Ops = { '+', '-', '/', '*', '%'};
            foreach(char op in Ops)
            {
                string[] Nums = numbers.Split(op);
                for (int i = 0; i < Nums.Length-1; i++)
                {
                    // i is the first number
                    for (int j = 1; j <= Nums.Length-1; j++) 
                    {
                        // j is the second number
                        if(mode == "+")
                        {
                            result = float.Parse(Nums[i]) + float.Parse(Nums[j]);   
                        }

                    }
                }

               
            }
            return result;

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            screen.Text = string.Empty;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("7");
        }

        private void negposBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("-");
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("0");
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText(".");
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("1");
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("2");
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("3");
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("4");
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("5");
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("6");
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("8");
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText("9");
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
           screen.Text = screen.Text.Remove(screen.Text.Length-1,1);
        }
        private void modulusBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText(" % ");
            op = "%";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText(" / ");
            op = "/";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText(" * ");
            op = "*";
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText(" - ");
            op ="-";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            screen.AppendText(" + ");
            op ="+";

        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            screen.Text = Convert.ToString(Calculate(op));
        }



        public double modulus(double num1, double num2)
        {
            return num1 % num2;
        }

        public double divide(double num1, double num2)
        {
            return num1 / num2;
        }


    }
}
