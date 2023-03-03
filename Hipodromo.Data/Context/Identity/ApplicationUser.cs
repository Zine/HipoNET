using Microsoft.AspNetCore.Identity;

namespace Hipodromo.Data.Context.Identity;

public class ApplicationUser : IdentityUser<Guid>
{
    public string Name { get; set; } = null!;
}