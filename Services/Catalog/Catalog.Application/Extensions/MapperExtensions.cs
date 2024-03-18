using System.Reflection;
using AutoMapper;
using Catalog.Application.Features.Brands.Profiles;

namespace Catalog.Application.Extensions;

public static class MapperExtensions
{
    private static readonly Lazy<IMapper> MapperConfiguration = new(() =>
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.ShouldMapProperty = p => p.GetMethod!.IsPublic || p.GetMethod.IsAssembly;
            var profileTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsAbstract);

            foreach (var profileType in profileTypes)
            {
                cfg.AddProfile(profileType);
            }
        });


        return config.CreateMapper();
    });

    public static IMapper LazyMapper => MapperConfiguration.Value;

}