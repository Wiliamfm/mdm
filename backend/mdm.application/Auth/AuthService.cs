using Mdm.Application.Common.Interfaces.Persistence;
using Mdm.Application.Common.Interfaces.Security;
using Mdm.Domain.Entities;

namespace Mdm.Application.Auth;

public class AuthService(IUserRepository userRepository, IJwtGenerator jwtGenerator) : IAuthService
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IJwtGenerator _jwtGenerator = jwtGenerator;

    public async Task<AuthResponse> Register(string email, string password, string name)
    {
        var user = await _userRepository.GetAsync(email);
        if (user != null)
        {
            //TODO: Changes throw exception flow.
            throw new Exception("User already exists");
        }
        user = new User()
        {
            Email = email,
            Name = name,
            Password = password
        };

        return new AuthResponse
        (
            token: _jwtGenerator.GenerateToken(user)
        );
    }

    public async Task<AuthResponse> Login(string email, string password)
    {
        var user = await _userRepository.GetAsync(email);
        if (user == null || !user.VerifyPassword(password))
        {
            //TODO: Changes throw exception flow.
            throw new Exception("Invalid credentials");
        }

        return new AuthResponse
        (
            token: _jwtGenerator.GenerateToken(user)
        );
    }

    public Task Logout(string email)
    {
        throw new NotImplementedException("Implement token invalidation here.");
    }
}
