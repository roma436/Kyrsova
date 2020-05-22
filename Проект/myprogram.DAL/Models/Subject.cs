using System;
using System.Collections.Generic;

namespace myprogram.DAL.Models
{
    public  class Subject
    {
        public Subject()
        {
            Load = new HashSet<Load>();
        }

        public int KodSubject { get; set; }
        public string Name { get; set; }

        public  ICollection<Load> Load { get; set; }
    }
}
