using ECommercialAPI.Application.Repositories;
using ECommercialAPI.Domain.Entities;
using ECommercialAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialAPI.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ECommercialAPIDbContext context) : base(context)
        {
        }
    }
}
