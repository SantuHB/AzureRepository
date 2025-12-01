using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDeploy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("Details")]
        public IActionResult GetDetails()
        {
            return Ok(new string[] {"Amazon","Flipkart"});
        }
    }
}
