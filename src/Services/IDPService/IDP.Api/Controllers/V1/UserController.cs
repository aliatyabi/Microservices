﻿using Asp.Versioning;
using IDP.Api.Controllers.Base;
using IDP.Application.Commands.User;
using IDP.Application.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IDP.Api.Controllers.V1
{
    [Route("api/v{v:apiVersion}/[controller]")]
    [ApiVersion(1)]
    [ApiVersion(2)]
    public class UserController : BaseController
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// ایجاد کاربر
        /// </summary>
        /// <param name="userCommand"></param>
        /// <returns></returns>
        [Route("AddUser")]
        [HttpPost]
        [MapToApiVersion(1)]
        public async Task<IActionResult> AddUser([FromBody] UserCommand userCommand)
        {
            var res = await _mediator.Send(userCommand);

            return Ok(res);
        }
    }
}
