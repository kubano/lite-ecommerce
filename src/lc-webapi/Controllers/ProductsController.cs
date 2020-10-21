using Microsoft.AspNetCore.Mvc;

namespace Webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("we have data");
        }
    }
}