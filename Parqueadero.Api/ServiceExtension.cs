using Microsoft.Extensions.DependencyInjection;
using Parqueadero.Application.ApplicationService;
using Parqueadero.Application.ApplicationService.Implemetacion;
using Parqueadero.Domain;
using Parqueadero.Domain.Repositories;
using Parqueadero.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.Api
{
    public static class ServiceExtension

    {
        public static void AddEntity<TEntity, TId>(this IServiceCollection services)
            where TEntity : Entity<TId>, new()
        where TId : IComparable, IComparable<TId>
        {
            var mongoHost = Environment.GetEnvironmentVariable("MongoHost");
            var dataBase = Environment.GetEnvironmentVariable("DataBase");
            services.AddScoped<IRepository<TEntity, TId>>(it => new MongoRepository<TEntity, TId>(mongoHost, dataBase));
            services.AddTransient<ICrudService<TEntity, TId>, CrearPuestoApplicationService<TEntity, TId>>();
        }
    }
}
