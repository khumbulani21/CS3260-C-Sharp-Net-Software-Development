// Project Prolog
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
    /// <summary>
    /// enum for the employee type
    /// </summary>
    enum ETYPE { SALARY, SALES, HOURLY, CONTRACT }
    enum COMPENSATION {Monthly_Salary, Monthly_Pay,Hourly_Rate }
    enum BENEFITS { No,Yes}
    enum EDUCATIONALBENEFITS { No, Yes }
    enum OVERTIME { No, Yes }
    /// <summary>
    /// This is an abstract class that provides common members for all employees
    /// </summary>
    /// 
    [Serializable]
    public abstract class Employee
    {
        //fields
        private uint employeeId;
        private string employeeType;
        private string firstName;
        private string lastName;
        private string compensation;
        private string overtime ;
        private string benefits;
        private string educationalBenefits;
        private string commision;
        SortedDictionary<string, Course> education;
        /// <summary>
        /// Employee constructor to initialize data
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="employeeType"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Employee(uint employeeId, string employeeType, string firstName, string lastName, string overtime, string benefits, string educationalBenefits, string commission, string compensation)
        {
            this.employeeId = employeeId;
            this.employeeType = employeeType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.compensation = compensation;
            this.educationalBenefits = educationalBenefits;
            this.overtime = overtime;
            this.benefits = benefits;
            this.commision = commission;
            this.education = new SortedDictionary<string, Course>();
            
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public Employee()
        {
         
        }
        /// <summary>
        /// Property for setting and getting employee id
        /// </summary>
        public uint EmployeeId
        {
            set { employeeId = value; }
            get { return employeeId; }
        }
        /// <summary>
        /// Property for setting and getting employee type
        /// </summary>
        public string EmployeeType
        {
            set { employeeType = value; }
            get { return employeeType; }
        }
        /// <summary>
        /// Property for setting and getting first name
        /// </summary>
        public string FirstName
        {
            set { firstName = value; }
            get { return firstName; }
        }

        /// <summary>
        /// Property for setting and getting last name
        /// </summary>
        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }


        /// <summary>
        /// Property for  benefits
        /// </summary>
        public string Benefits
        {
            set { benefits = value; }
            get { return benefits; }
        }

        /// <summary>
        /// Property for overtime
        /// </summary>
        public string Overtime
        {
            set { overtime = value; }
            get { return overtime; }
        }
        public string EducationalBenefits
        {
            set { educationalBenefits = value; }
            get { return educationalBenefits; }
        }

        /// <summary>
        /// Property for commission
        /// </summary>
        public string Commision
        {
            set { commision = value; }
            get { return commision; }
        }
        /// <summary>
        /// Function to print out Employee details
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return employeeId + " " + employeeType + " " + firstName + " " + lastName+" "+ overtime+" "+benefits+" "+" "+compensation+" "+educationalBenefits;
        }
        public SortedDictionary<string, Course> Education
        {
            set { education = value; }
                get { return education; }
        }
        //
        public void AddCourses(string id,Course course)
        {
            
            education.Add(id,course);

        }


    }
}
