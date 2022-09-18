using Microsoft.AspNetCore.Mvc;

namespace VisualAcademy.Apis;

[Route("api/backgroundchecks")]
public class BackgroundChecksController : ControllerBase
{
    [HttpGet]
    public object Get()
        => new { Description = "VisualAcademy Background Check" };
}

