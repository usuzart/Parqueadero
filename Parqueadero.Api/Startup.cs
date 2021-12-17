using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Parqueadero.Application.ApplicationService;
using Parqueadero.Application.ApplicationService.Implemetacion;
using Parqueadero.Domain;
using Parqueadero.Domain.DomainService;
using Parqueadero.Domain.Repositories;
using Parqueadero.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.Api
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

            services.AddControllers();
            services.AddEntity<Puesto, string>();
            /*
            var mongoHost = Environment.GetEnvironmentVariable("MongoHost");
            var dataBase = Environment.GetEnvironmentVariable("DataBase");
            services.AddScoped<IRepository<Domain.Puesto,string>>(it => new MongoRepository<Domain.Puesto, string>(mongoHost, dataBase));
            services.AddTransient<ICrudService<Domain.Puesto, string>,CrearPuestoApplicationService<Domain.Puesto, string>>();*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
