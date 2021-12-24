
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
    sealed class SNode : BaseNode
    {

        uint quantity;
        string supplyName;
        string description;



        //BaseNode NextFrontNode;
        //BaseNode NextRearNode;
        //int NodeNumber;
        /// <summary>
        /// constructor for SNode for initializing values
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="supplyName"></param>
        /// <param name="description"></param>
        public SNode()
        {

        }
        /// <summary>
        /// property for quantity
        /// </summary>
        public uint Quantity
        {

            set { quantity = value; }


            get { return quantity; }
        }


        /// <summary>
        /// property for supply name
        /// </summary>
        public string SupplyName
        {

            set { supplyName = value; }


            get { return supplyName; }
        }
        /// <summary>
        /// property for supply name
        /// </summary>
        public string Descrption
        {

            set { description = value; }


            get { return description; }
        }


        /// <summary>
        /// Function to print out a string representation of a node
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {

            //uint quantity;
            //string supplyName;
            //string description;
            //if (this == null) return "Empty node ";
            return base.ToString() + " " + "Quantity: " + quantity + " Supply name: " + supplyName + "  Description: " + description;

        }



        /// <summary>
        /// function to ma
        /// </summary>
        /// <returns></returns>
        public SNode Copy()
        {

            //uint quantity;
            //string supplyName;
            //string description;
            SNode copyNode = new SNode();
            copyNode.Quantity = this.Quantity;
            copyNode.SupplyName = this.SupplyName;
            copyNode.Descrption = this.Descrption;
            return copyNode;
        }




    }
}
