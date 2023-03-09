using Microsoft.AspNetCore.Mvc;

namespace sap_playground.Controllers;

[ApiController]
[Route("[controller]")]
public class CurlRequestController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CurlRequestController> _logger;

    public CurlRequestController(ILogger<CurlRequestController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCurl")]
    public string Get()
    {
        return "";
    }
}

