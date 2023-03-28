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
        }
    }
}
