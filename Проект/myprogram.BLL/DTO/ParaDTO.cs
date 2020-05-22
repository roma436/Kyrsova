using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace myprogram.BLL.DTO
{
    public class ParaDTO
    {
        public int KodDial { get; set; }
        public int CountHours { get; set; }
        public string TypeTraning { get; set; }
    }
}
