using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region :: Inje��o de Depend�ncia
            services.AddSingleton<OpenWeatherClient.Interfaces.IApiClient, OpenWeatherClient.Clients.ApiClient>();
            services.AddSingleton<OpenWeatherClient.Interfaces.IAirQualityIndexClient, OpenWeatherClient.Clients.AirQualityIndexClient>();
            services.AddSingleton<OpenWeatherClient.Interfaces.IWeatherClient, OpenWeatherClient.Clients.WeatherClient>();
            services.AddSingleton<OpenWeatherClient.Interfaces.IForecastClient, OpenWeatherClient.Clients.ForecastClient>();
            services.AddSingleton<Data.Interface.ILogRepository, Data.Repository.LogRepository>();
            services.AddSingleton<Data.Interface.IApiAccessRepository, Data.Repository.ApiAccessRepository>();
            #endregion

            services.AddControllers();

            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "APIAPS8SEM", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "APIAPS8SEM");
            });

        }
    }
}
