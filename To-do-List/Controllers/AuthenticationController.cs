using Application.Interfaces;
using Contract.AuthenticationModel.Request;
using Microsoft.AspNetCore.Mvc;

namespace To_do_List.Controllers
{

    public class AuthenticationController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IAuthenticationService _customAuthenticationService;

        public AuthenticationController(IConfiguration config, IAuthenticationService customAuthenticationService)
        {
            _config = config;
            _customAuthenticationService = customAuthenticationService;
        }

        [HttpPost("Autenticate")]
        public ActionResult<string> Autenticate(AuthenticationRequest request)
        {
            string token = _customAuthenticationService.Authenticate(request);
            return Ok(token);
        }
    }
}
