using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Multitenancy;

public class ApplicationUser : IdentityUser
{
    public string TenantId { get; set; }
}