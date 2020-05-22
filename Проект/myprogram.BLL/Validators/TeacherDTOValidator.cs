using FluentValidation;
using myprogram.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace myprogram.BLL.Validators
{
    public class TeacherDTOValidator : AbstractValidator<TeacherDTO>
    {
        public TeacherDTOValidator()
        {
            RuleFor(x => x.FirstName)
                      .NotEmpty()
                      .Length(2, 40)
                      .Matches("^[а-яА-ЯёЁ]+$");

            RuleFor(x => x.SecondName)
                      .NotEmpty()
                      .Length(2, 40)
                      .Matches("^[а-яА-ЯёЁ]+$");

            RuleFor(x => x.ThirdName)
                      .NotEmpty()
                      .Length(2, 40)
                      .Matches("^[а-яА-ЯёЁ]+$");
            RuleFor(x => x.Degree)
            .NotEmpty()
            .Matches("^[а-яА-ЯёЁ_-]{3,16}$");
            


            RuleFor(x => x.Experience)
                      .NotEmpty()
                      .Matches("^[0-9]+$");

            
        }
    }
}
