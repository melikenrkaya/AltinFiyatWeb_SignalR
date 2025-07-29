using AltınFiyatWeb__SignalR_.Services.Scraper;
using AltınFiyatWeb__SignalR_.Data.Context;
using AltınFiyatWeb__SignalR_.Hubs;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace AltınFiyatWeb__SignalR_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            builder.Services.AddControllers();
            builder.Services.AddDbContext<ApplicationDBContext>(options =>
            {

                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            }, ServiceLifetime.Scoped);

            builder.Services.AddSignalR();
            builder.Services.AddSingleton<AltinPriceScraper>();
            builder.Services.AddSingleton<AltinJobService>();

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowAnyOrigin();
                });
            });

            builder.Services.AddHangfire(config => config.UseMemoryStorage());
            builder.Services.AddHangfireServer();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                    c.RoutePrefix = string.Empty;
                });
            }


            app.UseCors();         
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();  

            app.UseDefaultFiles();   
            app.UseStaticFiles();   
            app.UseRouting();     


            app.MapHub<PriceHub>("/altinHub");
            app.UseHangfireDashboard();


            RecurringJob.AddOrUpdate<AltinJobService>(
                "altin-fiyat-job",
                job => job.CheckAndNotifyAsync(),
                "*/3 * * * * *" 
            );
            app.Run();
        }
    }
}