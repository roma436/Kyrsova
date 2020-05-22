using System;
using System.Collections.Generic;

namespace myprogram.DAL.Models
{
    public  class Teacher
    {
        public Teacher()
        {
            Load = new HashSet<Load>();
        }

        public int KodTeacher { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Degree { get; set; }
        public string Position { get; set; }
        public string Experience { get; set; }

        public  ICollection<Load> Load { get; set; }
    }
}
