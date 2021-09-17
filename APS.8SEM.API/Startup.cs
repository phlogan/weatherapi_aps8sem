using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            #region :: Injeção de Dependência
            services.AddSingleton<OpenWeatherClient.Interfaces.IApiClient, OpenWeatherClient.Clients.ApiClient>();
            services.AddSingleton<OpenWeatherClient.Interfaces.IAirQualityIndexClient, OpenWeatherClient.Clients.AirQualityIndexClient>();
            
            #endregion

            services.AddControllers();
            //services.AddMvcCore();
            //services.AddSwaggerGen(e => e.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            //{
            //    Title = "APS8SEMAPI",
            //    Version = "v1",
            //    Description = "Projeto de APS do último semestre do curso de Ciência da Computação na Universidade Paulista, unidade Marquês"
            //}));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseSwagger();

            //app.UseSwaggerUI(e =>
            //{
            //    e.RoutePrefix = "swagger";
            //    e.SwaggerEndpoint("/swagger/v1/swagger.json", "APS8SEMAPI");
            //});
        }
    }
}
