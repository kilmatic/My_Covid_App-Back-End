using System.Security.Claims;

namespace My_Covid_App.Infrastructure
{
    public static class IdentityExtentions
    {
        public static string GetId(this ClaimsPrincipal user)
            => user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
    }
}
