using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
     class Salary:Employee
    {
        private double monthlySalary;

      /* /// <summary>
        /// Constructor for salary class
        /// </summary>
        /// <param name="monthlySalary"></param>
        public Salary(double monthlySalary)
        {
            this.monthlySalary = monthlySalary;
        }
        */

        /// <summary>
        /// property for monthly salary
        /// </summary>
        public double MonthlySalary
        {
            set { monthlySalary = value; }
            get { return monthlySalary; }
        }

    }

}
