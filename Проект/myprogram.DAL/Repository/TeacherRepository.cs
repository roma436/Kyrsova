using myprogram.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using myprogram.DAL.Models;

namespace myprogram.DAL.Repository

{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(karaContext context) : base(context)
        { }
        

    }
}