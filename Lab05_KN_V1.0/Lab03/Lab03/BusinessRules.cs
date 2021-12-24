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
    sealed class BusinessRules
    {
       //List of employees
        private List<Employee> employee;

        /// <summary>
        /// Constructor for BusinessRules
        /// </summary>
        public BusinessRules()
        {
            employee=new List<Employee>(10);
            populateList();
        }
        /// <summary>
        /// Helper method to populate list with 10 employees
        /// </summary>
        private void populateList()
        {
            //Add objects to List
            employee.Add(new Salary(1, "Salary", "James", "Trum", 98000)) ;
            employee.Add(new Salary(2, "Salary", "John", "Kane", 67000));
            employee.Add(new Sales(3, "Sales", "Judy", "Black", 4200, 5, 5000));
            employee.Add(new Sales(4, "Sales", "Eve", "Simons", 8500, 5, 20000));
            employee.Add(new Hourly(5, "Hourly", "Khumbu", "Ndlovu", 20, 40));
            employee.Add(new Hourly(6, "Hourly", "John", "Ndlovu", 25, 40));
            employee.Add(new Contract(7, "Contract", "Black", "Smith", 10000));
            employee.Add(new Contract(8, "Contract", "Lionel", "Ziggy", 5000));
            employee.Add(new Contract(9, "Contract", "Kayed", "Benzema", 15000));
            employee.Add(new Sales(10, "Sales", "Mary", "Jane", 6500, 5, 10000));
           
        }

        /// <summary>
        /// Indexer for the BusinessRules class
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Employee this[int index]
        {
            get { return employee[index]; }
            set { employee[index]=value; }
        }

        /// <summary>
        /// Function to get the employee list
        /// </summary>
        /// <returns></returns>
        public List<Employee> getList()
        {
            return employee;
        }
    }
}
