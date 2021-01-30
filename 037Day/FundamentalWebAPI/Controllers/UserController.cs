using Microsoft.AspNetCore.Mvc;

namespace FundamentalWebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public string CreateUser()
        {
            return "Criando Usuário...";
        }

        [HttpDelete]
        public string DeleteUser()
        {
            return "Deletando Usuário...";
        }
    }
}