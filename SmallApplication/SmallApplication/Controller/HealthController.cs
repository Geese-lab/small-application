using Microsoft.AspNetCore.Mvc;
using SmallApplication.Constants;

namespace SmallApplication.Controller;

[ApiController]
[Route(ApiRoutes.Health)]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Status()
    { 
        return Ok(new { status = "Healthy" });
    }
}
