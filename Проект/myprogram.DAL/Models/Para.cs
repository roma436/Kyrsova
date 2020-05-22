using System;
using System.Collections.Generic;

namespace myprogram.DAL.Models
{
    public  class Para
    {
        public int KodDial { get; set; }
        public int CountHours { get; set; }
        public string TypeTraning { get; set; }

        public  Load KodDialNavigation { get; set; }
    }
}
