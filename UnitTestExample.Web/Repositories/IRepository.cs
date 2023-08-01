using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTestExample.Web.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
    }
}
