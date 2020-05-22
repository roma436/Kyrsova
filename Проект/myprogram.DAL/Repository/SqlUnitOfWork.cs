using Microsoft.AspNetCore.Identity;
using myprogram.DAL;
using myprogram.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myprogram.DAL.Repository
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private ILoadRepository _LoadRepository;
        private IParaRepository _ParaRepository;
        private ISubjectRepository _SubjectRepository;
        private ITeacherRepository _TeacherRepository;
        public UserManager<IdentityUser> UserManager { get; set; }
        public RoleManager<IdentityRole> RoleManager { get; set; }
        public SignInManager<IdentityUser> SignInManager { get; set; }
        private karaContext _context;

        public SqlUnitOfWork(ILoadRepository LoadRepository, IParaRepository ParaRepository , 
            ISubjectRepository SubjectRepository , ITeacherRepository TeacherRepository ,
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager,karaContext context)
        {
            _LoadRepository = LoadRepository;
            _ParaRepository = ParaRepository;
            _SubjectRepository = SubjectRepository;
            _TeacherRepository = TeacherRepository;
            _context = context;
            UserManager = userManager;
            RoleManager = roleManager;
            SignInManager = signInManager;
        }

        public ILoadRepository LoadRepository
        {
            get
            {
                return _LoadRepository;
            }
        }

        public IParaRepository ParaRepository
        {
            get
            {
                return _ParaRepository;
            }
        }
        public ISubjectRepository SubjectRepository
        {
            get
            {
                return _SubjectRepository;
            }
        }
        public ITeacherRepository TeacherRepository
        {
            get
            {
                return _TeacherRepository;
            }
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }
    }
}
