using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public string Get() => "Sample controller working";
}
