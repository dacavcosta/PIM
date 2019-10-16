using ControleFrotas.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ControleFrotas.Domain.Model;
using System.Linq.Expressions;
using ControleFrotas.Infrastructure.Context;

namespace ControleFrotas.Domain.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> 
        where T : class
    {
        private readonly DbContext _context;

        public GenericRepository(FrotasContext context)
        {
            _context = context;
        }

        public int Add(T entity)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<T>> Get()
        {
            var dbSet = _context.Set<T>();
            return await dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> func)
        {
            var dbSet = _context.Set<T>();
            return await dbSet.Where<T>(func).ToListAsync();
        }
    }
}
