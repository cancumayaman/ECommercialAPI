using Microsoft.EntityFrameworkCore;
using ECommercialAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommercialAPI.Application.Repositories;
using ECommercialAPI.Persistence.Repositories;

namespace ECommercialAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistemceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommercialAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
