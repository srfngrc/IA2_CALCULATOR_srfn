using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA2_CALCULATOR_srfn
{
    public partial class BasicCalculator : Form
    {
        string textToOutput = "";
        int temporalcounter;
        int temporalcounter1;
        int finalcount;
        int serafin = 0;
        bool boolvariable;
        string operator;
        public BasicCalculator()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "1";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput,out temporalcounter);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "2";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        
        private void Button3_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "3";
            txtMain.Text = textToOutput;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "4";
            txtMain.Text = textToOutput;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "5";
            txtMain.Text = textToOutput;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "6";
            txtMain.Text = textToOutput;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "7";
            txtMain.Text = textToOutput;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "8";
            txtMain.Text = textToOutput;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "9";
            txtMain.Text = textToOutput;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "0";
            txtMain.Text = textToOutput;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + ".";
            txtMain.Text = textToOutput;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + " + ";
            txtMain.Text = textToOutput;
            temporalcounter1 = temporalcounter;
            temporalcounter = 0;
            operator = '+';
        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + " - ";
            txtMain.Text = textToOutput;
            temporalcounter1 = temporalcounter;
            temporalcounter = 0;
            operator = '-';
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + " x ";
            txtMain.Text = textToOutput;
            temporalcounter1 = temporalcounter;
            temporalcounter = 0;
            operator = 'x';
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + " / ";
            txtMain.Text = textToOutput;
            temporalcounter1 = temporalcounter;
            temporalcounter = 0;
            operator = '/';
        }


        private void Button12_Click(object sender, EventArgs e)
        {
            //serafin = (int) txtMain.Text;
            //txtMain.Text = textToOutput;
            finalcount = temporalcounter1 operator temporalcounter;
            //Close();
        }
    }
}
