using Microsoft.AspNetCore.Mvc;

namespace sap_playground.Controllers;

[ApiController]
[Route("[controller]")]
public class CurlRequestController : ControllerBase
{
    private static readonly string[] Names = new[]
    {
        "JB", "Kenny", "Aaron", "Charlie"
    };

    private readonly ILogger<CurlRequestController> _logger;

    public CurlRequestController(ILogger<CurlRequestController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCurl")]
    public string Get()
    {
        Random rnd = new();
        int num = rnd.Next(0, Names.Length);
        string responseMessage = $"aye what up {Names[num]} this message is coming to you live from the orb\n";
        return responseMessage;
    }
}

