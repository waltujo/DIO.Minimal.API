using Domain.DTOs;
using Domain.Entidades;
using Domain.Interfaces;
using Domain.Servicos;
using Infraestrutura.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DIO.Minimal.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IAdministradorService, AdministradorService>();

            string connectionString = builder.Configuration.GetConnectionString("connString");

            builder.Services.AddDbContext<DbContexto>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Map("/login", ([FromBody] LoginDTO loginDTO, IAdministradorService administradorService) =>
            {
                if (administradorService.Login(loginDTO) != null)
                    return Results.Ok("Login efetuado com sucesso!");
                else
                    return Results.Unauthorized();
            });

            app.Run();

        }
    }
}
