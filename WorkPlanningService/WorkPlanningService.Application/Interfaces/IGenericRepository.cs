using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkPlanningService.Application.Dto.RequestDto;
using WorkPlanningService.Application.Dto.ResponseDto;

namespace WorkPlanningService.Application.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<bool> AddAsync(T entity);
        Task<T> GetARecordAsync(string id);
        Task<IEnumerable<T>> GetAllRecordsAsync();

    }
}

