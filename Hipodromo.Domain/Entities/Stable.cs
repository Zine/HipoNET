namespace Hipodromo.Domain.Entities;

public record Stable : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public Guid RacecourseId { get; set; }
}