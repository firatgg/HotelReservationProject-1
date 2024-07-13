using Entity.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Contexts;
using System.Linq.Expressions;


namespace Data.Repositories
{
	public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly HotelDbContext _context;
        private DbSet<T> _dbSet;

        public Repository(HotelDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

		public async Task Add(T entity)
		{
			await _dbSet.AddAsync(entity);
			
		}

		public void Delete(int id)
		{
			var entity = _dbSet.Find(id);
			_dbSet.Remove(entity);
			
		}

		public void Delete(T entity)
		{

			if (entity.GetType().GetProperty("IsDeleted") != null)
			{
				entity.GetType().GetProperty("IsDeleted").SetValue(entity, true);
				_dbSet.Update(entity);
			}
			else
			{
				_dbSet.Remove(entity);
			}
			
		}

		public async Task<T> Get(Expression<Func<T, bool>> filter)
		{
			IQueryable<T> query = _dbSet;
			if (filter != null)
			{
				_dbSet.Where(filter);
			}
			return await query.FirstOrDefaultAsync();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.AsNoTracking().ToListAsync(); //ef core verileri takip etmiyor (modified,deleted,detached gibi)
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public void Update(T entity)
		{
			_dbSet.Update(entity);
			
		}
	}
}
