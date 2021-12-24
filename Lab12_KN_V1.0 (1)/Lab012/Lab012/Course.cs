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

namespace EmployeeDB
{
    [Serializable]
    public class Course
    {

        private string courseId;
        private string description;
        private string grade;
        private DateTime approvalDate;
        private uint credits;

        /// <summary>
        /// course constructor for initializing variables
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="description"></param>
        /// <param name="grade"></param>
        /// <param name="approvalDate"></param>
        /// <param name="credits"></param>
        public Course(string courseId, string description, string grade, DateTime approvalDate, uint credits)
        {
            this.courseId = courseId;
            this.description = description;
            this.grade = grade;
            this.approvalDate = approvalDate;
            this.credits = credits;
        }
        /// <summary>
        /// property for credits
        /// </summary>
        public uint Credits { set; get; }
        /// <summary>
        /// property for approval date
        /// </summary>
        public DateTime ApprovalDate { set; get; }
        /// <summary>
        /// Property for courseId
        /// </summary>
        public string CourseId { set { courseId = value; } get { return courseId; } }

        /// <summary>
        /// Property for grade
        /// </summary>
        public string Grade { set; get; }

        /// <summary>
        /// Property for Description
        /// </summary>
        public string Description { set; get; }

        /// <summary>
        /// ToString function for writing Course data as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Course ID " + courseId + "\nCourse description " + description + " \nGrade " + grade + " \nDate " + approvalDate.ToString() + "\n Credits  " + credits;
        }

    }
}
