using Microsoft.EntityFrameworkCore;
using UserApi.DataAccess;
using UserApi.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

builder.Services.ConfigureSwagger();
builder.Services.AddControllers();
builder.Services.AddDbContext<UserDbContext>(options => options.UseInMemoryDatabase("UserDb"));

var app = builder.Build();

app.SeedDatabase();
app.AddSwagger();
app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();
app.Run();
