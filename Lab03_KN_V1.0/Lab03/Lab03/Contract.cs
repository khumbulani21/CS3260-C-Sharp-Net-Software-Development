// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_03
// Date: 09/13/2017 
// Purpose: This program models creates objects of an employee database
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

namespace Lab03
{

    /// <summary>
    /// Models a contract employee
    /// </summary>
   sealed class Contract:Employee
    {
        //variable for contract wage
        private double contractWage;

        /// <summary>
        /// property for contract wage
        /// </summary>
        public double ContractWage
        {
            set { contractWage = value; }
            get { return contractWage; }
        }


    }
}
