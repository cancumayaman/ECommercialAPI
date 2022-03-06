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
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommercialAPIDbContext context) : base(context)
        {
        }
    }
}
