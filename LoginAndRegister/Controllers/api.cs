using LoginAndRegister.Areas.Identity.Data;
using LoginAndRegister.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
  [ApiController]
  [Route("api/cities")]
  public class api : ControllerBase
  {
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public api(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IHttpContextAccessor httpContextAccessor)
    {
      _userManager = userManager;
      _roleManager = roleManager;
      _httpContextAccessor = httpContextAccessor;
    }
    [HttpGet]
    public IEnumerable<string> GetCities()
    {
      return new string[] { "a", "b", "c", "d" };
    }
    [HttpGet("users")]
  
    public async Task<IEnumerable<UserRolesViewModel>> roles()
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
      return (userRolesViewModel);
    }
  }
}
