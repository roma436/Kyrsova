using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace myprogram.BLL.DTO
{
    public class SubjectDTO
    {
        public int KodSubject { get; set; }
        public string Name { get; set; }
    }
}
