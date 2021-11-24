namespace WebApplication1.Multitenancy;

public interface ITenantResolver<out TService>
{
    TService Resolve();
}