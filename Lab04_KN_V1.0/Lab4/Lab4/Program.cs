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
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate myTest = new TestDelegate();
            ExampleDelegate test = myTest.ParameterType;
            ExampleDelegate test2 = myTest.ParametersAsString;

            //Test ExampleDelegate
            Console.WriteLine("Testing ExampleDelegates :");
            Console.WriteLine(test(1, 2, 'd', "ParameterType method"));
            Console.WriteLine(test(2, 3, 'e', "ParametersAsString method"));

            //Test delegates
            Console.WriteLine("Testing Func delegate :");
            myTest.RunTests();

            //test chained delegates
            Console.WriteLine("Testing chained delegates :");
            myTest.ChainedDelegates();
            Console.ReadKey();
        }
    }

   

    

}
