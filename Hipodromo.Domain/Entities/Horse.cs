namespace Hipodromo.Domain.Entities;

public record Horse : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public Guid StableId { get; set; }
}