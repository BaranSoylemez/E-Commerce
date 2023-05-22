using ECommerceAPI.Application.Repository;
using ECommerceAPI.Domain.Base;
using ECommerceAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repository
{
    public class WriteRepository<T>: IWriteRepository<T> where T : BaseEntity
    {
        public readonly ECommerceDBContext _context;

        public WriteRepository(ECommerceDBContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityentry = await Table.AddAsync(model);
            return entityentry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityentry = Table.Remove(model);
            return entityentry.State == EntityState.Deleted;    
        }
     

        public bool RemoveById(string id)
        {
            T removeitem = Table.FirstOrDefault(p=>p.ID == Guid.Parse(id));
            return Remove(removeitem);
                
        }      

        public bool RemoveRange(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }

        public bool Update(T model)
        {
            EntityEntry<T> entityentry = Table.Update(model);
            return entityentry.State == EntityState.Modified;
        }

        public async Task<int> SaveChangeAsync() => await _context.SaveChangesAsync();
        

       
    }
}
