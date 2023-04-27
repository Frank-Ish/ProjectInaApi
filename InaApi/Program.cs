using Data;
using Entities;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*Hace la inyeccion de dependencias de ClienteService;
 * Transient: Manejo dinamico de la memoria.
 * Scope: Mantiene la instancia en memoria mientras el usuario este logeado.
 * Singleton: Para que la intancia siempre este en memoria.
 */

//Capa de negocio
builder.Services.AddTransient<IServices<tbCliente>, ClienteService>();

//Capa de datos
builder.Services.AddTransient<IData<tbCliente>, ClienteData>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
