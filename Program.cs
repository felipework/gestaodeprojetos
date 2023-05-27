using System.Net;
using System.Text.Json.Serialization;
using gestaodeprojetos.Data;
using gestaodeprojetos.Repositories;
using gestaodeprojetos.Repositories.Interfaces;
using gestaodeprojetos.Services;
using gestaodeprojetos.Services.Interfaces;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("GestaoDeProjetos"));
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Response.ContentType = "text/html";

        var ex = context.Features.Get<IExceptionHandlerFeature>();
        if (ex != null)
        {
            var errorMessage = $"An error occurred: {ex.Error.Message}";
            await context.Response.WriteAsync(errorMessage).ConfigureAwait(false);
        }
    });
});

app.UseAuthorization();

app.MapControllers();

app.Run();
