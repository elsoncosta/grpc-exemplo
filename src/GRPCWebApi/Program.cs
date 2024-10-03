using GRPCWebApi.Services;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddGrpc();  // Adiciona suporte para gRPC
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.WebHost.ConfigureKestrel(options =>
// {
//     options.ListenLocalhost(5000, o => o.Protocols = HttpProtocols.Http2); // HTTP/2 sem HTTPS
// });

// builder.WebHost.ConfigureKestrel(options =>
// {
//     options.ListenLocalhost(5001, o =>
//     {
//         o.UseHttps();
//         o.Protocols = HttpProtocols.Http2;
//     });
// });



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Mapeia os serviços gRPC
app.MapGrpcService<GreeterService>();
app.MapGrpcService<ClienteService>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Adiciona uma rota para evitar chamadas não encontradas no gRPC
app.MapGet("/", async context =>
{
    await context.Response.WriteAsync("Esta aplicação tem suporte a gRPC e Web API!");
});


app.Run();

