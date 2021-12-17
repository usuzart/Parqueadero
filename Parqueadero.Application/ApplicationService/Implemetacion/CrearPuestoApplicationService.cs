using Parqueadero.Domain;
using Parqueadero.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Parqueadero.Application.ApplicationService.Implemetacion
{
    public class CrearPuestoApplicationService<TEntity, TId> : ICrudService<TEntity, TId>
         where TEntity : Entity<TId>, new()
        where TId : IComparable, IComparable<TId>
    {
        //creacion de inyeccion de dependencias , inversion de dependencias  e inversion of control


        private readonly IRepository<TEntity, TId> respository;

        public CrearPuestoApplicationService(IRepository<TEntity, TId> respository) 
        {
           this.respository = respository;
        }

        public bool Delete(TEntity entity)
        {
           return respository.Delete(entity);
        }

        public  Task<bool> DeleteAsync(TEntity entity)
        {
            return  respository.DeleteAsync(entity);
        }

        public bool DeleteById(TId id)
        {
            return respository.DeleteById(id);
        }

        public  Task<bool> DeleteByIdAsync(TId id)
        {
            return  respository.DeleteByIdAsync(id);
        }

        public IEnumerable<TEntity> FindByAll()
        {
            return respository.FindByAll(); 
        }

        public  Task<IEnumerable<TEntity>> FindByAllAsync()
        {
            return  respository.FindByAllAsync();
        }

        public IEnumerable<TEntity> FindByExpression(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return  respository.FindByExpression(predicate);
        }

        public Task<IEnumerable<TEntity>> FindByExpressionAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return respository.FindByExpressionAsync(predicate);
        }

        public TEntity FindById(TId id)
        {
            return respository.FindById(id);
        }

        public Task<TEntity> FindByIdAsync(TId id)
        {
            return respository.FindByIdAsync(id);
        }

        public TEntity FirstOrDefault(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return respository.FirstOrDefault(predicate);
        }

        public Task<TEntity> FirstOrDefaultAsync(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return respository.FirstOrDefaultAsync(predicate);
        }

        public TEntity Insert(TEntity entity)
        {
            return respository.Insert(entity);
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            return respository.InsertAsync(entity);
        }

        public TEntity Update(TEntity entity)
        {
            return respository.Update(entity);
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            return respository.UpdateAsync(entity);
        }
    }
}
