// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_06
// Date: 10/19/2017 
// Purpose: This program models creates objects of an employee database and makes use of a sorted dictionery
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

namespace EmployeeDB
{
    [Serializable]
    public class Salary : Employee
    {
        private double monthlySalary;

        /// <summary>
        /// Constructor for salary class
        /// </summary>
        /// <param name="monthlySalary"></param>
        public Salary(uint employeeId, string employeeType, string firstName, string lastName, double monthlySalary) : base(employeeId, employeeType, firstName, lastName)
        {
            this.monthlySalary = monthlySalary;
        }


        /// <summary>
        /// Property for monthly salary
        /// </summary>
        public double MonthlySalary
        {
            set { monthlySalary = value; }
            get { return monthlySalary; }
        }
        /// <summary>
        /// ToString function for Salary employee
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + " " + $"{monthlySalary:c}";
        }

    }

}
