using Mdm.Application.Common.Interfaces.Security;
using Mdm.Domain.Entities;

namespace Mdm.Infrastructure.Security;

public class JwtGenerator : IJwtGenerator
{
    public string GenerateToken(User user)
    {
        throw new NotImplementedException();
    }
}
