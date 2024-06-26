using Microsoft.AspNetCore.Mvc;

namespace InfoVesao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult GetNone()
        {
            return Ok("Vers�o 1");
        }
    }
}
