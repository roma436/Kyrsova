using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram;
using myprogram.BLL.DTO;
using myprogram.DAL.Models;
using myprogram.DAL.ViewModel;
using BlazorApp2.Data;

namespace myprogram.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Load, LoadDTO>();
            CreateMap<LoadDTO, Load>();
            CreateMap<Para, ParaDTO>();
            CreateMap<ParaDTO, Para>();
            CreateMap<Subject, SubjectDTO>();
            CreateMap<SubjectDTO, Subject>();
            CreateMap<Teacher, TeacherDTO>();
            CreateMap<TeacherDTO, Teacher>();

            CreateMap<User, RegisterViewModel>();

        }
    }
}
