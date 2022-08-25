using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkPlanningService.Application.Dto.RequestDto;
using WorkPlanningService.Application.Dto.ResponseDto;
using WorkPLanningService.Domain;

namespace WorkPlanningService.Application.Dto.Mapper
{
    public class UserMappings : Profile
    {
        public UserMappings()
        {
            CreateMap<User, UserRequestDto>().ReverseMap();
            CreateMap<User, UserResponseDto>().ReverseMap();
            CreateMap<ShiftSchedule, ShiftScheduleRequestDto>().ReverseMap();
            CreateMap<ShiftSchedule, ShiftScheduleResponseDto>().ReverseMap();
        }
    }
}
