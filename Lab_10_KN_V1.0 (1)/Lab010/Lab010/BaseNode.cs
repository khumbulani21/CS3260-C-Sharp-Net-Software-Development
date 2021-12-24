
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
    abstract class BaseNode
    {
        private BaseNode nextFrontNode;
        private BaseNode nextRearNode;
        private uint nodeNumber;


        /// <summary>
        /// Constructor for initializing data
        /// </summary>
        /// <param name="nextFrontNode"></param>
        /// <param name="nextRearNode"></param>
        /// <param name="nodeNumber"></param>
        public BaseNode()
        {

        }

        /// <summary>
        /// property for nextFrontNode
        /// </summary>
        public BaseNode NextFrontNode
        {

            set { nextFrontNode = value; }


            get { return nextFrontNode; }
        }



        /// <summary>
        /// property for nextRearNode
        /// </summary>
        public BaseNode NextRearNode
        {

            set { nextRearNode = value; }
            get { return nextRearNode; }
        }


        /// <summary>
        /// property for nodeNumber
        /// </summary>
        public uint NodeNumber
        {

            set { nodeNumber = value; }
            get { return nodeNumber; }
        }


        /// <summary>
        /// Function to print out a string representation of a node
        /// </summary>
        /// <returns></returns>
        //override
        //public string ToString()
        //{
        //    return nextFrontNode+ " "+ nextRearNode + " "+ nodeNumber;

        //}



    }
}
