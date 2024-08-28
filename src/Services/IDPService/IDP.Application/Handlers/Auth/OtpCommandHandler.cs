using IDP.Application.Commands.Auth;
using IDP.Domain.IRepositories.Commands;
using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Handlers.Auth
{
    public class OtpCommandHandler : IRequestHandler<OtpCommand, bool>
    {
        private readonly IOtpCommandRepository _otpCommandRepository;

        public OtpCommandHandler(IOtpCommandRepository otpCommandRepository)
        {
            _otpCommandRepository = otpCommandRepository;
        }

        public async Task<bool> Handle(OtpCommand request, CancellationToken cancellationToken)
        {
            await _otpCommandRepository.Insert(new Domain.DTOs.OtpDto { UserId = 15, OtpCode = "17918", IsUsed = false });

            return true;
        }
    }
}
