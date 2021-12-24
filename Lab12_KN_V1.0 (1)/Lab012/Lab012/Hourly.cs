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
    /// Models hourly employee
    /// </summary>
    /// 
    [Serializable]
    public sealed class Hourly : Employee
    {
        private double hourlyRate;
        private double hoursWorked;
        private bool overtime;
        private const string compensation = "Hourly Rate";
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
        public Hourly(uint employeeId, string employeeType, string title, string firstName, char middleInitial,
            string lastName, bool maritalStatus, string overtime, string benefits,
            string educationalBenefits, string commission, string compensation, string departmentName, DateTime startDate, double hourlyRate, uint hoursWorked)
            : base(employeeId, employeeType,
                    title, firstName, middleInitial, lastName,
                     maritalStatus, overtime, benefits, educationalBenefits,
                     commission, compensation, departmentName, startDate)
        {// public Employee(uint employeeId, string employeeType, string firstName, string lastName, bool overtime, bool benefits, bool educationalBenefits,string compensation
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        /// <summary>
        /// Function to override the ToString function to print data from Hourly class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string hourlyInfo = $"  {hourlyRate:c}  {hoursWorked}";
            return base.ToString() + " " + hourlyInfo;
        }

    }
}
