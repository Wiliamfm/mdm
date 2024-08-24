using Mdm.Domain.Entities;

namespace Mdm.Application.Common.Interfaces.Security;

public interface IJwtGenerator
{
    string GenerateToken(User user);
}
