using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Base
{
    public class BaseEntity
    {
        public Guid ID { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
