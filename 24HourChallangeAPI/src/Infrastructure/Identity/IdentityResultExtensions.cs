using _24HourChallangeAPI.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace _24HourChallangeAPI.Infrastructure.Identity;
public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
