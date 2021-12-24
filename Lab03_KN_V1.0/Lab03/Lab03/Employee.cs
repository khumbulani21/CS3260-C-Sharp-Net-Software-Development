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
    /// enum for the employee type
    /// </summary>
     enum ETYPE {SALARY, SALES, HOURLY,CONTRACT }


    /// <summary>
    /// This is an abstract class that provides common members for all employees
    /// </summary>
    abstract class Employee
    {
        private int employeeId;
        private string employeeType;
        private string firstName;
        private string lastName;

        public int EmployeeId
        {
            set { employeeId = value; }
            get{ return employeeId; }
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

       
    }
}
