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


using EmployeeDB;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab012
{
    /// <summary>
    /// Interface for writing and reading from a file
    /// </summary>
    interface IFileAccess
    {

        void WriteFileDB();
        void ReadFileDB();
        void OpenFileDB();
        void CloseFileDB();
        SortedDictionary<uint, Employee> EmployeeDB { get; set; }


    }
}
