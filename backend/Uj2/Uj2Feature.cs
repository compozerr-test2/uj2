using Core.Feature;
using Microsoft.Extensions.DependencyInjection;
using Uj2.Services;

namespace Uj2;

public class Uj2Feature : IFeature
{

    void IFeature.ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IUj2Service, Uj2Service>();
    }
}