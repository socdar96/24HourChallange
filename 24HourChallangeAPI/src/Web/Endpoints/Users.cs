using _24HourChallangeAPI.Infrastructure.Identity;

namespace _24HourChallangeAPI.Web.Endpoints;
public class Users : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapIdentityApi<ApplicationUser>();
    }
}
