namespace Hipodromo.Domain.Entities;

public record Racecourse : BaseEntity
{
    public string Name { get; set; } = string.Empty;
}