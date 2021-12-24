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

        public Course(string courseId, string description, string grade, DateTime approvalDate,uint credits)
        {
            this.courseId = courseId;
            this.description = description;
            this.grade = grade;
            this.approvalDate = approvalDate;
            this.credits = credits;
        }

        public uint Credits { set; get; }
        public DateTime ApprovalDate { set; get; }
        public string CourseId { set { courseId = value; } get { return courseId; } }
        public string Grade { set; get; }
        public string Description { set; get; }

        public override string ToString()
        {
            return "Course ID "+courseId + "\nCourse description " + description + " \nGrade " + grade + " \nDate " + approvalDate.ToString() + "\n Credits  " + credits;
        }

    }
}
