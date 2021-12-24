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
    ///Performs basic arithmetic operations on complex numbers
    /// </summary>
    class ComplexAritmetic
    {

        const int TWO_DECIMAL_PLACES = 2;
       
        /// <summary>
        /// adds two complex numbers
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static ComplexData Add(ComplexData num1, ComplexData num2)
        {
            ComplexData answer = new ComplexData();
            answer.SetReal(num1.GetReal() + num2.GetReal());
            answer.SetImaginery(num1.GetImaginery() + num2.GetImaginery());
            return answer;

        }

        /// <summary>
        /// subtracts two complex numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static ComplexData Subtract(ComplexData num1, ComplexData num2)
        {
                ComplexData answer = new ComplexData();
                answer.SetReal(num1.GetReal() - num2.GetReal());
                answer.SetImaginery(num1.GetImaginery() - num2.GetImaginery());
                return answer;
                
        }

        /// <summary>
        /// multiplies two complex numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static ComplexData Multiply(ComplexData num1, ComplexData num2)
        {
            
            // real part of the product
            double real = (num1.GetReal() * num2.GetReal()) - (num1.GetImaginery() * num2.GetImaginery());

            //imaginary part of the product
            double imaginery = (num1.GetReal() * num2.GetImaginery()) + (num1.GetImaginery() * num2.GetReal());

            ComplexData answer = new ComplexData();
            answer.SetReal(real);
            answer.SetImaginery(imaginery);
            return answer;
            
        }

        /// <summary>
        /// divides two complex numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static ComplexData Divide(ComplexData num1, ComplexData num2)
        {
            
            ComplexData conjugate = Conjugate(num2.GetReal(), num2.GetImaginery());
            ComplexData numerator = Multiply(num1, conjugate);
            double denominator = (num2.GetReal() * conjugate.GetReal()) - (num2.GetImaginery() * conjugate.GetImaginery());

            ComplexData answer = new ComplexData();
            answer.SetReal(Math.Round(numerator.GetReal() / denominator, TWO_DECIMAL_PLACES));
            answer.SetImaginery(Math.Round(numerator.GetImaginery() / denominator, TWO_DECIMAL_PLACES));
            return answer;
           

        }

        /// <summary>
        /// Finds the conjugate of an complex number
        /// </summary>
        /// <param name="real"></param>
        /// <param name="imaginary"></param>
        /// <returns>conjugate</returns>
        private static ComplexData Conjugate(double real, double imaginary)
        {

            ComplexData answer = new ComplexData();
            answer.SetReal(real);
            answer.SetImaginery(-imaginary);
            return answer;
            
        }

        

    }
}
