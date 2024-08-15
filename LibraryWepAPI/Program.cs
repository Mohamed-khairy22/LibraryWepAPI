
using LibraryWepAPI.Models;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using LibraryWepAPI.Repository;

namespace LibraryWepAPI
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
            builder.Services.AddScoped<IBookRepsitory,BooKRepository>();
            builder.Services.AddScoped<IPatronRepository, PatronRepository>();
            builder.Services.AddDbContext<DBEntity>(OptionBuilder=> 
            {
                OptionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DB"));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
