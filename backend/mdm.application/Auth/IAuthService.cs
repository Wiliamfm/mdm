namespace Mdm.Application.Auth;

public interface IAuthService
{
    Task<AuthResponse> Register(string email, string password, string name);
    Task<AuthResponse> Login(string email, string password);
    Task Logout(string email);
}
