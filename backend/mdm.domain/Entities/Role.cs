namespace Mdm.Domain.Entities;

public class Role: AuditEntity
{
    public Ulid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public ICollection<User> Users { get; set; } = null!;
}
