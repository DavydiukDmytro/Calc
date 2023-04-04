using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Calc C;
        int k;
        public Form1()
        {
            InitializeComponent();
            C = new Calc();
            labelNumber.Text = "0";
        }

        public void CorrectNumber()
        {
            if (labelNumber.Text.IndexOf("∞") != -1 )
            {
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);
            }

            if (labelNumber.Text[0] == '0' && (labelNumber.Text.IndexOf(",") != 1)) {
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            }

            if (labelNumber.Text[0] == '-')
            {
                if (labelNumber.Text[1] == '0' && (labelNumber.Text.IndexOf(",") != 2))
                {
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);
                }
            }
        }

        private bool CanPress()
        {
            if (!buttonMult.Enabled)
            {
                return false;
            }

            if (!buttonDiv.Enabled)
            {
                return false;
            }

            if (!buttonPlus.Enabled)
            {
                return false;
            }

            if (!buttonMinus.Enabled)
            {
                return false;
            }

            if (!buttonSqrtX.Enabled)
            {
                return false;
            }

            if (!buttonDegreeY.Enabled)
            {
                return false;
            }

            return true;
        }
        private void FreeButtons()
        {
            buttonMult.Enabled = true; 
            buttonDiv.Enabled = true;
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
            buttonSqrtX.Enabled = true;
            buttonDegreeY.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";

            C.Clear_A();

            FreeButtons();

            k = 0;
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '-')
            {
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            } else
            {
                labelNumber.Text = "-"+labelNumber.Text;
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if ((labelNumber.Text.IndexOf(",")== -1) && (labelNumber.Text.IndexOf("∞") == -1)){
                labelNumber.Text += ",";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "0";
            CorrectNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "1";
            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "2";
            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "3";
            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "4";
            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "5";
            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "6";
            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "7";
            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "8";
            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "9";
            CorrectNumber();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (!buttonMult.Enabled)
            {
                labelNumber.Text = C.Multiplication(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            if (!buttonDiv.Enabled)
            {
                labelNumber.Text = C.Division(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            if (!buttonPlus.Enabled)
            {
                labelNumber.Text = C.Sum(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            if (!buttonMinus.Enabled)
            {
                labelNumber.Text = C.Subtraction(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            if (!buttonSqrtX.Enabled)
            {
                labelNumber.Text = C.SqrtX(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            if (!buttonDegreeY.Enabled)
            {
                labelNumber.Text = C.DegreeY(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            C.Clear_A();
            FreeButtons();
            k = 0;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                buttonMult.Enabled = false;
                labelNumber.Text = "0";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                buttonDiv.Enabled = false;
                labelNumber.Text = "0";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                buttonPlus.Enabled = false;
                labelNumber.Text = "0";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                buttonMinus.Enabled = false;
                labelNumber.Text = "0";
            }
        }

        private void buttonDegreeY_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                buttonDegreeY.Enabled = false;
                labelNumber.Text = "0";
            }
        }

        private void buttonSqrtX_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                buttonSqrtX.Enabled = false;
                labelNumber.Text = "0";
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = C.Sqrt().ToString();
                C.Clear_A();
                FreeButtons();
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = C.Square().ToString();
                C.Clear_A();
                FreeButtons();
            }
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if((Convert.ToDouble(labelNumber.Text) == (int)(Convert.ToDouble(labelNumber.Text))) && 
                    ((Convert.ToDouble(labelNumber.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(labelNumber.Text));
                    labelNumber.Text = C.Factorial().ToString();
                    C.Clear_A();
                    FreeButtons();
                } else { MessageBox.Show("Кількість має бути >= 0 і цілим!"); }
            }
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            C.M_Sum(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            C.M_Subtraction(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMMult_Click(object sender, EventArgs e)
        {
            C.M_Multiplication(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMDiv_Click(object sender, EventArgs e)
        {
            C.M_Division(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMRC_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                k++;

                if (k == 1) {
                    labelNumber.Text=C.MemoryShow().ToString();
                }
                if (k == 2)
                {
                    C.Memory_Clear();
                    labelNumber.Text = "0";
                    k = 0;
                }
            }
        }
    }
}
