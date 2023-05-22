using ECommerceAPI.Application;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistence.Context;
using ECommerceAPI.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
