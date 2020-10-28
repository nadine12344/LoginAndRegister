using LoginAndRegister.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndRegister.Controllers
{
    
    public class AdminstrationController:Controller
    {
        private readonly RoleManager<IdentityRole> roleManger;

        public AdminstrationController(RoleManager<IdentityRole> roleManger)
        {
            this.roleManger = roleManger;
        }
        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateRole(CreateRole role)
        {
            var roleExists = await roleManger.RoleExistsAsync(role.RoleName);
            if (!roleExists)
            {
                var results=await roleManger.CreateAsync(new IdentityRole(role.RoleName));
            }
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult CreateRole()
        {
 
            return View();
        }
   
    [HttpGet]
    public IActionResult RoleList()
        {
            var roles = roleManger.Roles;
            return View(roles);
        }
    }
}
