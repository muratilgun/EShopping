using Catalog.Application.Services.IRepositories;
using Catalog.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<ITypeRepository, TypeRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        
        return services;
    }
}