using Microsoft.Extensions.DependencyInjection;

namespace Cats.Repository;

public static class DependencyContainer
{
    public static IServiceCollection AddCatsRepositories(this IServiceCollection services)
    {
        services.AddScoped<IGetCatsRepository, GetCatsRepositoryFake>();
        return services;
    }
}
