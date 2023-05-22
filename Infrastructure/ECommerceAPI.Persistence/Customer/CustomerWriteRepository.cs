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
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
