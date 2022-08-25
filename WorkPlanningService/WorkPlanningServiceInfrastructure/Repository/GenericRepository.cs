using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkPlanningService.Application.Dto.RequestDto;
using WorkPlanningService.Application.Interfaces;
using WorkPlanningService.Infrastructure.Context;

namespace WorkPlanningService.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class 
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _dbSet = _applicationDbContext.Set<T>();
        }

        public async Task<bool> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return await SaveChanges();
        }
        public async Task<T> GetARecordAsync(string id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<IEnumerable<T>> GetAllRecordsAsync()
        {
            return await _dbSet.ToListAsync();
        }

        private async Task<bool> SaveChanges()
        {
            return await _applicationDbContext.SaveChangesAsync() > 0;
        }
    }
}
