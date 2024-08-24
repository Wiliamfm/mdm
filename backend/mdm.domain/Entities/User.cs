using Microsoft.AspNetCore.Identity;

namespace Mdm.Domain.Entities;

public class User : AuditEntity
{
    private IPasswordHasher<User> _passwordHasher = new PasswordHasher<User>();
    private string _password = null!;

    public Ulid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password
    {
        get => _password;
        set => _password = _passwordHasher.HashPassword(this, value);
    }
    public bool IsActive { get; set; } = true;
    public ICollection<Role> Roles { get; set; } = new List<Role>();

    public User() { }

    public User(IPasswordHasher<User> passwordHasher)
    {
        _passwordHasher = passwordHasher;
    }

    public bool VerifyPassword(string password)
    {
        return _passwordHasher?.VerifyHashedPassword(this, _password, password) == PasswordVerificationResult.Success;
    }
}
