using System;
using System.Collections.Generic;

namespace myprogram.DAL.Models
{
    public  class Load
    {
        public int KodDial { get; set; }
        public string NumberGroup { get; set; }
        public int KodSubject { get; set; }
        public int KodTeacher { get; set; }
        public string StudyYear { get; set; }

        public Subject KodSubjectNavigation { get; set; }
        public  Teacher KodTeacherNavigation { get; set; }
        public  Para Para { get; set; }
    }
}
