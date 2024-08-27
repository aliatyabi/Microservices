using Asp.Versioning;
using IDP.Api.Controllers.Base;
using IDP.Application.Queries.Auth;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IDP.Api.Controllers.V1
{
    [Route("api/v{v:apiVersion}/[controller]")]
    [ApiVersion(1)]
    [ApiVersion(2)]
    public class AuthController : BaseController
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(AuthQuery authQuery)
        {
            var result = await _mediator.Send(authQuery);

            return Ok(result);
        }
    }
}
