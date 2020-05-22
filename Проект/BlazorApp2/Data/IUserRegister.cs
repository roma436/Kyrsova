using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    interface IUserRegister
    {
        public Task Create(User user);
    }
}
