using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Forensics : Degree
        //inherit from degree
    {
        //--------------create new student entry------------------- 

        public Forensics(string course_title) : base(course_title)
        {
            base.StudentName = "Sopie Walford";
            base.StudentId = 13456654;
        }
    }
}
