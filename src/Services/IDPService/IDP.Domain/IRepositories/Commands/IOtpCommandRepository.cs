using IDP.Domain.DTOs;
using IDP.Domain.IRepositories.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Domain.IRepositories.Commands
{
    public interface IOtpCommandRepository : ICommandRepository<OtpDto>
    {
    }
}
