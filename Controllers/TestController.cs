using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityJwtApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController: Controller
{
    [Authorize(Roles = "User")]
    [HttpGet("User")]
    public IActionResult Get()
    {
        var username = User.Identity?.Name;
        return Ok($"Test for User {username}");
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("Admin")]
    public IActionResult GetAdmin()
    {
        var username = User.Identity?.Name;
        return Ok($"Test for Admin {username}");
    }
    
}