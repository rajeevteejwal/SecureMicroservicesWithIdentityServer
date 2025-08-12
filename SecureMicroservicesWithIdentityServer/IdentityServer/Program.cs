using Duende.IdentityServer.Models;
using IdentityServer.Configuration;

var builder = WebApplication.CreateBuilder(args);
//Add identity server to service container
builder.Services.AddIdentityServer()
    .AddInMemoryClients(Config.GetClients)
    .AddInMemoryApiScopes(Config.GetApiScopes)
    .AddDeveloperSigningCredential();

var app = builder.Build();
//use identity server
app.UseIdentityServer();

app.MapGet("/", () => "Hello World!");

app.Run();
