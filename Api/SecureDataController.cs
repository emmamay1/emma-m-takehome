using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SecureDataController : ControllerBase
{
    [Authorize]
    [HttpGet]
    public IActionResult GetSecureData()
    {
        return Ok(new { Message = "This is secured data, accessible only after Google authentication." });
    }
}
