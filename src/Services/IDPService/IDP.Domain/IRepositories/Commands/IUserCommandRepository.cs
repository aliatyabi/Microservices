using IDP.Domain.Entities;
using IDP.Domain.IRepositories.Commands.Base;

namespace IDP.Domain.IRepositories.Commands
{
    public interface IUserCommandRepository : ICommandRepository<User>
    {
    }
}
