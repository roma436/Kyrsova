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
    public class LoadRepository : GenericRepository<Load>, ILoadRepository
    {
        public LoadRepository(karaContext context) : base(context)
        { }

        public IQueryable<Object> GetZaputByCodDial()
        {
            return from l in _context.Set<Load>()
                   join t in _context.Set<Teacher>() on l.KodTeacher equals t.KodTeacher
                   join s in _context.Set<Subject>() on l.KodSubject equals s.KodSubject
                   join p in _context.Set<Para>() on l.KodDial equals p.KodDial
                   orderby  l.NumberGroup 
                   select new
                   {
                       FirstName = t.FirstName,
                       SecondName = t.SecondName,
                       ThirdName = t.ThirdName,
                       nameSubject =  s.Name ,
                       NumberGroup = l.NumberGroup,
                       CountHour =  p.CountHours,
                       Typehours = p.TypeTraning
                       
                   };
        
        }

    }   

}
