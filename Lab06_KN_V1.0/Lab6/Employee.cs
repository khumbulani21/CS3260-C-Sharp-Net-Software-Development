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
    /// <summary>
    /// enum for the employee type
    /// </summary>
    enum ETYPE { SALARY, SALES, HOURLY, CONTRACT }


    /// <summary>
    /// This is an abstract class that provides common members for all employees
    /// </summary>
   public abstract class Employee
    {
        private uint employeeId;
        private string employeeType;
        private string firstName;
        private string lastName;

        /// <summary>
        /// Employee constructor to initialize data
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="employeeType"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Employee(uint employeeId, string employeeType, string firstName, string lastName)
        {
            this.employeeId = employeeId;
            this.employeeType = employeeType;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Employee()
        {

        }

        public uint EmployeeId
        {
            set { employeeId = value; }
            get { return employeeId; }
        }
        public string EmployeeType
        {
            set { employeeType = value; }
            get { return employeeType; }
        }

        public string FirstName
        {
            set { firstName = value; }
            get { return firstName; }
        }


        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }


        /// <summary>
        /// Function to print out Employee details
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return employeeId + " " + employeeType + " " + firstName + " " + lastName;
        }


    }
}
