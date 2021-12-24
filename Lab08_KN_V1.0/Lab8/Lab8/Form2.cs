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
        List<Course> courses = new List<Course>();
        Salary employeeSalary;
        Hourly employeeHourly;
        Contract employeeContract;
        Sales employeeSales;

        Employee x;


        public FrmEmployee()
        {
            InitializeComponent();
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
        //////////////
        /// <summary>
        /// method to display the general information in rich textbox
        /// </summary>
        /// <param name="id"></param>
        /// <param name="empType"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        private void print(uint id, string empType, string name, string surname, string overtime, string benefits, string educationalBenefits,string commission)
        {
            RTxtInfo.Clear();
            RTxtInfo.AppendText($"Employee id:  {id } \n");
            RTxtInfo.AppendText($"Employee type:  {empType } \n");
            RTxtInfo.AppendText($"First name:  {name } \n");
            RTxtInfo.AppendText($"Last name:  {surname } \n");
            RTxtInfo.AppendText($"Overtime:  {overtime } \n");
            RTxtInfo.AppendText($"Benefits:  {benefits } \n");
            RTxtInfo.AppendText($"Educational benefits  {educationalBenefits } \n");
            RTxtInfo.AppendText($"Commission :  {commission} \n");
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
            if (uint.TryParse(TxtIdSearch.Text.Trim(), out employeeNum) == true)
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
            Lab8.FileIO newFile = new Lab8.FileIO();

            //newFile.OpenFileDB();

            newFile.WriteFileDB();
            //display message after writing to file
            MessageBox.Show("Finished writing to file" + newFile.GetFileName());
        }

      

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRead_Click(object sender, EventArgs e)
        {
            RtxtBRules.Clear();
            RTxtInfo.Clear();
            Lab8.FileIO newFile = new Lab8.FileIO();
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

        private void CBXType_SelectedIndexChanged_1(object sender, EventArgs e)
        {



            //set visibility of components
            if (CBXType.Text == "Salary")
            {
                LblOther.Visible = true;
                TxtOther.Visible = true;
                LblOther2.Visible = false;
                TxtOther2.Visible = false;
                LblOther3.Visible = false;
                TxtOther3.Visible = false;
                RBtnOTNo.Checked = true;
                RBtnComNo.Checked = true;
                RBtnEdYes.Checked = true;
               
                RBtnBenefitsYes.Checked = true;
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
                RBtnOTYes.Checked = true;
                RBtnComNo.Checked = true;
                RBtnEdYes.Checked = true;
                
                RBtnBenefitsNo.Checked = true;
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
                RBtnOTNo.Checked = true;
                RBtnComNo.Checked = true;
                RBtnEdNo.Checked = true;
               
                RBtnBenefitsNo.Checked = true;
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
                RBtnOTNo.Checked = true;
                RBtnComYes.Checked = true;
                RBtnEdYes.Checked = true;
             
              
                RBtnBenefitsYes.Checked = true;
                LblOther.Text = "Monthly Salary";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            RtxtBRules.Clear();
            RTxtInfo.Clear();
            Lab8.FileIO newFile = new Lab8.FileIO();

            //newFile.OpenFileDB();
            
            newFile.WriteFileDB();
            //display message after writing to file
            MessageBox.Show("Finished writing to file" + newFile.GetFileName());
        }

        private void tabMain_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            RtxtBRules.Clear();
            RTxtInfo.Clear();
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            string benefits;
            string overtime;
           
            //get the overtime from user
            if (RBtnOTYes.Checked)
            {

                overtime = "Yes";
            }
            else
            {
                overtime = "No";
            }

            
            string educationBenefits;
            //get educational benefits from user
            if (RBtnEdYes.Checked)
            {

                educationBenefits = "Yes";
            }
            else
            {
                educationBenefits = "No";
            }

            //get the benefits option from user
            if (RBtnBenefitsYes.Checked)
            {
                benefits = "Yes";
            }//end if
            else
            {
                benefits = "No";
            }//end else
            string commission;
            //get the commision option from user
            if (RBtnComYes.Checked)
            {
                commission = "Yes";
            }//end if
            else
            {
                commission = "No";
            }//end else

            string id = TxtID.Text.Trim();
            string type = CBXType.Text.Trim();
            string name = TxtName.Text.Trim();
            string surname = TxtSurname.Text.Trim();
            string compensation = CBXTCompe.Text.Trim();
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

                     employeeSalary = new Salary(idNum, type, name, surname, salary,overtime,benefits,educationBenefits,commission,compensation);
                    
                    employeeList[employeeSalary.EmployeeId] = employeeSalary;
                    //Create instance of MessageBoxButtons that will give user option to add courses
                    x = employeeSalary;
                    messageDisplay(Course);
                    //TabEmployee.SelectedTab = tabMain;
                    //////////////////end
                    //Display employee information  in a rich textbox
                    print(employeeSalary.EmployeeId, employeeSalary.EmployeeType, employeeSalary.FirstName, employeeSalary.LastName,employeeSalary.Overtime,employeeSalary.Benefits,employeeSalary.EducationalBenefits, employeeSalary.Commision);

                    RTxtInfo.AppendText($"Salary:  {employeeSalary.MonthlySalary } \n");
                }//end if
                else
                {
                    MessageBox.Show("Invalid salary try again");
                }//end else

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
                     employeeHourly = new Hourly(idNum, type, name, surname, hourlyRate, hoursWorked, overtime, benefits, educationBenefits, commission, compensation);
                    employeeList[employeeHourly.EmployeeId] = employeeHourly;
                    //prompt user to add course information
                    x = employeeHourly;
                    messageDisplay(Course);
                    print(employeeHourly.EmployeeId, employeeHourly.EmployeeType, employeeHourly.FirstName, employeeHourly.LastName, employeeHourly.Overtime, employeeHourly.Benefits, employeeHourly.EducationalBenefits, employeeHourly.Commision);
                    RTxtInfo.AppendText($"Hourly Rate:  {employeeHourly.HourlyRate } \n");
                    RTxtInfo.AppendText($"Hours Worked:  {employeeHourly.HoursWorked } \n");
                }//end if 
                else
                {
                    MessageBox.Show("Invalid input try again");
                }//end else

            }//end if 
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
                     employeeContract = new Contract(idNum, type, name, surname, wage, overtime, benefits, educationBenefits, commission, compensation);
                    //add employee to BusinessRules
                    employeeList[employeeContract.EmployeeId] = employeeContract;
                    x=employeeContract;
                    //prompt user to add course information
                    messageDisplay(Course);
                    print(employeeContract.EmployeeId, employeeContract.EmployeeType, employeeContract.FirstName, employeeContract.LastName, employeeContract.Overtime, employeeContract.Benefits, employeeContract.EducationalBenefits, employeeContract.Commision);
                    RTxtInfo.AppendText($"Contract Wage:  {employeeContract.ContractWage } \n");

                }//end if
                else
                {
                    MessageBox.Show("Invalid input try again");
                }//end else
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
                double commision;
                double sales;
                uint idNum;
                double salary;
                string commissionX = TxtOther.Text.Trim();
                string salesX = TxtOther2.Text.Trim();
                string salaryX = TxtOther3.Text.Trim();
                if (Double.TryParse(salaryX, out salary) == true && Double.TryParse(commissionX, out commision) == true && uint.TryParse(id, out idNum) == true && Double.TryParse(salesX, out sales) == true)
                {

                    //create new object for Hourly employee
                     employeeSales = new Sales(idNum, type, name, surname, salary, commision, sales, overtime, benefits, educationBenefits, commission, compensation);
                    //add employee to BusinessRules
                    employeeList[employeeSales.EmployeeId] = employeeSales;
                    x = employeeSales;
                    //Initialize variables
                    employeeSales.EmployeeId = idNum;
                    employeeSales.EmployeeType = type;
                    employeeSales.FirstName = name;
                    employeeSales.LastName = surname;
                    employeeSales.MonthlySalary = salary;
                    //prompt user to add course information
                    messageDisplay(Course);
                    //display employee information on a rich textbox
                    print(employeeSales.EmployeeId, employeeSales.EmployeeType, employeeSales.FirstName, employeeSales.LastName, employeeSales.Overtime, employeeSales.Benefits, employeeSales.EducationalBenefits, employeeSales.Commision);
                    RTxtInfo.AppendText($"Commission:  {employeeSales.Commission } \n");
                    RTxtInfo.AppendText($"Gross sales:  {employeeSales.GrossSales } \n");
                    RTxtInfo.AppendText($"Monthly Salary:  {employeeSales.MonthlySalary } \n");
                }//end if 
                else
                {
                    MessageBox.Show("Invalid input try again");
                }//end else
            }




            TxtOther.Clear();
            TxtID.Clear();
            TxtName.Clear();
            TxtOther2.Clear();
            TxtSurname.Clear();
            TxtOther3.Clear();
        }

        /// <summary>
        /// Function for displaying a message box to prompt user to add course information
        /// </summary>
        private void messageDisplay(TabPage page)
        {
            //Create instance of MessageBoxButtons that will give user option to add courses
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to add another course for the employee ?", "Add courses", buttons); 
            if (result == DialogResult.Yes)
            {
                TxtCourseId.Clear();
               TxtDesc.Clear();
                CBoxCredits.Text = "";
                CBoxGrade.Text = "";
                
                TabEmployee.SelectedTab = page;
               // emp.Education=
            }
        }
        private void messageDisplay(TabPage page, Employee emp)
        {
            //Create instance of MessageBoxButtons that will give user option to add courses
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to add another course for the employee ?", "Add courses", buttons);
            if (result == DialogResult.Yes)
            {
                TxtCourseId.Clear();
                TxtDesc.Clear();
                CBoxCredits.Text = "";
                CBoxGrade.Text = "";

                TabEmployee.SelectedTab = page;
                // emp.Education=
            }
        }


        private void BtnView_Click_1(object sender, EventArgs e)
        {

            RtxtBRules.Clear();

            //loop through the employee list appending employees to a rich textbox
            foreach (Employee employeeX in employeeList.getList().Values)
            {
                RtxtBRules.AppendText($"{employeeX}\n");
            }
        }
        /// <summary>
        /// Employee search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //clear richtext box
            RtxtBSearch.Clear();
           
            uint employeeNum;

            //set visibility of label based on user's selection
            if (RBtnID.Checked==true)
            {
              
                if (uint.TryParse(TxtIdSearch.Text.Trim(), out employeeNum) == true)
                {

                  
                    //search for employee and store in variable
                    Employee tempEmployee = employeeList[employeeNum];

                    //check if employee is in dictionery, if not display message
                    if (tempEmployee == null)
                    {
                        MessageBox.Show("Employee not found");
                    }
                    //append rich textbox with employee information
                    else RtxtBSearch.AppendText(tempEmployee.ToString());
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
            else if (RBtnLast.Checked==true)
            {

                string lastName = TxtLastSearch.Text.Trim();
                
                      //search for employee and store in variable
                      Employee tempEmployee= employeeList.getEmployee(lastName);

                    //check if employee is in dictionery found if not display message
                    if (tempEmployee == null)
                    {
                        MessageBox.Show("Employee not found");
                    
                }
                    //append rich textbox with employee information
                    else RtxtBSearch.AppendText(tempEmployee.ToString());
               
            }

          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBXTCompe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RBtnID_CheckedChanged(object sender, EventArgs e)
        {
            LblEmpId.Visible = true;
            TxtIdSearch.Visible = true;
            LblLast.Visible = false;
            TxtLastSearch.Visible = false;
            BtnSearch.Visible = true;
        }

        private void RBtnLast_CheckedChanged(object sender, EventArgs e)
        {
            LblLast.Visible = true;
            TxtLastSearch.Visible = true;
            LblEmpId.Visible = false;
            TxtIdSearch.Visible = false;
            BtnSearch.Visible = true;
        }

        private void BtnCSave_Click(object sender, EventArgs e)
        {
            //clear richtextbox
            RTBoxCourse.Clear();
 
            string courseId=TxtCourseId.Text.Trim();
            string description=TxtDesc.Text.Trim();
            string grade=CBoxGrade.Text.Trim();
            DateTime approvalDate=dateTimePicker1.Value;
          
            uint credits;
            Course course;
            if (uint.TryParse(CBoxCredits.Text.Trim(), out credits) == true)
            {
               //create course object based on user input
                course = new Course(courseId,description,grade,approvalDate,credits );
              
                //add course to courses list
                //courses.Add(course);
                x.AddCourses(course.CourseId,course);
                RTxtInfo.AppendText(course.ToString());
                //prompt user to add a course
                messageDisplay(Course);
                RTBoxCourse.AppendText(RTxtInfo.Text);

                //display course that was added
                // RTBoxCourse.AppendText(courses[0].ToString());

            }
            else MessageBox.Show("invalid input");

          

           


        }

       


    }
}
