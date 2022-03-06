using ECommercialAPI.Application.Repositories;
using ECommercialAPI.Domain.Entities.Common;
using ECommercialAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommercialAPIDbContext _context;

        public ReadRepository(ECommercialAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;
        public IQueryable<T> GetWhere(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
            => Table.Where(predicate);
        public async Task<T> GetSingleAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
            => await Table.FirstOrDefaultAsync(predicate);
        public Task<T> GetByIdAsync(string id)
            => Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));

    }
}
