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
    /// Models a contract employee
    /// </summary>
    /// 
    [Serializable]
    public sealed class Contract : Employee
    {
        //variable for contract wage
        private double contractWage;
        //private const string compensation = "Monthly Pay";
        //public Hourly(int employeeId, string employeeType, string title, string firstName,char middleInitial, string lastName, double hourlyRate, double hoursWorked) : base(employeeId, employeeType, firstName, lastName)
        public Contract(uint employeeId, string employeeType, string title, string firstName, char middleInitial,
            string lastName, bool maritalStatus,  string overtime, string benefits,
            string educationalBenefits, string commission, string compensation,
            string departmentName, DateTime startDate, double contractWage)
            : base( employeeId,  employeeType,
                    title,  firstName,  middleInitial,  lastName,
                     maritalStatus,  overtime,  benefits,  educationalBenefits,
                     commission,  compensation,  departmentName,  startDate)
        {
            this.contractWage = contractWage;
        }
        /// <summary>
        /// property for contract wage
        /// </summary>
        public double ContractWage
        {
            set { contractWage = value; }
            get { return contractWage; }
        }

        /// <summary>
        /// Overrides the ToString method for the Contract class to return more specific information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + " " + $"{contractWage:c}";
        }
    }
}
