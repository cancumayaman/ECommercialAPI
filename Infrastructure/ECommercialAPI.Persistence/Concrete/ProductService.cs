using ECommercialAPI.Application.Abstractions;
using ECommercialAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialAPI.Persistence.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 100, CreatedDate = DateTime.Now },
                new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 200, CreatedDate = DateTime.Now },
                new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 300, CreatedDate = DateTime.Now },
                new() { Id = Guid.NewGuid(), Name = "Product 4", Price = 400, CreatedDate = DateTime.Now },
                new() { Id = Guid.NewGuid(), Name = "Product 5", Price = 500, CreatedDate = DateTime.Now }
            };
    }
}
