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
        string screenText = string.Empty;
        string mode = string.Empty;
        bool disabled = false;
        double total;
        double currentNum;


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

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            screenText += "0";
            screen.Text = screenText;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            screenText += "1";
            screen.Text = screenText;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            screenText += "2";
            screen.Text = screenText;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            screenText += "3";
            screen.Text = screenText;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            screenText += "4";
            screen.Text = screenText;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            screenText += "5";
            screen.Text = screenText;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            screenText += "6";
            screen.Text = screenText;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            screenText += "7";
            screen.Text = screenText;
        }


        private void eightBtn_Click(object sender, EventArgs e)
        {
            screenText += "8";
            screen.Text = screenText;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            screenText += "9";
            screen.Text = screenText;
        }

        private void negposBtn_Click(object sender, EventArgs e)
        {
            if (screenText.ToCharArray()[0] == '-') {
                screen.Text = screenText.Remove(0,1);
                screenText = screen.Text;
            } else
            {
                screen.Text = "-" + screenText;
                screenText = screen.Text;
            }
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!disabled)
            {
                screenText += "+";
                mode = "+";
                screen.Text = screenText;
                disabled = true;
            }
          
        }

  

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (!disabled)
            {
                screenText += "-";
                mode = "-";
                screen.Text = screenText;
                disabled = true;
            }
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            if (!disabled)
            {
                screenText += "x";
                mode = "x";
                screen.Text = screenText;
                disabled = true;
            }
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            if (!disabled)
            {
                screenText += "/";
                mode = "/";
                screen.Text = screenText;
                disabled = true;
            }
        }

        private void modulusBtn_Click(object sender, EventArgs e)
        {
            if (!disabled)
            {
                screenText += "%";
                mode = "%";
                screen.Text = screenText;
                disabled = true;
            }
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            int screenTextLength = screenText.Length;
            screen.Text = screenText.Remove(screenTextLength - 1, 1);
            screenText = screen.Text;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            screen.Clear();
            screenText = string.Empty;
            disabled = false;
        }


        private void equalBtn_Click(object sender, EventArgs e)
        {
            string[] numbers = screenText.Split(char.Parse(mode));
            double digit1 = Convert.ToDouble(numbers[0]);
            double digit2 = Convert.ToDouble(numbers[1]);

            MessageBox.Show(digit1 + " " + mode + " " + digit2);
        }
    }
}
