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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    /// <summary>
    /// This class models a comples number
    /// </summary>
    class ComplexData
    {

        private double real;
        private double imaginery;
        // private string complexNumber;

/// <summary>
        /// This method sets the value of the real number for the complex number.
        /// </summary>
        /// <param name="realNumber"></param>
        public void SetReal(double realNumber)
        {
            real = realNumber;
        }

        /// <summary>
        /// This method sets the value of the real part of the complex number.
        /// </summary>
        /// <param name="imagineryNumber"></param>
        public void SetImaginery(double imagineryNumber)
        {
            imaginery = imagineryNumber;
        }

        /// <summary>
        /// This method gets the value of the real part of the complex number.
        /// </summary>
        /// <returns>real value</returns>
        public double GetReal()
        {
            return real;
        }
        /// <summary>
        /// This method gets the value of the imaginery part of the complex number.
        /// </summary>
        /// <returns>imaginery value</returns>
        public double GetImaginery()
        {
            return imaginery;
        }



        public override string ToString()
        {
            if (real == 0)
            {
                return imaginery + "i";
            }
            if (imaginery == 0)
            {
                return real.ToString();
            }
            if (imaginery > 0)
            {
                return real + "" + "+" + imaginery + "i";
            }

            return real + "" + imaginery + "i";

        }

    }
}
