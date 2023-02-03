using Decompose.Service;
using Microsoft.AspNetCore.Mvc;

namespace Decompose.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int number)
        {
            var decompose = new VerifyNumberService();

            var response = decompose.Decompose(number);

            return response != null ? Ok(response) : NotFound();
        }
    }
}
