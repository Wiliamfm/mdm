using Microsoft.Extensions.DependencyInjection;
using Mdm.Application.Common.Interfaces.Persistence;
using Mdm.Application.Common.Interfaces.Security;
using Mdm.Infrastructure.Persistence;
using Mdm.Infrastructure.Persistence.Auth;
using Mdm.Infrastructure.Security;

namespace Mdm.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddPersistence();
        services.AddSecurity();

        return services;
    }

    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<AuthDbContext>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }

    public static IServiceCollection AddSecurity(this IServiceCollection services)
    {
        services.AddSingleton<IJwtGenerator, JwtGenerator>();

        return services;
    }
}
