using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public Grade? Grade { get; set; }

        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        public int StudentID { get; set; }
        public virtual Student Stundet { get; set; }
    }
}
