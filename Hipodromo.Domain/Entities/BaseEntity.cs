namespace Hipodromo.Domain.Entities;

public record BaseEntity
{
    public Guid Id { get; set; }
    public bool Active { get; set; } = true;
    public bool Deleted { get; set; } = false;
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}