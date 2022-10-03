using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSheet
{
     class Course
    {
        private String courseName;
        private String grade;
        private String credits;
        private int index;

        public Course(String courseName, String grade, String credits, int index)
        {
            this.courseName = courseName;
            this.grade = grade;
            this.credits = credits;
            this.index = index;

        }
        //get and set methods
        public String CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public String Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public String Credits
        {
            get { return credits; }
            set { credits = value; }
        }

    }
}
