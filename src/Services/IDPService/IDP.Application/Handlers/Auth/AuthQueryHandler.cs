using Auth;
using IDP.Application.Queries.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Handlers.Auth
{
    public class AuthQueryHandler : IRequestHandler<AuthQuery, bool>
    {
        private readonly IjwtHandler _jwtHandler;

        public AuthQueryHandler(IjwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
        }

        public async Task<bool> Handle(AuthQuery request, CancellationToken cancellationToken)
        {
            var token = _jwtHandler.Create(10);

            return true;
        }
    }
}
