using ControleFrotas.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace ControleFrotas.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        int Add(T entity);
        Task<IEnumerable<T>> Get();
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> func);
    }
}
