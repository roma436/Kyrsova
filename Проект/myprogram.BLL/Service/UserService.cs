using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using myprogram.DAL.Interface;
using myprogram.BLL.Interface;
using myprogram.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace myprogram.BLL.Service
{
    public class UserService : IUserService
    {
        private IUnitOfWork _UnitOfWork { get; set; }
        //private UserManager<IdentityUser> _userManger;
        private IConfiguration _configuration;

        public UserService(IUnitOfWork uow, IConfiguration configuration)
        {
            _UnitOfWork = uow;
            _configuration = configuration;

        }

        public async Task<UserManagerResponse> RegisterUserAsync(RegisterViewModel model)
        {
            if (model == null)
                throw new NullReferenceException("Модель реєстрації є нульовою");

            if (model.Password != model.ConfirmPassword)
                return new UserManagerResponse
                {
                    Message = "Паролі не співпадають  ",
                    IsSuccess = false,
                };

            var identityUser = new IdentityUser
            {
                Email = model.Email,
                UserName = model.Email,
            };

            var result = await _UnitOfWork.UserManager.CreateAsync(identityUser, model.Password);

            if (result.Succeeded)
            {
                return new UserManagerResponse
                {
                    Message = "Користувач створений успішно !",
                    IsSuccess = true,
                };
            }

            return new UserManagerResponse
            {
                Message = "користувач не може створити",
                IsSuccess = false,
                Errors = result.Errors.Select(e => e.Description)
            };

        }

        public async Task<UserManagerResponse> LoginUserAsync(LoginViewModel model)
        {
            var user = await _UnitOfWork.UserManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                return new UserManagerResponse
                {
                    Message = "Немає користувача з цією електронною адресою",
                    IsSuccess = false,
                };
            }

            var result = await _UnitOfWork.UserManager.CheckPasswordAsync(user, model.Password);

            if (!result)
                return new UserManagerResponse
                {
                    Message = "Не правильний пароль",
                    IsSuccess = false,
                };

            var claims = new[]
            {
                new Claim("Email", model.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["AuthSettings:Key"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["AuthSettings:Issuer"],
                audience: _configuration["AuthSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(30),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            string tokenAsString = new JwtSecurityTokenHandler().WriteToken(token);

            return new UserManagerResponse
            {
                Message = tokenAsString,
                IsSuccess = true,
                ExpireDate = token.ValidTo
            };
        }
    }




}
