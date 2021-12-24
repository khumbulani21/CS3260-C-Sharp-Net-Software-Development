

// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_03
// Date: 09/13/2017 
// Purpose: This program models creates objects of an employee database
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

namespace Lab03
{
    public partial class FrmEmployee : Form
    {
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

            //use enum
            if (CBXType.Text == "Salary")
            {
                double salary;
                int idNum;
                //get user input
                string monthlySalary = TxtOther.Text.Trim();
                //test if user has input the correct data then create a Salary employee
                if (Double.TryParse(monthlySalary, out salary) == true && int.TryParse(id, out idNum)==true)
                {
                    //create new object for Salary employee
                    Salary employee = new Salary();
                    employee.EmployeeId =  idNum;
                    employee.EmployeeType = type;
                    employee.FirstName = name;
                    employee.LastName = surname;
                    employee.MonthlySalary = salary;
                  
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
                int idNum;
                
                //get input from user
                string hourRate = TxtOther.Text.Trim();
                string hoursOfWork = TxtOther2.Text.Trim();

                //check if input is valid
                if (Double.TryParse(hourRate, out hourlyRate) == true && int.TryParse(id, out idNum) == true && Double.TryParse(hoursOfWork, out hoursWorked) == true )
                {

                    //create new object for Hourly employee
                    Hourly employee = new Hourly(hourlyRate, hoursWorked);
                    employee.EmployeeId = idNum;
                    employee.EmployeeType = type;
                    employee.FirstName = name;
                    employee.LastName = surname;

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
                int idNum;

                string _wage = TxtOther.Text.Trim();
                string hoursOfWork = TxtOther2.Text.Trim();
                if (Double.TryParse(_wage, out wage) == true && int.TryParse(id, out idNum) == true )
                {

                    //create new object for Contract employee
                    Contract employee = new Contract();
                    employee.EmployeeId = idNum;
                    employee.EmployeeType = type;
                    employee.FirstName = name;
                    employee.LastName = surname;
                    employee.ContractWage = wage;

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
                int idNum;
                double salary;
                string commissionX = TxtOther.Text.Trim();
                string salesX = TxtOther2.Text.Trim();
                string salaryX = TxtOther3.Text.Trim();
                if (Double.TryParse(salaryX, out salary) == true && Double.TryParse(commissionX, out commission) == true && int.TryParse(id, out idNum) == true && Double.TryParse(salesX, out sales) == true)
                {

                    //create new object for Hourly employee
                    Sales employee = new Sales(salary, commission, sales);
                    
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
        private  void print(int id, string empType, string name, string surname)
        {
            RTxtInfo.Clear();
            RTxtInfo.AppendText($"Employee id:  {id } \n");
            RTxtInfo.AppendText($"Employee type:  {empType } \n");
            RTxtInfo.AppendText($"First name:  {name } \n");
            RTxtInfo.AppendText($"Last name:  {surname } \n");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lab 03 Employee database \n Clicking on save creates a new employee");
        }
    }
}
