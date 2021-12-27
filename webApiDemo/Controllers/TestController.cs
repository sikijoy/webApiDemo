using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webApiDemo.Controllers
{
    //http://根目录/api/Test  路由
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("any")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "hello world";
        }

    }

    //依赖注入有个容器 容器是一个线程内安全的字典
}
