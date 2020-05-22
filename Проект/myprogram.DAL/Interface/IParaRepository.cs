﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace myprogram.DAL.Interface
{
    public interface IParaRepository:IGenericRepository<Para>
    {
        public IQueryable<Object> GetParaByCodDial();

    }
}
