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
    public class ParaRepository : GenericRepository<Para>, IParaRepository
    {
        public ParaRepository(karaContext context) : base(context)
        { }

        public IQueryable<Object> GetParaByCodDial()
        {
            return from p in _context.Set<Para>()
                   join l in _context.Set<Load>() on p.KodDial equals l.KodDial
                   join s in _context.Set<Subject>() on l.KodSubject equals s.KodSubject 
                   orderby l.NumberGroup
                   select new
                   {
                       NumberGroup = l.NumberGroup,
                       NameSubject = s.Name,
                       TypeTraning = p.TypeTraning,
                       CountHours = p.CountHours
                   };
        }
    }
}