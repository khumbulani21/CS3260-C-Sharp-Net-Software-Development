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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDB;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;
using System.ComponentModel;

namespace Lab012
{
    public class FileIO : Object, IFileAccess
    {


        //variables
        private SortedDictionary<uint, Employee> employeeDB;
        private Stream streamIn;
        private Stream streamOut;
        private string fileName;
        string streamType;
        BusinessRules ruleX;
        /// <summary>
        /// Constructor for initilizing data
        /// </summary>
        public FileIO()
        {
            ruleX = new BusinessRules();
            employeeDB = ruleX.getList();
            streamType = "";
            streamOut = null;
            streamIn = null;
            fileName = "file path";
        }


        /// <summary>
        /// property for setting and getting a sorted dictionary
        /// </summary>
        public SortedDictionary<uint, Employee> EmployeeDB
        {
            get { return employeeDB; }

            set { employeeDB = value; }

        }//end


        /// <summary>
        /// Funtion for closing a file
        /// </summary>
        public void CloseFileDB()
        {

            //close stream
            if (streamType == "streamIn")
            {
                streamIn.Close();
            }
            else streamOut.Close();
        }



        /// <summary>
        /// Fumction for openning a file
        /// </summary>
        public void OpenFileDB()
        {
            //check streamType in order to use the open file dialog or the save file dialog
            if (streamType == "streamIn")
            {
                //instantiate the open file dialog class
                OpenFileDialog OpenDialog = new OpenFileDialog();

                //filter files that show up in the open dialog
                OpenDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                //check to see if file opened
                if (OpenDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //set file name
                    fileName = OpenDialog.FileName;
                }
            }
            else
            {
                //create new SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((streamOut = saveFileDialog.OpenFile()) != null)
                    {
                        //set file name
                        fileName = saveFileDialog.FileName;
                        //set stream type for closing
                        streamType = "streamOut";
                        //close stream
                        CloseFileDB();
                    }
                }
            }




        }


        /// <summary>
        ///Function for reading from a serialized file and deserializing
        /// </summary>
        public void ReadFileDB()
        {

            //set stream type to stremIn
            streamType = "streamIn";
            //open a file
            OpenFileDB();
            //deserialize file
            Deserialise(fileName);
            //close file
            CloseFileDB();
        }


        /// <summary>
        /// Function for writing serialized data  to a file
        /// </summary>
        public void WriteFileDB()
        {
            //set stream type to straemIn
            streamType = "streamOut";
            OpenFileDB();
            //serialize the file
            Serialise(fileName);
            CloseFileDB();


        }

        /// <summary>
        /// Function to serialize data
        /// </summary>
        /// <param name="filename"></param>
        private void Serialise(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            streamOut = File.OpenWrite(filename);
            formatter.Serialize(streamOut, employeeDB);

        }

        /// <summary>
        /// Function to deserialize data read from a file and convert the data to a sorted dictionary
        /// </summary>
        /// <param name="filename"></param>
        private void Deserialise(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            streamIn = File.OpenRead(filename);
            EmployeeDB = (SortedDictionary<uint, Employee>)formatter.Deserialize(streamIn);

        }

        /// <summary>
        ///Function to return the name of the file
        /// </summary>
        /// <returns></returns>
        public string GetFileName()
        {
            return fileName;
        }

    }
}
