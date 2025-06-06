using Carter;
using Microsoft.AspNetCore.Routing;

namespace Uj2.Endpoints.Uj2;

public class Uj2Group : CarterModule
{
    public Uj2Group() : base("/uj2")
    {
        WithTags(nameof(Uj2));
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.AddUj2Route();
    }
}