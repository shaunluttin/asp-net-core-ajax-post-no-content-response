using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreAjaxOkResponse.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost("api/values")]
        public IActionResult Post() => new OkResult();

        [HttpPost("api/values1")]
        public IActionResult Post1() => new StatusCodeResult(204); 

        [HttpPost("api/values2")]
        public IActionResult Post2() => Ok("");

        [HttpPost("api/values3")]
        public IActionResult Post3() => new OkObjectResult("");
    }
}
