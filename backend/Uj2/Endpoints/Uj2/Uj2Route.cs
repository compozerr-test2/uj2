using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Uj2.Services;

namespace Uj2.Endpoints.Uj2;

public static class Uj2Route
{
    public static RouteHandlerBuilder AddUj2Route(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IUj2Service uj2Service) => new GetUj2Response($"Hello, {uj2Service.GetObfuscatedName(name)}!"));
    }
}