using WorkPlanningService.Application.Dto.RequestDto;
using WorkPlanningService.Application.Dto.ResponseDto;

namespace WorkPlanningService.Application.Interfaces
{
    public interface IWokerService
    {
        Task<GenericResponseDto<UserResponseDto>> CreateWorkerAsync(UserRequestDto userRequest);

        Task<GenericResponseDto<UserResponseDto>> GetWorkerByIdAsync(string id);
        Task<GenericResponseDto<IEnumerable<UserResponseDto>>> GetAllWorkersAsync();
    }
}