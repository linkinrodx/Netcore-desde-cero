using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using netcore_desde_cero.Context;
using netcore_desde_cero.Interface;
using netcore_desde_cero.Repository;
using Swashbuckle.AspNetCore.Swagger;

namespace netcore_desde_cero
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services.AddDbContext<AtomoContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:AtomoDatabase"]));

            services.AddTransient<IPruebaRepository, PruebaRepository>();


            #region CONFIGURACIÓN SWAGGER

            services.AddSwaggerGen(options =>
            {
                options.DescribeAllEnumsAsStrings();
                options.SwaggerDoc("v1", new Info
                {
                    Title = "API - Prueba",
                    Version = Environment.GetEnvironmentVariable("VERSION"),
                    Description = "The Clients Service HTTP API",
                });
            });

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();


                app.UseSwagger(c =>
                {
                    c.RouteTemplate = "prueba/{documentName}/swagger.json";
                });


                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/prueba/v1/swagger.json", "My API V1");
                    c.RoutePrefix = "prueba";
                });
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
