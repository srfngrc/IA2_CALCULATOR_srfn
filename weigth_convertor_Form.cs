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
    public partial class weigth_convertor_Form : Form
    {
        Double numDouble = 0.00;
        Double numDouble2 = 0.00;
        public weigth_convertor_Form()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (TBlbsTOkgs.Text == "0")
            {
                //no hace nada
            }
            else
            {
                //TryParse
                if (double.TryParse(TBlbsTOkgs.Text, out numDouble))
                {
                    //MessageBox.Show("string converted to double nicely");
                    numDouble2 = numDouble * 0.453592;
                    TBlbsTOkgs.Text = numDouble2.ToString();
                }
                else
                {
                    MessageBox.Show("shit!");
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (TBlbsTOkgs.Text == "0")
            {
                //no hace nada
            }
            else
            {
                //TryParse
                if (double.TryParse(TBlbsTOkgs.Text, out numDouble))
                {
                    //MessageBox.Show("string converted to double nicely");
                    numDouble2 = numDouble * 2.20462;
                    TBlbsTOkgs.Text = numDouble2.ToString();
                }
                else
                {
                    MessageBox.Show("shit!");
                }
            }
        }
    }
}
