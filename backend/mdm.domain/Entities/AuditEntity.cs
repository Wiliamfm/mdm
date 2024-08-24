namespace Mdm.Domain.Entities;

public abstract class AuditEntity
{
    public DateTimeOffset Created { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTimeOffset? Updated { get; set; }
    public Guid? UpdatedBy { get; set; }
}
