using AutoMapper;
using Data.Identity;
using Entity.Services;
using Entity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
	public class AccountService : IAccountService
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly RoleManager<AppRole> _roleManager;
		private readonly SignInManager<AppUser> _signInManager;
		private readonly IMapper _mapper;

		public AccountService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IMapper mapper)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_signInManager = signInManager;
			_mapper = mapper;
		}

        public async Task<string> CreateRoleAsync(RoleViewModel model)
        {
            string message = string.Empty;
            AppRole role = new AppRole()
            {
                Name = model.Name,
                Descriotion = model.Descriotion
            };
            var identityResult = await _roleManager.CreateAsync(role);

            if (identityResult.Succeeded)
            {
                message = "OK";
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    message = error.Description;
                }
            }
            return message;
        }

        public async Task<string> CreateUserAsync(RegisterViewModel model)
		{
			string message = string.Empty;
			AppUser user = new AppUser()
			{
				Name = model.FirstName,
				Surname = model.LastName,
				Email = model.Email,
				PhoneNumber = model.PhoneNumber,
				UserName = model.UserName,
			};
			var idendtityResult = await _userManager.CreateAsync(user, model.ConfirmPassword);
			if (idendtityResult.Succeeded)
			{
				message = "OK";
			}
			else
			{
				foreach (var item in idendtityResult.Errors)
				{
					message = item.Description;
				}
			}
			return message;
		}

		public async Task<UserViewModel> Find(string username)
		{
			var user = await _userManager.FindByNameAsync(username);
			return _mapper.Map<UserViewModel>(user);
		}

		public async Task<string> FindByNameAsync(LoginViewModel model)
		{
			string message = string.Empty;
			var user = await _userManager.FindByNameAsync(model.UserName);
			if (user == null)
			{
				message = "Kullanıcı bulunamadı!";
				return message;
			}
			var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
			if (signInResult.Succeeded) { message = "OK"; }
			return message;
		}

        public async Task<List<RoleViewModel>> GetAllRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return _mapper.Map<List<RoleViewModel>>(roles);
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
