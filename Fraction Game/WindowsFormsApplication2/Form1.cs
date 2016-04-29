using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_ChangeFraction_Click(object sender, EventArgs e)
        {
            if(lab_Operation.Text == "+")
            {
                lab_Operation.Text = "-";
            }
            else if(lab_Operation.Text == "-")
            {
                lab_Operation.Text = "×";
            }
            else if (lab_Operation.Text == "×")
            {
                lab_Operation.Text = "÷";
            }
            else if (lab_Operation.Text == "÷")
            {
                lab_Operation.Text = "+";
            }
            ShowInstructions(lab_Operation.Text);
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //Changing visibility of some labels.
            lab_Negative.Visible = false;
            //Temp Int.
            int temp;

            //Answers.
            int numerator = 0;
            int denominator = 0;

            //Fraction Components.
            int a,b,c,d; // A/B = Numerators, C/D = Denominators.
            bool validInput = true;

            //Checks for invalid inputs while converting text to ints.
            if (!Int32.TryParse(inbx_FractionA.Text, out a))
            {
                validInput = false;
            }
            if (!Int32.TryParse(inbx_FractionB.Text, out b))
            {
                validInput = false;
            }
            if (!Int32.TryParse(inbx_FractionC.Text, out c))
            {
                validInput = false;
            }
            if (!Int32.TryParse(inbx_FractionD.Text, out d))
            {
                validInput = false;
            }
            // Error checks.
            if(validInput)
            {
                if (!(a > 0 && b > 0 && c > 0 && d > 0))
                {
                    validInput = false;
                }
            }

            if (validInput)
            {
                //Variables used for finding the common denominator.
                int LCM = lcm(c, d);
                //These variables are used to store the multiplicative relationship between the LCM and the denominators.
                int cToLCM = LCM / c;
                int dToLCM = LCM / d;
                switch (lab_Operation.Text)
                {
                    case "+":
                        numerator = (cToLCM * a) + (dToLCM * b);
                        denominator = LCM;

                        temp = gcf(numerator, denominator);
                        numerator /= temp;
                        denominator /= temp;
                        break;
                    case "-":
                            numerator = (cToLCM * a) - (dToLCM * b);
                            denominator = LCM;
                            if(numerator < 0)
                            {
                                numerator = Math.Abs(numerator);
                                lab_Negative.Visible = true;
                            }

                            temp = gcf(numerator, denominator);
                            numerator /= temp;
                            denominator /= temp;
                        break;
                    case "×":
                        numerator =  (cToLCM * a) * (dToLCM * b);
                        denominator = (cToLCM * c) * (dToLCM * d);

                        temp = gcf(numerator, denominator);
                        numerator /= temp;
                        denominator /= temp;
                        break;
                    case "÷":
                        if(b == 0)
                        {
                            MessageBox.Show("You cannot divide by 0!");
                            break;
                        }
                        numerator = (cToLCM * a) * (dToLCM * d);
                        denominator = (cToLCM * c) * (dToLCM * b);

                        temp = gcf(numerator, denominator);
                        numerator /= temp;
                        denominator /= temp;
                        break;
                    default:
                        MessageBox.Show("Program Broke");
                        break;
                }

                lab_ResultTop.Text = Convert.ToString(numerator);
                lab_ResultBot.Text = Convert.ToString(denominator);
            }
            else
            {
                MessageBox.Show("Please input a positive integer.");
            }
        }
        
        public void ShowInstructions(string operation)
        {
            //This switch takes the current operation, and tells user how to solve it.
            switch(operation)
            {
                case"+":
                    lab_Instruction1.Text = "Step 1: Find the Least Common Denominator(LCD).";
                    lab_Instruction2.Text = "Step 2: Add, ignoring the denominator.";
                    break;
                case"-":
                    lab_Instruction1.Text = "Step 1: Find the Least Common Denominator(LCD).";
                    lab_Instruction2.Text = "Step 2: Subtract, ignoring the denominator.";
                    break;

                case"×":
                    lab_Instruction1.Text = "Step 1: Multiply the two numerators.";
                    lab_Instruction2.Text = "Step 2: Multiply the two denominators.";
                    break;

                case"÷":
                    lab_Instruction1.Text = "Step 1: Flip the divisor.";
                    lab_Instruction2.Text = "Step 2: Multiply the two fractions.";
                break;

                default:
                MessageBox.Show("The Program Broke, Sorry!");
                break;
            }
        }

        #region Math Part
        static int gcf(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int lcm(int a, int b)
        {
            return (a / gcf(a, b)) * b;
        }
        #endregion

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    
    }
}
