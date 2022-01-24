using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAW_Store.Models.Base;

namespace DAW_Store.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        // in <TEntity> punem modelele care au la baza acest BaseEntity
        // <TEntity> -> entitate generica

        // Get all the data
        Task<List<TEntity>> GetAll();
        IQueryable<TEntity> GetAllAsQueryable();

        void Create(TEntity entity);
        Task CreateAsync(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);
        Task CreateRangeAsync(IEnumerable<TEntity> entities);

        // Update
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        // Delete
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

        // Find
        TEntity FindById(object id);
        Task<TEntity> FindByIdAsync(object id);

        // Save 
        bool Save();
        Task<bool> SaveAsync();
    }
}