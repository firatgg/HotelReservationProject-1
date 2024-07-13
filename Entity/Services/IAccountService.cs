using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
	public interface IAccountService
	{
		Task<string> CreateUserAsync(RegisterViewModel model);
		Task<string> FindByNameAsync(LoginViewModel model);

		Task<UserViewModel> Find(string username);
        Task<string> CreateRoleAsync(RoleViewModel model);
        Task<List<RoleViewModel>> GetAllRoles();

        Task SignOutAsync();
    }
}
