
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
    class NList
    {

        private BaseNode frontNode;
        private BaseNode rearNode;
        private uint nodeCount;

        /// <summary>
        ///constructor for initializing data
        /// </summary>
        /// <param name="frontNode"></param>
        /// <param name="rearNode"></param>
        /// <param name="nodeCount"></param>
        public NList()
        {
            this.frontNode = null;
            this.rearNode = null;
            this.nodeCount = 0;
        }
     

        /// <summary>
        /// Property for the front node
        /// </summary>
        public BaseNode FrontNode
        {
            set { frontNode = value; }
            get { return frontNode; }


        }

        /// <summary>
        /// Property for the rear node
        /// </summary>
        public BaseNode RearNode
        {

            set { rearNode = value; }
            get { return rearNode; }

        }


        /// <summary>
        /// Property for the node count
        /// </summary>
        public uint NodeCount
        {

            set { nodeCount = value; }
            get { return nodeCount; }


        }


        /// <summary>
        /// Function for deleting all elements in the list
        /// </summary>
        public void ClearList()
        {

            if (nodeCount > 0)
            {
                while (FrontNode != null)
                {

                    BaseNode temp = this.Pop_Front();
                    temp = null;
                    nodeCount--;
                }
            }

        }

        /// <summary>
        /// Function to display the list
        /// </summary>
        public string DisplayList()
        {
            string listInfo = "empty";
            BaseNode next = FrontNode;
            //Console.WriteLine(next);
            if (next == null)
            {
                return listInfo;
            }

            else if (nodeCount > 0)
            {
                listInfo = "";
                while (next != null)
                {
                    listInfo = listInfo + " " + next.ToString() + " \n";
                    next = next.NextFrontNode;


                }
            }
            return listInfo;



        }

        /// <summary>
        /// function to add node to rear of list
        /// </summary>
        /// <param name="nodeX"></param>
        public void Push_Rear(BaseNode nodeX)
        {


            //nodes already exist
            if (RearNode != null)
            {
                RearNode.NextFrontNode = nodeX;
                nodeX.NextRearNode = RearNode;
                nodeX.NextFrontNode = null;
                RearNode = nodeX;
                nodeCount++;



            }
            //if list is empty
            else
            {

                RearNode = nodeX;
                FrontNode = nodeX;
                rearNode.NextFrontNode = null;
                rearNode.NextRearNode = null;
                nodeCount++;

            }


        }


        /// <summary>
        /// function to add node to rear of list
        /// </summary>
        /// <param name="nodeX"></param>
        public void Push_Front(BaseNode nodeX)
        {


            //nodes already exist
            if (FrontNode != null)
            {
                nodeX.NextFrontNode = FrontNode;
                nodeX.NextRearNode = null;
                FrontNode = nodeX;


                nodeCount++;
            }
            //if list is empty
            else
            {
                RearNode = nodeX;
                FrontNode = nodeX;
                FrontNode.NextFrontNode = null;
                FrontNode.NextRearNode = null;
                nodeCount++;
            }


        }

        /// <summary>
        /// function to add node to rear of list
        /// </summary>
        /// <param name="nodeX"></param>
        public BaseNode Pop_Rear()
        {
            BaseNode temp = RearNode;
            if (RearNode != null)
            {
                RearNode = RearNode.NextRearNode;
                if (RearNode != null)

                    RearNode.NextFrontNode = null;


            }
            return temp;


        }

        /// <summary>
        /// function to remove node from the front of the list 
        /// </summary>
        /// <param name="nodeX"></param>
        public BaseNode Pop_Front()
        {



            BaseNode temp = FrontNode;
            if (FrontNode != null)
            {
                FrontNode = FrontNode.NextFrontNode;
                if (FrontNode != null)

                    FrontNode.NextRearNode = null;


            }
            return temp;
        }



        /// <summary>
        /// Function to get the front node
        /// </summary>
        /// <returns></returns>
        public BaseNode GetFrontNode()
        {
            return FrontNode;
        }
    }
}
