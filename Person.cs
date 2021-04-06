using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Students
{   //Person Class to repersent each student using IComparable interface

    class Person : IComparable
    {
        //-----------Intilize attributes---------------
        private string name;
        private int id;

        public Person()
        {
        }

        //-------------Constructor with two arguments---
        public Person(String name, int id)
        {
            this.name = name;
            this.id = id;
        }
        //--------------properties----------------------
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        //----Implementation of CompareTo using IComparable
        public int CompareTo(Object obj)
        {
            Person other = (Person)obj;
            return Name.CompareTo(other.Name);
        }


    }
}
