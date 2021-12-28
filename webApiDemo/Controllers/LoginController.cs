using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using webApiDemo.Models;

namespace webApiDemo.Controllers
{
    //[Route("api/[controller]/[action]")]
    [Route("api/[controller]")] //restful
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public string Get(string userNo, string password)
        {
            SqlHelp sqlContion = new SqlHelp();
            string sql = "";
            DataRow dr = sqlContion.Command(sql);
            User user = new User();
            user.Id = dr["Id"]?.ToString().Trim();
            user.Name = dr["Name"]?.ToString().Trim();
            user.PassWorld = dr["Password"]?.ToString().Trim();
            return "get it select sql";
        }
        [HttpPost]
        public string Post()
        {
            return "Post it insert sql";
        }
        [HttpPut]
        public string Put()
        {
            return "Put it update sql";
        }
        [HttpDelete]
        public string Remove()
        {
            return "Remove it Delete sql";
        }

        private void CheckedLogin(string userid, string password)
        {
            
        }
    }
}
