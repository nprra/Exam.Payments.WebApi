using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Domain
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
        Task Add(TEntity entity);
        void Delete(Guid id);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
