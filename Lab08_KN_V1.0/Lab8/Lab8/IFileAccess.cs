using EmployeeDB;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    interface IFileAccess
    {

        void WriteFileDB();
        void ReadFileDB();
        void OpenFileDB();
        void CloseFileDB();
        SortedDictionary<uint, Employee> EmployeeDB { get; set; }


    }
}
