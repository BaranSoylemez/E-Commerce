using ECommerceAPI.Application.Repository;
using ECommerceAPI.Domain.Base;
using ECommerceAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repository
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceDBContext _context;

        public ReadRepository(ECommerceDBContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);

        public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(p => p.ID == Guid.Parse(id));
       
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);
        

        
    }
}
