using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace My_Covid_App.Infrastructure
{
    public static class IdentityExtentions
    {
        public static string GetId(this ClaimsPrincipal user)
            => user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;

        public static async Task<WebApplication> CreateRolesAsync(this WebApplication app, IConfiguration configuration)
        {
            using var scope = app.Services.CreateScope();
            var roleManager = (RoleManager<IdentityRole>)scope.ServiceProvider.GetService(typeof(RoleManager<IdentityRole>))!;
            var roles = configuration.GetSection("Roles").Get<List<string>>();

            foreach (var role in roles)
            {
                if (!await roleManager!.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            return app;
        }
    }
}
