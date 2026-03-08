using Microsoft.AspNetCore.Mvc;

namespace SmallApplication.Controller;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Status()
    { 
        return Ok(new { status = "Healthy" });
    }
}
