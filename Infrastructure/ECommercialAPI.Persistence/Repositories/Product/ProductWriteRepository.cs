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
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommercialAPIDbContext context) : base(context)
        {
        }
    }
}
