// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_12
// Date: 12/08/2017 
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

    /// <summary>
    /// This class models a salaried employee
    /// </summary>
    /// 
    [Serializable]
    public sealed class Sales : Salary
    {
        private double comission;
        private double grossSales;



        /// <summary>
        /// constructor for Sales class
        /// </summary>
        /// <param name="commission"></param>
        public Sales(uint employeeId, string employeeType, string title, string firstName, char middleInitial,
            string lastName, bool maritalStatus, string overtime, string benefits,
            string educationalBenefits, string commission, string compensation, string departmentName,
            DateTime startDate,double monthlySalary, double comission, double grossSales)
            : base( employeeId,  employeeType,  title,  firstName,  middleInitial,
                         lastName,  maritalStatus,  overtime,  benefits,
                         educationalBenefits,  commission,  compensation,  departmentName,
                         startDate,  monthlySalary)
        {
           
            this.comission = comission;
            this.grossSales = grossSales;
        }

        /// <summary>
        /// property for commission
        /// </summary>
        public double Commission
        {
            set { comission = value; }
            get { return comission; }
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

            return base.ToString() + " " + $"{comission:p} {grossSales:c}";
        }
    }
}
