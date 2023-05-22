﻿using ECommerceAPI.Application.Repository;
using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application
{
    public interface IOrderReadRepository: IReadRepository<Order>
    {
    }
}
