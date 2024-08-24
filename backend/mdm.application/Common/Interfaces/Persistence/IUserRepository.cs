using Mdm.Domain.Entities;

namespace Mdm.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    Task<User> GetAsync(Ulid id);
    Task<User> GetAsync(string email);
    Task AddAsync(User user);
}
