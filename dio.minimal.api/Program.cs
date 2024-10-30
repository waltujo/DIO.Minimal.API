using Domain.DTOs;

namespace DIO.Minimal.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Map("/login", (LoginDTO loginDTO) =>
            {
                if (loginDTO.Email == "adm@teste.com" && loginDTO.Password == "123456")
                    return Results.Ok("Login efetuado com sucesso!");
                else
                    return Results.Unauthorized();
            });

            app.Run();

        }
    }
}
