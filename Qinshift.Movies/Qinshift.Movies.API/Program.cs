using Microsoft.EntityFrameworkCore;
using Qinshft.Movies.DataAccess;
using Qinshft.Movies.DataAccess.Implementation;
using Qinshft.Movies.DataAccess.Interfaces;
using Qinshift.Movies.DomainModels;
using Qinshift.Movies.Services.Implementation;
using Qinshift.Movies.Services.Helpers;

namespace Qinshift.Movies.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            string connString = builder.Configuration.GetConnectionString("ConnectionString");

            builder.Services.RegisterDbContext(connString);
            builder.Services.RegisterRepositories();

            builder.Services.AddTransient<IMovieService, MovieService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
