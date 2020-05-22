using FluentValidation;
using myprogram.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace myprogram.BLL.Validators
{
    public class LoadDTOValidator : AbstractValidator<LoadDTO>
    {
        public LoadDTOValidator()
        {
            RuleFor(x => x.NumberGroup)
                      .NotEmpty()
                      .Length(40)
                      .Matches("^[а-яА-ЯёЁ_-0-9]+$");
            RuleFor(x => x.KodSubject)
                .NotEmpty();

            RuleFor(x => x.KodTeacher)
            .NotEmpty();

            RuleFor(x => x.StudyYear)
            .NotEmpty()
            .Matches("^20[0-9][0-9]/[0-9][0-9]");
        }
    }
}
