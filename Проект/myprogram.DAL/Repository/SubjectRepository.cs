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
    public class SubjectRepository : GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(karaContext context) : base(context)
        { }
        public Subject GetSubjectByName(string Name)
        {
            return _context.Set<Subject>().FirstOrDefault(s => s.Name == Name); 
        }
    }
}
