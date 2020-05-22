using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace myprogram.BLL.DTO
{
    public class TeacherDTO
    {
        public int KodTeacher { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Degree { get; set; }
        public string Position { get; set; }
        public string Experience { get; set; }
    }
}
