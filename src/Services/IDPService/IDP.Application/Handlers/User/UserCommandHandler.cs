using IDP.Application.Commands.User;
using IDP.Domain.IRepositories.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Handlers.User
{
    public class UserCommandHandler : IRequestHandler<UserCommand, bool>
    {
        private readonly IUserRepository _userRepository;

        public UserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(UserCommand request, CancellationToken cancellationToken)
        {
            var res = await _userRepository.Insert(new Domain.Entities.User
            {
                Fullname = request.Fullname,
                NationalCode = request.NationalCode
            });

            return res;
        }
    }
}
