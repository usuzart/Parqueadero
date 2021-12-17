using Microsoft.AspNetCore.Mvc;
using Parqueadero.Application.ApplicationService;
using Parqueadero.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.Api.Controllers
{
    public class SubBaseController<TEntity, TId> : ControllerBase
        where TEntity : Entity<TId>, new()
        where TId : IComparable, IComparable<TId>
    {

        private readonly ICrudService<TEntity, TId> crudService;

        public SubBaseController(ICrudService<TEntity, TId> crudService)
        {
            this.crudService = crudService;
        }

        [HttpPost]
        public async Task<TEntity> Post(TEntity entity)
        {
            return await this.crudService.InsertAsync(entity);
        }

        [HttpPut]
        public async Task<TEntity> Put(TEntity entity)
        {
            return await this.crudService.UpdateAsync(entity);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<bool> Delete(TId id)
        {
            return await this.crudService.DeleteByIdAsync(id);
        }

        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get()
        {
            return await this.crudService.FindByAllAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<TEntity> Get(TId id)
        {
            return await this.crudService.FindByIdAsync(id);
        }
    }
}
