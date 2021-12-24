// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_04
// Date: 10/08/2017 
// Purpose: This program is for practice with delegates and Lambdas
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

namespace Lab4
{
    //Example delegate 
    public delegate string ExampleDelegate(int a, double b, char c, string d);
    public delegate int CalculationDelegate(int a,int b);
    class TestDelegate
    {

        private List<Func<int, double, char, string, string>> _DList;
        const int FIVE = 5;
        const int FOUR = 4;
        //other fields as needed
        public TestDelegate()
        {
            _DList = new List<Func<int, double, char, string, string>>();
            PopulateList(_DList);

        }


        /// <summary>
        /// Function to test _DList
        /// </summary>
        public void RunTests()
        {
            int idata = 1;
            double ddata = 5.1;
            char cdata = 'A';
            string sdata = "Method ";
            foreach (Func<int, double, char, string, string> myDel in _DList)
                Console.WriteLine(myDel(idata, ddata++, cdata++, sdata + idata++));
        }

        /// <summary>
        /// Function to populate _DList
        /// </summary>
        /// <param name="list"></param>
        private void PopulateList(List<Func<int, double, char, string, string>> list)
        {
            //create delegates
            Func<int, double, char, string, string> funcParametersAsString = (a, b, c, d) => "The parameters passed are : " + a + " " + b + " " + c + " " + d;
            Func<int, double, char, string, string> funcParameterType = ParameterType;
            Func<int, double, char, string, string> funcAddParameters = AddParameters;

            //add delegates to list
            list.Add(ParametersAsString);
            list.Add(AddParameters);
            list.Add(ParameterType);
        }

        /// <summary>
        /// Function to print out input parameters passed in by user
        /// </summary>
        /// <returns></returns>
        public string ParametersAsString(int a, double b, char c, string d) => $"The parameters passed are :   Integer :{a} Double :{b} Character :{c} String:{d}\n";
        

        /// <summary>
        /// Function to find the sum of the first three parameters
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">double</param>
        /// <param name="c">char</param>
        /// <returns>string</returns>
        public static string AddParameters(int a, double b, char c, string d)
        {
            return $"The sum of the first 3 parameters  {a}, {b} and {c} for {d} is : " + (a + b + c).ToString() + "\n";
        }

        /// <summary>
        /// Function to get the types of parameters using GetType()
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">double</param>
        /// <param name="c">char</param>
        /// <param name="d">string</param>
        /// <returns>string</returns>
        public  string ParameterType(int a, double b, char c, string d)
        {
            string typeA = a.GetType().ToString();
            string typeB = b.GetType().ToString();
            string typeC = c.GetType().ToString();
            string typeD = d.GetType().ToString();
            return $" {a} is a {typeA}, {b} is a {typeB}, {c} is a {typeC} and {d} is a {typeD} \n";
        }
       

        //chained delegates
        /// <summary>
        /// Function to test chained delegates printing out the product of 5 and 4
        /// </summary>
        public void ChainedDelegates()
        {
            CalculationDelegate add = Add;
            add += Product;
            
            Console.WriteLine($"The product of {FIVE} and  {FOUR}  : "+ add(FIVE,FOUR));
        }
        
        /// <summary>
        /// Function to calculate the sum of two numbers
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns>int</returns>
        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        /// <summary>
        /// Function to calculate the product of two numbers
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns>int</returns>
        public int Product(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

    }//end class TestDelegate

}
