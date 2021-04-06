using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    //Inherit from interface 
    class Degree : IComparable
    {        
        //-----------Intilize attributes---------------

        private string course_title;
        //Intilize person as student
        private Person student;

        public Degree(string course_title)
        {
            this.course_title = course_title;
            student = new Person();
        }

        public string StudentName
        {
            get { return student.Name; }
            set { student.Name = value; }
        }
        public int StudentId
        {
            get { return student.ID; }
            set { student.ID = value; }
        }

        public int CompareTo(Object obj)
        {
            Degree other = (Degree)obj;
            return course_title.CompareTo(other.course_title);
        }

        public string getsummmery
        {
            get
            {    //return a nicely formatted string 
                return string.Format("{0}, {1}, {2}",student.Name,course_title, student.ID);

            }
        }
    }

}