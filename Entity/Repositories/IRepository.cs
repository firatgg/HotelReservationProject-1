using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories
{
	public interface IRepository<T> where T : class, new()
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task<T> Get(Expression<Func<T, bool>> filter);
		Task Add(T entity);
		void Update(T entity);
		void Delete(int id);
		void Delete(T entity);

	}
}
