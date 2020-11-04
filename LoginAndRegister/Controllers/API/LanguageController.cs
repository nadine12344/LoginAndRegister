using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Threading.Tasks;
namespace LoginAndRegister.Controllers.API
{
  [Route("api/[controller]")]
  [ApiController]
  public class LanguageController : ControllerBase
  {
    private readonly IStringLocalizer<LanguageController> _localizer;
    public LanguageController(IStringLocalizer<LanguageController> localizer)
    {
      _localizer = localizer;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var guid = Guid.NewGuid();
      return Ok(_localizer["Home", guid.ToString()].Value);
    }
  }
}
