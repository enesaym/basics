using HelloWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi.Controllers
{
    [ApiController]
    [Route("home")]
    //urlin basina gelir home
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult getMessage() {
            var result = new ResponseModel()
            {
                HttpsStatus = 200,
                Message = "Ok"
            };
            return Ok(result);
            } 

            
    }
}
