using Microsoft.OpenApi.Models;
using Todo.Core.Interfaces.IRepositories;
using Todo.Core.Interfaces.IServices;
using Todo.DAL;
using Todo.Presentation.Controllers;
using Todo.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddApplicationPart(typeof(AssemblyReference).Assembly)
    .AddControllersAsServices();  // load external project controllers

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Todo API", Version = "v1" });
});

builder.Services.AddScoped<ITodoService, TodoService>();
builder.Services.AddScoped<ITodoRepository, TodoRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API v1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

var provider = app.Services.GetRequiredService<
    Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider>();

foreach (var desc in provider.ActionDescriptors.Items)
{
    Console.WriteLine($"[Discovered Route] {desc.DisplayName}");
}


app.Run();
