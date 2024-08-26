using IDP.Domain.Entities;
using IDP.Domain.IRepositories.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Infrastructure.Repositories.Commands
{
    public class UserRepository : IUserRepository
    {
        public async Task<bool> Insert(User user)
        {
            return true;
        }
    }
}
