using EmailVerificationBackend.Repositories;
using EmailVerificationBackend.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<UserRepository>();
builder.Services.AddSingleton<UserService>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
