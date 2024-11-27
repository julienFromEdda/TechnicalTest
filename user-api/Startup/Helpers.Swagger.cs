using Microsoft.OpenApi.Models;

namespace UserApi.Startup;

internal static partial class Helpers
{
    public static void ConfigureSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "User Search API",
                Version = "v1",
                Description = "API de gestion d'utilisateur",
            });
        });
    }

    public static void AddSwagger(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de gestion d'utilisateur V1");
            c.RoutePrefix = string.Empty;
        });
    }
}
