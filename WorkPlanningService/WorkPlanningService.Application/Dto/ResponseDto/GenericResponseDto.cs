using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WorkPlanningService.Application.Dto.ResponseDto
{
    public class GenericResponseDto<T>
    {
        public T Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public bool Success { get; set; }
    }
}
