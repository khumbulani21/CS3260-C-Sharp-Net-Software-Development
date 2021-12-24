
// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_10
// Date: 12/1/2017
// Purpose: Linked list program
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

namespace Lab010
{
    class CNode : BaseNode
    {
        private DateTime cDate;
        private decimal cost;
        private string description;
        private string makeModel;
        private uint year;

        /// <summary>
        /// constructor for initializing variables
        /// </summary>
        /// <param name="date"></param>
        /// <param name="cost"></param>
        /// <param name="description"></param>
        /// <param name="makeModel"></param>
        /// <param name="year"></param>
        public CNode()
        {


        }


        /// <summary>
        /// property for CDate
        /// </summary>
        public DateTime CDate
        {
            set { cDate = value; }
            get { return cDate; }


        }

        /// <summary>
        /// property for cost
        /// </summary>
        public decimal Cost
        {
            set { cost = value; }
            get { return cost; }


        }

        /// <summary>
        /// property for description
        /// </summary>
        public string Description
        {
            set { description = value; }
            get { return description; }


        }

        /// <summary>
        /// property for make model
        /// </summary>
        public string MakeModel
        {
            set { makeModel = value; }
            get { return makeModel; }


        }

        /// <summary>
        /// property for year
        /// </summary>
        public uint Year
        {
            set { year = value; }
            get { return year; }


        }

        /// <summary>
        /// Function to print out a string representation of a node
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            //if (this == null) return "Empty node ";
            return base.ToString() + " " + "Date: " + CDate + " Cost: " + cost + "  Description: " + description + " Make: " + makeModel + " Year: " + year;

        }
        /// <summary>
        /// function to make a copy of a node
        /// </summary>
        /// <returns></returns>
        public CNode Copy()
        {

            CNode copyNode = new CNode();
            copyNode.CDate = this.CDate;
            copyNode.Cost = this.Cost;
            copyNode.MakeModel = this.MakeModel;
            return copyNode;
        }

    }
}
