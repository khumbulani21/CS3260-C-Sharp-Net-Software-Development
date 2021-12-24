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
    /// Models hourly employee
    /// </summary>
   sealed class Hourly:Employee
    {
        private double hourlyRate;
        private double hoursWorked;

        /// <summary>
        /// property for setting and getting the value of the hourly rate
        /// </summary>
        public double HourlyRate
        {
            set { hourlyRate = value; }
            get { return hourlyRate; }
        }

        /// <summary>
        /// property for setting and getting the value of the hours worked
        /// </summary>
        public double HoursWorked
        {
            set { hoursWorked = value; }
            get { return hoursWorked; }
        }

        /// <summary>
        /// Constructor for creating Hourly employee and initializing the variables
        /// </summary>
        /// <param name="hourlyRate"></param>
        /// <param name="hoursWorked"></param>
        public Hourly(double hourlyRate, double hoursWorked)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        
    }
}
