using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Graphics : Degree
    //inherit from degree

    {
        //--------------create new student entry------------------- 

        public Graphics(string course_title): base(course_title)
        {
            base.StudentName = "David Singer";
            base.StudentId = 13428876;
        }
    }
}
