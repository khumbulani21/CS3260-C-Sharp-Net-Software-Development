// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_02
// Date: 09/07/2017 
// Purpose: This program performs basic mathematical operations on complex numbers
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// function for calculating the product of two complex numbers when  +  button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //variables to hold values from text box
            string tempReal1 = TxtReal1.Text.Trim();
            string tempImag1 = TxtImg1.Text.Trim();
            string tempReal2 = TxtReal2.Text.Trim();
            string tempImag2 = TxtImg2.Text.Trim();

            // variables for user input
            double realNumber1;
            double imagineryNumber1;
            double realNumber2;
            double imagineryNumber2;

            if (isValidInput(tempReal1, tempImag1, tempReal2, tempImag2))
            {
                //convert the strings value to a double
                realNumber1 = double.Parse(tempReal1);
                imagineryNumber1 = double.Parse(tempImag1);
                realNumber2 = double.Parse(tempReal2);
                imagineryNumber2 = double.Parse(tempImag2);

                //create new ComplexData objects for the two complex numbers
                ComplexData operand1 = new ComplexData();
                ComplexData operand2 = new ComplexData();

                //initialize variables
                operand1.SetReal(realNumber1);
                operand1.SetImaginery(imagineryNumber1);
                operand2.SetReal(realNumber2);
                operand2.SetImaginery(imagineryNumber2);

                //output the answer in a textbox
                TxtBxAnswer.Text = ComplexAritmetic.Add(operand1, operand2).ToString();
            }
            else
            {
                //display message
                MessageBox.Show("Invalid input try again");
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void TxtReal1_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// function for calculating the product of two complex numbers when  -  button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubtract_Click(object sender, EventArgs e)
        {

            //variables to hold values from text box
            string tempReal1 = TxtReal1.Text.Trim();
            string tempImag1 = TxtImg1.Text.Trim();
            string tempReal2 = TxtReal2.Text.Trim();
            string tempImag2 = TxtImg2.Text.Trim();

            // variables for user input
            double realNumber1;
            double imagineryNumber1;
            double realNumber2;
            double imagineryNumber2;

            if (isValidInput(tempReal1, tempImag1, tempReal2, tempImag2))
            {
                //convert the strings value to a double
                realNumber1 = double.Parse(tempReal1);
                imagineryNumber1 = double.Parse(tempImag1);
                realNumber2 = double.Parse(tempReal2);
                imagineryNumber2 = double.Parse(tempImag2);

                //create new ComplexData objects for the two complex numbers
                ComplexData operand1 = new ComplexData();
                ComplexData operand2 = new ComplexData();

                operand1.SetReal(realNumber1);
                operand1.SetImaginery(imagineryNumber1);
                operand2.SetReal(realNumber2);
                operand2.SetImaginery(imagineryNumber2);
                //output the answer in a textbox
                TxtBxAnswer.Text = ComplexAritmetic.Subtract(operand1, operand2).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input try again");
            }


        }
        /// <summary>
        /// function for calculating the product of two complex numbers when  *  button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            //variables to hold values from text box
            string tempReal1 = TxtReal1.Text.Trim();
            string tempImag1 = TxtImg1.Text.Trim();
            string tempReal2 = TxtReal2.Text.Trim();
            string tempImag2 = TxtImg2.Text.Trim();

            // variables for user input
            double realNumber1;
            double imagineryNumber1;
            double realNumber2;
            double imagineryNumber2;

            if (isValidInput(tempReal1, tempImag1, tempReal2, tempImag2))
            {
                //convert the strings value to a double
                realNumber1 = double.Parse(tempReal1);
                imagineryNumber1 = double.Parse(tempImag1);
                realNumber2 = double.Parse(tempReal2);
                imagineryNumber2 = double.Parse(tempImag2);

                //create new ComplexData objects for the two complex numbers
                ComplexData operand1 = new ComplexData();
                ComplexData operand2 = new ComplexData();

                //initialize variables
                operand1.SetReal(realNumber1);
                operand1.SetImaginery(imagineryNumber1);
                operand2.SetReal(realNumber2);
                operand2.SetImaginery(imagineryNumber2);
                //output the answer in a textbox
                TxtBxAnswer.Text = ComplexAritmetic.Multiply(operand1, operand2).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input try again");
            }

        }
        /// <summary>
        /// function for calculating the product of two complex numbers when  /  button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDivide_Click(object sender, EventArgs e)
        {


            //variables to hold values from text box
            string tempReal1 = TxtReal1.Text.Trim();
            string tempImag1 = TxtImg1.Text.Trim();
             string tempReal2 = TxtReal2.Text.Trim();
            string tempImag2 = TxtImg2.Text.Trim();
            
            // variables for user input
            double realNumber1;
            double imagineryNumber1;
            double realNumber2;
            double imagineryNumber2;

            if ( isValidInput(tempReal1,  tempImag1,  tempReal2,  tempImag2))
            {
                //convert the string value to a double
                realNumber1 = double.Parse(tempReal1);
                imagineryNumber1 = double.Parse(tempImag1);
                realNumber2 = double.Parse(tempReal2);
                imagineryNumber2 = double.Parse(tempImag2);

                //check if user is trying to divide by 0
                if (realNumber2 == 0 && imagineryNumber2 == 0)
                {
                    MessageBox.Show("You cannot divide by 0");
                   
                }
                else
                {
                    //create new ComplexData objects for the two complex numbers
                    ComplexData operand1 = new ComplexData();
                    ComplexData operand2 = new ComplexData();


                    //initialize variables
                    operand1.SetReal(realNumber1);
                    operand1.SetImaginery(imagineryNumber1);
                    operand2.SetReal(realNumber2);
                    operand2.SetImaginery(imagineryNumber2);

                    ComplexData answer=ComplexAritmetic.Divide(operand1, operand2);
                    
                    TxtBxAnswer.Text = ComplexAritmetic.Divide(operand1, operand2).ToString();
                }
                
            }
            else
            {
                MessageBox.Show("Invalid input try again");
            }
}


        /// <summary>
        /// checks to see if input is valid
        /// </summary>
        /// <param name="tempReal1"></param>
        /// <param name="tempImag1"></param>
        /// <param name="tempReal2"></param>
        /// <param name="tempImag2"></param>
        /// <returns></returns>
        private bool isValidInput(string tempReal1, string tempImag1, string tempReal2, string tempImag2)
        {

           
            // variables for user input
            double realNumber1;
            double imagineryNumber1;
            double realNumber2;
            double imagineryNumber2;

            //check if input is valid
            if (Double.TryParse(tempReal1, out realNumber1) == true && Double.TryParse(tempImag1, out imagineryNumber1) && Double.TryParse(tempReal2, out realNumber2) == true && Double.TryParse(tempImag2, out imagineryNumber2))
            {
                return true;
            }
             return false;
           
        }
    }
}
