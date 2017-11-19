using CameraBazzar.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CameraBazzar.Web.Infrastructure.Extentions
{
    public static class ApplicationBuilderExtentions
    {
        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetService<CameraBazzarDbContext>().Database.Migrate();
            }

            return app;
        }
    }
}
