using ECommerceAPI.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repository
{
    public interface IWriteRepository<T>: IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> model);
        bool Update(T model);
        bool Remove(T model);
        bool RemoveRange(List<T> model);
        bool RemoveById(string id);
        Task<int> SaveChangeAsync();

    }
}
