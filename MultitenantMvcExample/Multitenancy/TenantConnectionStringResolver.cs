using System.Security.Claims;

namespace WebApplication1.Multitenancy;

internal class TenantConnectionStringResolver : ITenantResolver<string>
{
    private readonly ClaimsPrincipal _user;
    private readonly IConfiguration _configuration;

    public TenantConnectionStringResolver(ClaimsPrincipal user, IConfiguration configuration)
    {
        _user = user;
        _configuration = configuration;
    }

    public string Resolve()
    {
        var tenantId = _user.Claims.SingleOrDefault(c => c.Type == "tenantId");
        var connectionString = _configuration.GetConnectionString($"App_{tenantId.Value}");
        return connectionString;
    }
}