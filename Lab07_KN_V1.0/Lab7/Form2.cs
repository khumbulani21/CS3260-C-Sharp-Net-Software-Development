// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_07
// Date: 10/26/2017 
// Purpose: This program models creates objects of an employee database and makes use of a sorted dictionery
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
//using EmployeeDB.FileIO;

namespace EmployeeDB
{
    public partial class FrmEmployee : Form
    {
        const uint LIST_SIZE = 10;
        //uint index = 0;
        BusinessRules employeeList = new BusinessRules();
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            string id = TxtID.Text.Trim();
            string type = CBXType.Text.Trim();
            string name = TxtName.Text.Trim();
            string surname = TxtSurname.Text.Trim();
            // employeeList = new BusinessRules();

            //use enum
            if (CBXType.Text == "Salary")
            {
                double salary;
                uint idNum;
                //get user input
                string monthlySalary = TxtOther.Text.Trim();
                //test if user has input the correct data then create a Salary employee
                if (Double.TryParse(monthlySalary, out salary) == true && uint.TryParse(id, out idNum) == true)
                {
                    //create new object for Salary employee

                    Salary employee = new Salary(idNum, type, name, surname, salary);
                    employeeList[employee.EmployeeId] = employee;
                    /*employee.EmployeeId =  idNum;
                    employee.EmployeeType = type;
                    employee.FirstName = name;
                    employee.LastName = surname;
                    employee.MonthlySalary = salary;
                  */
                    //Display employee information  in a rich textbox
                    print(employee.EmployeeId, employee.EmployeeType, employee.FirstName, employee.LastName);
                    RTxtInfo.AppendText($"Salary:  {employee.MonthlySalary } \n");
                }
                else
                {
                    MessageBox.Show("Invalid salary try again");
                }

            }

            else if (CBXType.Text == "Hourly")
            {

                //Set the visibility of text boxes and labels
                LblOther.Visible = true;
                LblOther2.Visible = true;
                TxtOther.Visible = true;
                TxtOther2.Visible = true;
                LblOther.Text = "Hourly rate";
                LblOther2.Text = "Hours worked";
                //variables for hourly rate, hours worked and id 
                double hourlyRate;
                double hoursWorked;
                uint idNum;

                //get input from user
                string hourRate = TxtOther.Text.Trim();
                string hoursOfWork = TxtOther2.Text.Trim();

                //check if input is valid
                if (Double.TryParse(hourRate, out hourlyRate) == true && uint.TryParse(id, out idNum) == true && Double.TryParse(hoursOfWork, out hoursWorked) == true)
                {

                    //create new object for Hourly employee
                    Hourly employee = new Hourly(idNum, type, name, surname, hourlyRate, hoursWorked);
                    employeeList[employee.EmployeeId] = employee;

                    /* employee.EmployeeId = idNum;
                    employee.EmployeeType = type;
                    employee.FirstName = name;
                    employee.LastName = surname;
                    */
                    print(employee.EmployeeId, employee.EmployeeType, employee.FirstName, employee.LastName);
                    RTxtInfo.AppendText($"Hourly Rate:  {employee.HourlyRate } \n");
                    RTxtInfo.AppendText($"Hours Worked:  {employee.HoursWorked } \n");
                }
                else
                {
                    MessageBox.Show("Invalid input try again");
                }

            }
            else if (CBXType.Text == "Contract")
            {
                //set the visibility of components
                LblOther.Visible = true;
                TxtOther.Visible = true;
                LblOther2.Visible = false;
                TxtOther2.Visible = false;
                LblOther.Text = "Contract wage";
                double wage;
                uint idNum;

                string _wage = TxtOther.Text.Trim();
                string hoursOfWork = TxtOther2.Text.Trim();
                if (Double.TryParse(_wage, out wage) == true && uint.TryParse(id, out idNum) == true)
                {

                    //create new object for Contract employee
                    Contract employee = new Contract(idNum, type, name, surname, wage);
                    //add employee to BusinessRules
                    employeeList[employee.EmployeeId] = employee;
                    /*employee.EmployeeId = idNum;
                    employee.EmployeeType = type;
                    employee.FirstName = name;
                    employee.LastName = surname;
                    employee.ContractWage = wage;
                    */
                    print(employee.EmployeeId, employee.EmployeeType, employee.FirstName, employee.LastName);
                    RTxtInfo.AppendText($"Contract Wage:  {employee.ContractWage } \n");

                }
                else
                {
                    MessageBox.Show("Invalid input try again");
                }
            }
            else if (CBXType.Text == "Sales")
            {
                //show labels and textboxes for other required information
                LblOther.Visible = true;
                TxtOther.Visible = true;
                LblOther2.Visible = true;
                TxtOther2.Visible = true;
                LblOther3.Visible = true;
                TxtOther3.Visible = true;

                LblOther.Text = "Commission";
                LblOther2.Text = "Gross Sales";
                LblOther3.Text = "Monthly salary";
                double commission;
                double sales;
                uint idNum;
                double salary;
                string commissionX = TxtOther.Text.Trim();
                string salesX = TxtOther2.Text.Trim();
                string salaryX = TxtOther3.Text.Trim();
                if (Double.TryParse(salaryX, out salary) == true && Double.TryParse(commissionX, out commission) == true && uint.TryParse(id, out idNum) == true && Double.TryParse(salesX, out sales) == true)
                {

                    //create new object for Hourly employee
                    Sales employee = new Sales(idNum, type, name, surname, salary, commission, sales);
                    //add employee to BusinessRules
                    employeeList[employee.EmployeeId] = employee;
                    //Initialize variables
                    employee.EmployeeId = idNum;
                    employee.EmployeeType = type;
                    employee.FirstName = name;
                    employee.LastName = surname;
                    employee.MonthlySalary = salary;

                    //display employee information on a rich textbox
                    print(employee.EmployeeId, employee.EmployeeType, employee.FirstName, employee.LastName);
                    RTxtInfo.AppendText($"Commission:  {employee.Commission } \n");
                    RTxtInfo.AppendText($"Gross sales:  {employee.GrossSales } \n");
                    RTxtInfo.AppendText($"Monthly Salary:  {employee.MonthlySalary } \n");
                }
                else
                {
                    MessageBox.Show("Invalid input try again");
                }
            }
            TxtOther.Clear();
            TxtID.Clear();
            TxtName.Clear();
            TxtOther2.Clear();
            TxtSurname.Clear();
            TxtOther3.Clear();

        }
        /// <summary>
        /// Controls the visibility of labels and text boxes for different employees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBXType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //use enum
            if (CBXType.Text == "Salary")
            {
                LblOther.Visible = true;
                TxtOther.Visible = true;
                LblOther2.Visible = false;
                TxtOther2.Visible = false;
                LblOther3.Visible = false;
                TxtOther3.Visible = false;
                LblOther.Text = "Monthly Salary";
            }

