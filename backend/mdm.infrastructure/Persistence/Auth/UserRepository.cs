using Mdm.Application.Common.Interfaces.Persistence;
using Mdm.Domain.Entities;

namespace Mdm.Infrastructure.Persistence;

public class UserRepository() : IUserRepository
{
    public Task AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetAsync(Ulid id)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetAsync(string email)
    {
        throw new NotImplementedException();
    }
}
