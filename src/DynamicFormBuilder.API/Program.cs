using DynamicFormBuilder.Application.Interfaces;
using DynamicFormBuilder.Application.Mapping;
using DynamicFormBuilder.Application.Services;
using DynamicFormBuilder.Data.Context;
using DynamicFormBuilder.Data.Repositories;
using DynamicFormBuilder.Data.Seeding;
using DynamicFormBuilder.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
// Servicios
builder.Services.AddScoped<IFormService, FormService>();
builder.Services.AddScoped<IFormRepository, FormRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("FormBuilderDB"));

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddControllers();

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Dynamic Form Builder API",
        Version = "v1",
        Description = "API para gestionar formularios dinámicos construidos con Form.io.",
    });

    var apiXml = Path.Combine(AppContext.BaseDirectory, "DynamicFormBuilder.API.xml");
    if (File.Exists(apiXml))
        c.IncludeXmlComments(apiXml);
});

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Ejecutar el seeding al iniciar
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    await ApplicationDbContextSeed.SeedAsync(context);
}

app.UseHttpsRedirection();
app.UseCors("AllowAngular");
app.UseAuthorization();
app.MapControllers();

app.Run();