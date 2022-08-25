using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkPlanningService.Application.Dto.RequestDto;
using WorkPlanningService.Application.Dto.ResponseDto;
using WorkPlanningService.Application.Interfaces;
using WorkPLanningService.Domain;

namespace WorkPlanningService.Application.Services
{
    public class WorkerService : IWokerService
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly IMapper _mapper;
        public WorkerService(IGenericRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        public async Task<GenericResponseDto<UserResponseDto>> CreateWorkerAsync(UserRequestDto userRequest)
        {
            var user = _mapper.Map<User>(userRequest);
            var genericResponse = new GenericResponseDto<UserResponseDto>()
            {
               Success = false,
               StatusCode = System.Net.HttpStatusCode.OK,
            };
            var response = await _userRepository.AddAsync(user);
            if (response)
            {
                var userResponse = _mapper.Map<UserResponseDto>(user);
                genericResponse.Success = true;
                genericResponse.Data = userResponse;
                genericResponse.StatusCode = System.Net.HttpStatusCode.OK;
            }
            return genericResponse;
        }

        public async Task<GenericResponseDto<UserResponseDto>> GetWorkerByIdAsync(string id)
        {
            var genericResponse = new GenericResponseDto<UserResponseDto>()
            {
                Success = false,
                StatusCode = System.Net.HttpStatusCode.OK,
            };
            var user = await _userRepository.GetARecordAsync(id);
            if (user == null)
            {
                throw new ArgumentException("UserId cannot be found");
            }
            var userResponse = _mapper.Map<UserResponseDto>(user);
            genericResponse.Success = true;
            genericResponse.Data = userResponse;
            genericResponse.StatusCode = System.Net.HttpStatusCode.OK;
            return genericResponse;
        }

        public async Task<GenericResponseDto<IEnumerable<UserResponseDto>>> GetAllWorkersAsync()
        {
            var genericResponse = new GenericResponseDto<IEnumerable<UserResponseDto>>()
            {
                Success = false,
                StatusCode = System.Net.HttpStatusCode.OK,
            };
            var users = await _userRepository.GetAllRecordsAsync();
            if (users == null)
            {
                throw new ArgumentException("UserId cannot be found");
            }
            var userResponse = _mapper.Map<IEnumerable<UserResponseDto>>(users);
            genericResponse.Success = true;
            genericResponse.Data = userResponse;
            genericResponse.StatusCode = System.Net.HttpStatusCode.OK;
            return genericResponse;
        }
    }
}
