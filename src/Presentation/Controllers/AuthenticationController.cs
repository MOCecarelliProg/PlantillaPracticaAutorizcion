using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        //Inyectar el ICustomAuthenticationService

        [HttpPost]
        public ActionResult<string> Authenticate([FromBody] AuthenticationRequestDTO authenticationRequestDTO)
        {
            return _customAuthenticationService.Authenticate(authenticationRequestDTO);
        }
    }
}
