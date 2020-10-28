using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LoginAndRegister.Areas.Identity.Data;
using LoginAndRegister.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginAndRegister.Controllers
{
    public class UserRolesController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserRolesController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _httpContextAccessor=httpContextAccessor;
    }
      
        public async Task<IActionResult> mydepartment()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            AppUser app= await _userManager.FindByIdAsync(userId);
            // get user roles
            List<string> role= new List<string>(await _userManager.GetRolesAsync(app));
        
            string role1 = role.ElementAt(0);
            var users = await _userManager.Users.ToListAsync();
            var userRolesViewModel = new List<UserRolesViewModel>();
            foreach (AppUser user in users)
            {
                List<string> r = new List<string>(await _userManager.GetRolesAsync(user));
                string[] r2 = role1.Split(' ');
                if (r.Contains(role1)||r.ElementAt(0).Contains(role1) || r.Contains( r2[0] ))
                {
                    
                    var thisViewModel = new UserRolesViewModel();
                    thisViewModel.UserId = user.Id;
                    thisViewModel.Email = user.Email;
                    thisViewModel.FirstName = user.FirstName;
                    thisViewModel.Roles = r;

                    userRolesViewModel.Add(thisViewModel);
                }
            }
            return View(userRolesViewModel);
        }
        public async Task<IActionResult> roles()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRolesViewModel = new List<UserRolesViewModel>();
            foreach (AppUser user in users)
            {
                List<string> r = new List<string>(await _userManager.GetRolesAsync(user));


                    var thisViewModel = new UserRolesViewModel();
                    thisViewModel.UserId = user.Id;
                    thisViewModel.Email = user.Email;
                    thisViewModel.FirstName = user.FirstName;
                    thisViewModel.Roles = r;

                    userRolesViewModel.Add(thisViewModel);
                
            }
            return View(userRolesViewModel);
        }

    }

}
