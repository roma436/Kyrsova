using System;
using System.Collections.Generic;
using System.Text;

namespace myprogram.BLL.DTO
{
    public class ErrorResponseDTO
    {
        public ErrorResponseDTO() { }

        public ErrorResponseDTO(ErrorModelDTO error)
        {
            Errors.Add(error);
        }

        public List<ErrorModelDTO> Errors { get; set; } = new List<ErrorModelDTO>();
    }
}
