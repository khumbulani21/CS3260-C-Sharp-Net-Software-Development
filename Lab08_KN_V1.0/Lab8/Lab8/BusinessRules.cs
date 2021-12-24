// Proj// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_07
// Date: 10/26/2017 
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
    public sealed class BusinessRules
    {
        //List of employees
        
        SortedDictionary<uint, Employee> employee;

        /// <summary>
        /// Constructor for BusinessRules
        /// </summary>
        public BusinessRules()
        {
            employee = new SortedDictionary<uint, Employee>();
            populateList();
        }
        /// <summary>
        /// Helper method to populate list with 10 employees
        /// </summary>
        private void populateList()
        {
            // public Employee(uint employeeId, string employeeType, string firstName, string lastName, 
            //bool overtime, bool benefits, bool educationalBenefits,string compensation)
            employee[1] = new Salary(1, "Salary", "James", "Trum", 98000, "No","Yes", "Yes", "No", "Monthly Salary" );
            employee[2] = (new Salary(2, "Salary", "John", "Kane", 67000, "No", "Yes", "Yes", "No", "Monthly Salary"));
            employee[3] = new Sales(3, "Sales", "Judy", "Black", 4200, 5, 5000, "No", "Yes", "Yes", "Yes", "Monthly Salary");
            employee[4] = new Sales(4, "Sales", "Eve", "Simons", 8500, 5, 20000, "No", "Yes", "Yes", "Yes", "Monthly Salary");
            employee[5] = new Hourly(5, "Hourly", "Khumbu", "Ndlovu", 20, 40, "Yes", "No", "Yes", "No", "Hourly rate");
            employee[6] = (new Hourly(6, "Hourly", "John", "Ndlovu", 25, 40,  "Yes", "No", "Yes", "No", "Hourly rate"));
            employee[7] = (new Contract(7, "Contract", "Black", "Smith", 10000, "No", "No", "No", "No", "Monthly pay"));
            employee[8] = (new Contract(8, "Contract", "Lionel", "Ziggy", 5000, "No", "No", "No", "No", "Monthly pay"));
            employee[9] = (new Contract(9, "Contract", "Kayed", "Benzema", 15000, "No", "No", "No", "No", "Monthly pay"));
            employee[10] = null;

        }

        /// <summary>
        /// Indexer for the BusinessRules class
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Employee this[uint key]
        {

            //get employee or throw exception if employee is not found
            get
            {
                try
                {
                    return employee[key];

                }
                catch (KeyNotFoundException e)
                {

                    return null;
                }



            }

            //add employee to dictionery
            set
            {
                employee[key] = value;

            }
        }

        /// <summary>
        /// Function to get the employee list
        /// </summary>
        /// <returns></returns>
        public SortedDictionary<uint, Employee> getList()
        {
            return employee;
        }

        public void SetList(SortedDictionary<uint, Employee> sDictionery)
        {
            employee = sDictionery;
        }

        public Employee getEmployee(string lastName)
        {

            Employee employeeX = null;
            foreach (Employee x in this.employee.Values)
            {

            
                if (x == null)
                {
                    return null;
                }
                

                if (string.Compare(x.LastName, lastName, true) == 0)
                {
                    return x;
                }


            }
            return employeeX;
        }


    }
}
