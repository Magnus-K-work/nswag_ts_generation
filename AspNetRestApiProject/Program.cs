using Microsoft.AspNetCore.Builder;
using System.Runtime.Intrinsics;

namespace AspNetRestApiProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerDocument();

            var app = builder.Build();

            app.UseAuthorization();

            app.MapControllers();

            app.UseOpenApi();
            app.UseSwaggerUi();

            app.Run();
        }
    }
}
