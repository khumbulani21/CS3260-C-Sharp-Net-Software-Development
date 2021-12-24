// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_05
// Date: 10/14/2017 
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

namespace EmployeeDB
{

    /// <summary>
    /// This class models a salaried employee
    /// </summary>
   sealed class Sales: Salary
    {
        private double commission;
        private double grossSales;
        
  

        /// <summary>
        /// constructor for Sales class
        /// </summary>
        /// <param name="commission"></param>
        public Sales(int employeeId, string employeeType, string firstName, string lastName, double monthlySalary, double commission,double grossSales) : base(employeeId, employeeType, firstName, lastName, monthlySalary)
        {
            //(int employeeId, string employeeType, string firstName, string lastName, double hourlyRate, double hoursWorked) : base(employeeId, employeeType, firstName, lastName, monthlySalary)
            
            this.commission = commission;
            this.grossSales = grossSales;
        }

        /// <summary>
        /// property for commission
        /// </summary>
        public double Commission
        {
            set { commission = value; }
            get { return commission; }
        }

        /// <summary>
        /// property for gross sales
        /// </summary>
        public double GrossSales
        {
            set { grossSales = value; }
            get { return grossSales; }
        }
        /// <summary>
        /// Method to calculate the total salary after adding commission
        /// </summary>
        /// <param name="monthtlySalary"></param>
        /// <returns></returns>
        public double totalPay()
        {
            return base.MonthlySalary + (grossSales * Commission);
        }
        /// <summary>
        /// Function to override the ToString function to print data from Sales class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
           
            return base.ToString() + " " + $"{commission:p} {grossSales:c}";
        }
    }
}
