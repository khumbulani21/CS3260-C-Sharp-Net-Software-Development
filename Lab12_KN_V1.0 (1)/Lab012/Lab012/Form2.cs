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
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
//using EmployeeDB.FileIO;

namespace EmployeeDB
{
    public partial class FrmEmployee : Form
    {
       
 
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
        private void print(uint id, string empType, string name, string surname, string overtime, string benefits, string educationalBenefits, string commission)
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
            Lab012.FileIO newFile = new Lab012.FileIO();

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
            Lab012.FileIO newFile = new Lab012.FileIO();
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



        /// <summary>
        /// event handler for writing data to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWrite_Click(object sender, EventArgs e)
        {
            RtxtBRules.Clear();
            RTxtInfo.Clear();
            Lab012.FileIO newFile = new Lab012.FileIO();

            //newFile.OpenFileDB();

            newFile.WriteFileDB();
            //display message after writing to file
            MessageBox.Show("Finished writing to file" + newFile.GetFileName());

            playSound("Finished writing to file");


        }

        private void tabMain_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// event handler to clear rich text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            RtxtBRules.Clear();
            RTxtInfo.Clear();
        }


        string benefits;
        string overtime;
        bool married;

        /// <summary>
        /// event handler for saving new employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click_1(object sender, EventArgs e)
        {

            


            if (string.IsNullOrEmpty(TxtID.Text) == true || string.IsNullOrEmpty(TxtName.Text) == true
                || string.IsNullOrEmpty(TxtSurname.Text) == true || string.IsNullOrEmpty(CBXTCompe.Text) == true  )
            {
                MessageBox.Show("invalid input ");
            }
            else
            {
                //get the overtime from user
                if (RBtnOTYes.Checked)
                {

                    overtime = "Yes";
                }
                else
                {
                    overtime = "No";
                }

                //get the overtime from user
                if (RBtnBenefitsSingle.Checked)
                {

                    married = false;
                }
                else
                {
                    married = true;
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
                char middleInitial = ' ';
                string title = "";
               
                string departmentName = "";
                DateTime startDate = new DateTime();

                //use enum
                if (CBXType.Text == "Salary")
                {

                    if (string.IsNullOrEmpty(TxtOther.Text) == true)
                    {
                        MessageBox.Show("invalid input ");
                    }
                    else
                    {
                       
                        //get user input
                        string monthlySalary = TxtOther.Text.Trim();
                      
                        employeeSalary = new Salary(uint.Parse(TxtID.Text), type, title, name, middleInitial, surname, married, overtime,
                                 benefits, educationBenefits, commission, compensation, departmentName, startDate, double.Parse(monthlySalary));
                        uint key =employeeSalary.EmployeeId;
                        //operator overloading testing
                       BusinessRules test= employeeList + employeeSalary;

                       // employeeList[key] = employeeSalary;
                        //Create instance of MessageBoxButtons that will give user option to add courses
                        x = employeeSalary;
                        messageDisplay(Course);
                        //TabEmployee.SelectedTab = tabMain;
                      
                        //Display employee information  in a rich textbox
                        print(employeeSalary.EmployeeId, employeeSalary.EmployeeType, employeeSalary.FirstName, employeeSalary.LastName, employeeSalary.Overtime, employeeSalary.Benefits, employeeSalary.EducationalBenefits, employeeSalary.Commision);

                        RTxtInfo.AppendText($"Salary:  {employeeSalary.MonthlySalary } \n");
                      

                    }




                }

                else if (CBXType.Text == "Hourly")
                {

                    if (string.IsNullOrEmpty(TxtOther.Text) == true || string.IsNullOrEmpty(TxtOther2.Text) == true)
                    {
                        MessageBox.Show("invalid  input ");
                    }
                    else
                    {
                        //Set the visibility of text boxes and labels
                        LblOther.Visible = true;
                        LblOther2.Visible = true;
                        TxtOther.Visible = true;
                        TxtOther2.Visible = true;
                        LblOther.Text = "Hourly rate";
                        LblOther2.Text = "Hours worked";
                        

                        //get input from user
                        string hourRate = TxtOther.Text.Trim();
                        string hoursOfWork = TxtOther2.Text.Trim();

                        //check if input is valid
                        //if (Double.TryParse(hourRate, out hourlyRate) == true && uint.TryParse(id, out idNum) == true && uint.TryParse(hoursOfWork, out hoursWorked) == true)
                        //{

                        //create new object for Hourly employee
                        employeeHourly = new Hourly(uint.Parse(id), type, title, name, middleInitial, surname, married, overtime, benefits, educationBenefits, commission, compensation, departmentName, startDate, double.Parse(hourRate), uint.Parse(hoursOfWork));


                        uint key = employeeHourly.EmployeeId;
                        employeeList[key] = employeeHourly;
                      
                        //prompt user to add course information
                        x = employeeHourly;
                        messageDisplay(Course);
                        print(employeeHourly.EmployeeId, employeeHourly.EmployeeType, employeeHourly.FirstName, employeeHourly.LastName, employeeHourly.Overtime, employeeHourly.Benefits, employeeHourly.EducationalBenefits, employeeHourly.Commision);
                        RTxtInfo.AppendText($"Hourly Rate:  {employeeHourly.HourlyRate } \n");
                        RTxtInfo.AppendText($"Hours Worked:  {employeeHourly.HoursWorked } \n");
                       

                    }


                }//end if 
                else if (CBXType.Text == "Contract")
                {
                    //set the visibility of components
                    LblOther.Visible = true;
                    TxtOther.Visible = true;
                    LblOther2.Visible = false;
                    TxtOther2.Visible = false;
                    LblOther.Text = "Contract wage";
                    //double wage;
                    //uint idNum;


                    if (string.IsNullOrEmpty(TxtOther.Text) == true)
                    {
                        MessageBox.Show("invalid  input ");
                    }
                    string _wage = TxtOther.Text.Trim();
                    string hoursOfWork = TxtOther2.Text.Trim();
                    //if (Double.TryParse(_wage, out wage) == true && uint.TryParse(id, out idNum) == true)
                    //{

                    //create new object for Contract employee
                    employeeContract = new Contract(uint.Parse(id), type, title, name, middleInitial, surname, married, overtime, benefits, educationBenefits, commission, compensation, departmentName, startDate, double.Parse(_wage));
                    //add employee to BusinessRules

                    uint key = employeeContract.EmployeeId;
                    employeeList[key] = employeeContract;
                  
                    x = employeeContract;
                    //prompt user to add course information
                    messageDisplay(Course);
                    print(employeeContract.EmployeeId, employeeContract.EmployeeType, employeeContract.FirstName, employeeContract.LastName, employeeContract.Overtime, employeeContract.Benefits, employeeContract.EducationalBenefits, employeeContract.Commision);
                    RTxtInfo.AppendText($"Contract Wage:  {employeeContract.ContractWage } \n");

                    //}//end if
                    //else
                    //{
                    //    MessageBox.Show("Invalid input try again");
                    //}//end else
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
                    //double commision;
                    //double sales;
                    uint idNum = uint.Parse(id);
                    double salary;
                    string commissionX = TxtOther.Text.Trim();
                    string salesX = TxtOther2.Text.Trim();
                    string salaryX = TxtOther3.Text.Trim();
                    //if (Double.TryParse(salaryX, out salary) == true && Double.TryParse(commissionX, out commision) == true && uint.TryParse(id, out idNum) == true && Double.TryParse(salesX, out sales) == true)
                    //{

                    if (string.IsNullOrEmpty(TxtOther2.Text) == true || string.IsNullOrEmpty(TxtOther3.Text) == true  )
                    {

                    }
                    else
                    {
                        //create new object for Sales employee
                        employeeSales = new Sales(idNum, type, title, name, middleInitial, surname, married, overtime, benefits, educationBenefits, commission, compensation, departmentName, startDate, double.Parse(salaryX), double.Parse(commissionX), double.Parse(salesX));
                        uint key = employeeSales.EmployeeId;
                        employeeList[key] = employeeSales;

                      
                        x = employeeSales;
                        //Initialize variables
                        employeeSales.EmployeeId = idNum;
                        employeeSales.EmployeeType = type;
                        employeeSales.FirstName = name;
                        employeeSales.LastName = surname;
                        employeeSales.MonthlySalary = double.Parse(salaryX);
                        //prompt user to add course information
                        messageDisplay(Course);
                        //display employee information on a rich textbox
                        print(employeeSales.EmployeeId, employeeSales.EmployeeType, employeeSales.FirstName, employeeSales.LastName, employeeSales.Overtime, employeeSales.Benefits, employeeSales.EducationalBenefits, employeeSales.Commision);
                        RTxtInfo.AppendText($"Commission:  {employeeSales.Commission } \n");
                        RTxtInfo.AppendText($"Gross sales:  {employeeSales.GrossSales } \n");
                        RTxtInfo.AppendText($"Monthly Salary:  {employeeSales.MonthlySalary } \n");
                     
                    }

                }
                 TxtOther.Clear();
                TxtID.Clear();
                TxtName.Clear();
                TxtOther2.Clear();
                TxtSurname.Clear();
                TxtOther3.Clear();
}

            
            
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
            if (RBtnID.Checked == true)
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
            else if (RBtnLast.Checked == true)
            {

                string lastName = TxtLastSearch.Text.Trim();

                //search for employee and store in variable
                Employee tempEmployee = employeeList.getEmployee(lastName);

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
            if (string.IsNullOrEmpty(TxtCourseId.Text) == true || string.IsNullOrEmpty(TxtDesc.Text) == true
                || string.IsNullOrEmpty(CBoxGrade.Text) == true || string.IsNullOrEmpty(TxtDesc.Text) == true)
            {
                MessageBox.Show("Invalid input try again");
            }
            else
            {
                 //clear richtextbox
                RTBoxCourse.Clear();

                string courseId = TxtCourseId.Text.Trim();
                string description = TxtDesc.Text.Trim();
                string grade = CBoxGrade.Text.Trim();
                DateTime approvalDate = dateTimePicker1.Value;

                uint credits=uint.Parse(CBoxCredits.Text.Trim());
                Course course;
               
                    //create course object based on user input
                    course = new Course(courseId, description, grade, approvalDate, credits);

                    //add course to courses list
                    //courses.Add(course);
                    x.AddCourses(course.CourseId, course);
                    RTxtInfo.AppendText(course.ToString());
                    //prompt user to add a course
                    messageDisplay(Course);
                    RTBoxCourse.AppendText(RTxtInfo.Text);

                    //display course that was added
                    // RTBoxCourse.AppendText(courses[0].ToString());

                
            }






        }

        private void TxtIdSearch_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event handler for validating id input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtIdSearch_Validating(object sender, CancelEventArgs e)
        {
            RtxtBSearch.Clear();

        

            string idPattern = @"^[0-9]{5,5}$";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(TxtIdSearch.Text))
            {
                EPEmpId.Clear();
                
              
            }
            else
            {
                EPEmpId.SetError(this.TxtIdSearch, "Invalid employee id  ");
                LblError.Text = "Invalid employee id";
                EPEmpId.Clear();
            }
 }
        /// <summary>
        /// event handler to validate employee id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtID_Validating(object sender, CancelEventArgs e)
        {
            string idPattern = @"^[0-9]{5,5}$";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(TxtID.Text)&& string.IsNullOrEmpty(TxtID.Text)!=true)
            {
                ErrorProv.Clear();
                LblEmpId.Text = "Input is valid";
            }//end if
                else
                {
                ErrorProv.SetError(this.TxtID, "Id should be 5 digits  ");

                LblEmpId.Text = "Numbers Only!";
                TxtID.Text = String.Empty;   //clear bad input from textbox
                TxtID.Focus();
            }//e

          
        


    }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// event handler to validate double input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtOther_Validating(object sender, CancelEventArgs e)
        {


            string idPattern = @"\d|[0-9][.][0-9]";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(TxtOther.Text))
            {
                ErrorProv.Clear();
             
            }//end if
            else
            {
                ErrorProv.SetError(this.TxtOther, "Only double values allowed  ");

                
                TxtOther.Text = String.Empty;   //clear bad input from textbox
               // TxtOther.Focus();
            }//e

        }

        private void TxtOther2_Validating(object sender, CancelEventArgs e)
        {
            

           //check if input is an int or double
            string idPattern = @"\d|[0-9][.][0-9]";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(TxtOther2.Text))
            {
                ErrorProv.Clear();

            }//end if
            else
            {
                ErrorProv.SetError(this.TxtOther2, "Only double values allowed  ");
                TxtOther2.Text = String.Empty;   //clear bad input from textbox
                //TxtOther2.Focus();
            }//e
        }
        /// <summary>
        /// event Handler to check if input is an int or double
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtOther3_Validating(object sender, CancelEventArgs e)
        {
            //check if input is an int or double
            string idPattern = @"\d|[0-9][.][0-9]";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(TxtOther3.Text))
            {
                ErrorProv.Clear();

            }//end if
            else
            {
                ErrorProv.SetError(this.TxtOther3, "Only double values allowed  ");
                TxtOther3.Text = String.Empty;   //clear bad input from textbox
               // TxtOther3.Focus();
            }//e
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            // check if input is an int or double
            string idPattern = @"[a-z]|[A-Z]";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(TxtName.Text))
            {
                ErrorProv.Clear();

            }//end if
            else
            {
                ErrorProv.SetError(this.TxtName, "Only double values allowed  ");
                TxtName.Text = String.Empty;   //clear bad input from textbox
               // TxtSurname.Focus();
            }//e
        }

        private void TxtSurname_Validating(object sender, CancelEventArgs e)
        {
            // check if input is an int or double
            string idPattern = @"[a-z]|[A-Z]";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(TxtSurname.Text))
            {
                EREducation.Clear();

            }//end if
            else
            {
                EREducation.SetError(this.TxtSurname, "Only double values allowed  ");
                TxtSurname.Text = String.Empty;   
            }//e
        }

        private void TxtLastSearch_Validating(object sender, CancelEventArgs e)
        {
            string idPattern = @"[a-z]|[A-Z]";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(TxtLastSearch.Text))
            {
                EPEmpId.Clear();


            }
            else
            {
                EPEmpId.SetError(this.TxtLastSearch, "Invalid course id   ");


            }
        }

        private void TxtCourseId_Validating(object sender, CancelEventArgs e)
        {
            string idPattern = @"[a-z]|[A-Z]|[0-9]";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(TxtCourseId.Text))
            {
                EREducation.Clear();


            }
            else
            {
                EREducation.SetError(this.TxtCourseId, "Invalid course id   ");


            }
        }

        private void TxtDesc_Validating(object sender, CancelEventArgs e)
        {


            string idPattern = @"[a-z]|[A-Z]|[0-9]";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(TxtDesc.Text))
            {
                EPEmpId.Clear();


            }
            else
            {
                EPEmpId.SetError(this.TxtDesc, "Invalid description  ");


            }
 }

        private void CBoxCredits_Validating(object sender, CancelEventArgs e)
        {

            string idPattern = @"[0-6]";
            Regex regex = new Regex(idPattern);

            if (regex.IsMatch(CBoxCredits.Text))
            {
                EPEmpId.Clear();


            }
            else
            {
                EPEmpId.SetError(this.CBoxCredits, "Invalid credits  ");


            }
        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Function for experimenting with sound
        /// </summary>
        private void playSound(string message)
        { 
        try
            {
                SpeechSynthesizer speech = new SpeechSynthesizer();
                speech.Speak(message);
            }
           catch(Exception exc)
            {

            }
}

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Exit application
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Lab 12 Employee database \n");
        }
    }
}
