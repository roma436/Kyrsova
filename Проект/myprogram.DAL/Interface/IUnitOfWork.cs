

using Microsoft.AspNetCore.Identity;
using myprogram.DAL.Interface;
using myprogram.DAL.Repository;
using System.Threading.Tasks;

namespace myprogram.DAL.Interface
{
     public interface IUnitOfWork
     {
        ILoadRepository LoadRepository { get; }
        IParaRepository ParaRepository { get; }
        ISubjectRepository SubjectRepository { get; }
        ITeacherRepository TeacherRepository { get; }
        Task Complete();

        public UserManager<IdentityUser> UserManager { get; set; }
        public RoleManager<IdentityRole> RoleManager { get; set; }
        public SignInManager<IdentityUser> SignInManager { get; set; }
     }
}