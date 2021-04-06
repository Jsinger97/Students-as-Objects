using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Biology : Degree
    //inherit from degree

    {
        //--------------create new student entry------------------- 

        public Biology(string course_title): base(course_title)
        {
            base.StudentName = "Mark Spade";
            base.StudentId = 13467786;
        }
    }
}
