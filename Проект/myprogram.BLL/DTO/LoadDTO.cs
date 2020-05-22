using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace myprogram.BLL.DTO
{
    public class LoadDTO
    {
        public int KodDial { get; set; }       
        public string NumberGroup { get; set; }
        public int KodSubject { get; set; }
        public int KodTeacher { get; set; }
        public string StudyYear { get; set; }
    }
}
