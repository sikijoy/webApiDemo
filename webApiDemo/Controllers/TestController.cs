using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webApiDemo.Controllers
{
    //http://根目录/api/Test  路由
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "hello world";
        }
    }
}
