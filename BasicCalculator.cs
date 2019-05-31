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
        int temporalcounter = 0;
        public int counter1 = 0;
        public int counter2 = 0;
        public int counter3 = 0;
        int finalcount;
        int serafin = 0;
        bool boolvariable;
        public string operator2019 = "Empty";
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
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "4";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "5";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "6";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "7";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "8";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "9";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "0";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + ".";
            txtMain.Text = textToOutput;
            //boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (operator2019 == "Empty")
            {
                counter1 = temporalcounter;
                temporalcounter = 0;
                operator2019 = "+";

                textToOutput = "";
                txtMain.Text = textToOutput;
            }
            else if (operator2019 == "Equals")
            {
                operator2019 = "+";

                textToOutput = "";
                txtMain.Text = textToOutput;
            }
            else
            {
                counter2 = temporalcounter;
                temporalcounter = 0;
                if (operator2019 == "+") { counter1 = counter1 + counter2; }
                else if (operator2019 == "-") { counter1 = counter1 - counter2; }
                else if (operator2019 == "*") { counter1 = counter1 * counter2; }
                else if (operator2019 == "/") { counter1 = counter1 / counter2; }
                else MessageBox.Show("Error by all means", "ERROR WINDOW");
                counter2 = 0;
                operator2019 = "+";

                textToOutput = counter1.ToString();
                txtMain.Text = textToOutput;
                textToOutput = "";
            }
            
            
        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            if (operator2019 == "Empty")
            {
                counter1 = temporalcounter;
                temporalcounter = 0;
                operator2019 = "-";

                textToOutput = "";
                txtMain.Text = textToOutput;
            }
           
            else
            {
                counter2 = temporalcounter;
                temporalcounter = 0;
                if (operator2019 == "+") { counter1 = counter1 + counter2; }
                else if (operator2019 == "-") { counter1 = counter1 - counter2; }
                else if (operator2019 == "*") { counter1 = counter1 * counter2; }
                else if (operator2019 == "/") { counter1 = counter1 / counter2; }
                else MessageBox.Show("Error by all means", "ERROR WINDOW");
                counter2 = 0;
                operator2019 = "-";

                textToOutput = counter1.ToString();
                txtMain.Text = textToOutput;
                textToOutput = "";
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (operator2019 == "Empty")
            {
                counter1 = temporalcounter;
                temporalcounter = 0;
                operator2019 = "*";

                textToOutput = "";
                txtMain.Text = textToOutput;
            }
            else
            {
                counter2 = temporalcounter;
                temporalcounter = 0;
                if (operator2019 == "+") { counter1 = counter1 + counter2; }
                else if (operator2019 == "-") { counter1 = counter1 - counter2; }
                else if (operator2019 == "*") { counter1 = counter1 * counter2; }
                else if (operator2019 == "/") { counter1 = counter1 / counter2; }
                else MessageBox.Show("Error by all means", "ERROR WINDOW");
                counter2 = 0;
                operator2019 = "*";

                textToOutput = counter1.ToString();
                txtMain.Text = textToOutput;
                textToOutput = "";
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (operator2019 == "Empty")
            {
                counter1 = temporalcounter;
                temporalcounter = 0;
                operator2019 = "/";

                textToOutput = "";
                txtMain.Text = textToOutput;
            }
            else
            {
                counter2 = temporalcounter;
                temporalcounter = 0;
                if (operator2019 == "+") { counter1 = counter1 + counter2; }
                else if (operator2019 == "-") { counter1 = counter1 - counter2; }
                else if (operator2019 == "*") { counter1 = counter1 * counter2; }
                else if (operator2019 == "/") { counter1 = counter1 / counter2; }
                else MessageBox.Show("Error by all means", "ERROR WINDOW");
                counter2 = 0;
                operator2019 = "/";

                textToOutput = counter1.ToString();
                txtMain.Text = textToOutput;
                textToOutput = "";
            }
        }


        private void Button12_Click(object sender, EventArgs e)
        {
            counter2 = temporalcounter;
            temporalcounter = 0;
            if (operator2019 == "+") { counter1 = counter1 + counter2; }
            else if (operator2019 == "-") { counter1 = counter1 - counter2; }
            else if (operator2019 == "*") { counter1 = counter1 * counter2; }
            else if (operator2019 == "/") { counter1 = counter1 / counter2; }
            else MessageBox.Show("Error by all means", "ERROR WINDOW");
            counter2 = 0;
            operator2019 = "Empty";

            textToOutput = counter1.ToString();
            txtMain.Text = textToOutput;
            textToOutput = "";
        }
    }
}
