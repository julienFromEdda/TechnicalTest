using Bogus;
using UserApi.DataAccess;
using UserApi.Models.Entity;

namespace UserApi.Startup;

internal static partial class Helpers
{
    internal static void SeedDatabase(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<UserDbContext>();

        if (context.Users.Any()) return;

        var userIds = 1;
        var testUsers = new Faker<User>()
            .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
            .RuleFor(u => u.Name, (f, u) => f.Name.LastName())
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.Name))
            .RuleFor(u => u.Id, f => userIds++);

        context.Users.AddRange(testUsers.Generate(1000));
        context.SaveChanges();
    }
}
