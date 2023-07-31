using Microsoft.Extensions.DependencyInjection;
using GlobalInformation.Services.Country;

namespace GlobalInformation.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICountryService, CountryService>();
        return serviceCollection;
    }
}