            else if (CBXType.Text == "Hourly")
            {
                LblOther.Visible = true;
                LblOther2.Visible = true;
                TxtOther.Visible = true;
                TxtOther2.Visible = true;
                LblOther3.Visible = false;
                TxtOther3.Visible = false;
                LblOther.Text = "Hourly rate";
                LblOther2.Text = "Hours worked";
            }
            else if (CBXType.Text == "Contract")
            {
                LblOther.Visible = true;
                TxtOther.Visible = true;
                LblOther2.Visible = false;
                TxtOther2.Visible = false;
                LblOther3.Visible = false;
                TxtOther3.Visible = false;
                LblOther.Text = "Contract wage";
            }
            else if (CBXType.Text == "Sales")
            {
                LblOther.Visible = true;
                TxtOther.Visible = true;
                LblOther2.Visible = true;
                TxtOther2.Visible = true;
                LblOther3.Visible = true;
                TxtOther3.Visible = true;
                LblOther.Text = "Commission";
                LblOther2.Text = "Gross Sales";
                LblOther3.Text = "Monthly salary";
            }
        }

        /// <summary>
        /// exits application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit application
            Application.Exit();
        }

        /// <summary>
        /// method to display the general information in rich textbox
        /// </summary>
        /// <param name="id"></param>
        /// <param name="empType"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        private void print(uint id, string empType, string name, string surname)
        {
            RTxtInfo.Clear();
            RTxtInfo.AppendText($"Employee id:  {id } \n");
            RTxtInfo.AppendText($"Employee type:  {empType } \n");
            RTxtInfo.AppendText($"First name:  {name } \n");
            RTxtInfo.AppendText($"Last name:  {surname } \n");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee database \n Clicking on save creates a new employee");
        }
        /// <summary>
        /// Function to display information from employee List in richtext box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnView_Click(object sender, EventArgs e)
        {

            RtxtBRules.Clear();

            //loop through the employee list appending employees to a rich textbox
            foreach (Employee employeeX in employeeList.getList().Values)
            {
                RtxtBRules.AppendText($"{employeeX}\n");
            }


        }
        /// <summary>
        /// Clear richtextboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            RtxtBRules.Clear();
            RTxtInfo.Clear();
        }


        /// <summary>
        /// Search for employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            RtxtBRules.Clear();
            RTxtInfo.Clear();
            uint employeeNum;
            if (uint.TryParse(TxtSearch.Text.Trim(), out employeeNum) == true)
            {
                //search for employee and store in variable
                Employee tempEmployee = employeeList[employeeNum];

                //check if employee is in dictionery found if not display message
                if (tempEmployee == null)
                {
                    MessageBox.Show("Employee not found");
                }
                //append rich textbox with employee information
                else RTxtInfo.AppendText(tempEmployee.ToString());
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            RtxtBRules.Clear();
            RTxtInfo.Clear();
            Lab7.FileIO newFile = new Lab7.FileIO();

            //newFile.OpenFileDB();

            newFile.WriteFileDB();
            //display message after writing to file
            MessageBox.Show("Finished writing to file" + newFile.GetFileName());
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            RtxtBRules.Clear();
            RTxtInfo.Clear();
            Lab7.FileIO newFile = new Lab7.FileIO();
            newFile.ReadFileDB();

            foreach (Employee x in newFile.EmployeeDB.Values)
            {
                string something;

                //check to see if an employee is not equal to null 
                if (x != null)
                {
                    something = x.ToString();
                }
                else something = "Null employee entry ";

                //print out sorted dictionary on rich textbox
                RTxtInfo.AppendText(something + "\n");
            }





        }
    }
}
