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

            employee[1] = new Salary(10000, "Salary", "Mr", "James", 'C', "Trum", true, "Yes", "Yes", "Yes", "No", "Monthly Salary", "IT", new DateTime(), 98000);
            employee[2] = new Salary(10001, "Salary", "Mr", "John", 'U', "Ndlovu", true, "Yes", "Yes", "Yes", "No", "Monthly Salary", "IT", new DateTime(), 98090);
            employee[3] = new Sales(10002, "Sales", "Mr", "John", 'U', "Ndlovu", true, "Yes", "Yes", "Yes", "No", "Monthly Salary", "IT", new DateTime(), 98090, 10, 89766);
            employee[4] = new Sales(10003, "Sales", "Mr", "John", 'U', "Salif", true, "Yes", "Yes", "Yes", "No", "Monthly Salary", "Sales", new DateTime(), 98522, 15, 100000);
            employee[5] = new Hourly(10004, "Hourly", "Mr", "John", 'U', "Salif", true, "Yes", "Yes", "Yes", "No", "Hourly rate", "IT", new DateTime(), 15, 40);
            employee[6] = new Hourly(10005, "Hourly", "Mr", "John", 'U', "Salif", true, "Yes", "Yes", "Yes", "No", "Hourly rate", "IT", new DateTime(), 15, 40);
            employee[7] = new Contract(10006, "Contract", "Mr", "Judas", 'U', "Kalif", true, "Yes", "Yes", "Yes", "No", "Monthly pay", "IT", new DateTime(), 98090);
            employee[8] = new Contract(10007, "Contract", "Mr", "Judas", 'U', "Kalif", true, "Yes", "Yes", "Yes", "No", "Monthly pay", "IT", new DateTime(), 85222);
            employee[9] = new Salary(10012, "Salary", "Mr", "John", 'U', "Mguni", true, "Yes", "Yes", "Yes", "No", "Monthly Salary", "IT", new DateTime(), 98090);
            employee[10] = new Sales(10013, "Sales", "Mr", "Jordan", 'U', "Ibe", true, "Yes", "Yes", "Yes", "No", "Monthly Salary", "IT", new DateTime(), 98090, 10, 89766);
            employee[11] = new Hourly(10015, "Hourly", "Mr", "John", 'U', "Salif", true, "Yes", "Yes", "Yes", "No", "Hourly rate", "IT", new DateTime(), 15, 40);
            employee[12] = new Contract(10020, "Contract", "Mr", "Ahmed", 'U', "Abdul", true, "Yes", "Yes", "Yes", "No", "Monthly pay", "IT", new DateTime(), 98090);
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

                    foreach (Employee x in employee.Values)
                    {
                        if (x.EmployeeId == key)
                        {
                            return x;
                        }
                    }
                    return null;

                }
                catch (KeyNotFoundException e)
                {

                    return null;
                }



            }

            //add employee to dictionery
            set
            {
                employee.Add(key, value);

            }
        }

        /// <summary>
        /// Function to get the employee list
        /// </summary>
        /// <returns></returns>
        public SortedDictionary<uint, Employee> getList() =>  employee;
    

        /// <summary>
        /// function to set a sorted dictionery
        /// </summary>
        /// <param name="sDictionery"></param>
        public void SetList(SortedDictionary<uint, Employee> sDictionery)
        {
            employee = sDictionery;
        }

        /// <summary>
        /// function to get an employee using lastname
        /// </summary>
        /// <param name="lastname"></param>
        /// <returns> List<Employee></returns>
        public Employee getEmployee(string lastname)
        {

            Employee employeeX = null;
            foreach (Employee x in this.employee.Values)
            {


                if (x == null)
                {
                    return null;
                }


                if (string.Compare(x.LastName, lastname, true) == 0)
                {
                    return x;
                }


            }
            return employeeX;
            
        }

        /// <summary>
        /// Function that takes in a creates a new business rules class and adds an employee using operator overloading
        /// </summary>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static BusinessRules operator +(BusinessRules b, Employee c)
        {
            //BusinessRules d= new BusinessRules();
            b.employee.Add(c.EmployeeId, c);
           
            return b;
        }

    }
}
