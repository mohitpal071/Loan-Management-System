global using Microsoft.EntityFrameworkCore;
global using WebApplication1.Model;


namespace WebApplication1
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
            ;

            //Dependency Injection DbContext Class
            builder.Services.AddDbContext<APIDbContext>(options =>
            options.UseSqlServer(@"server=LAPTOP-F4QS9EU6\SQLEXPRESS;database=loan4;trusted_connection=true;TrustServerCertificate=True;"));

            builder.Services.AddCors(o => o.AddPolicy("CORS", builder =>
            {
                builder.AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod();
            }));
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

            app.UseCors("CORS");
            app.Run();
        }
    }
}