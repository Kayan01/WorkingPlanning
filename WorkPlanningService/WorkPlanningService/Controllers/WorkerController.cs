using Microsoft.AspNetCore.Mvc;
using WorkPlanningService.Application.Dto.RequestDto;
using WorkPlanningService.Application.Interfaces;

namespace WorkPlanningService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkerController : ControllerBase
    {
        public readonly IWokerService _workerService;
        public WorkerController(IWokerService workerService)
        {
            _workerService = workerService;
        }

        [HttpPost("[action]", Name = "CreateWorker")]

        public async Task<IActionResult> CreateWorker(UserRequestDto userRequest)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var user = await _workerService.CreateWorkerAsync(userRequest);
                return Ok(user);
            }
            catch(Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
           
        }
        [HttpPost("[action]/id", Name = " GeteWorkerById")]
        public async Task<IActionResult> GeteWorkerById(string id)
        {
            try
            {
                var user = await _workerService.GetWorkerByIdAsync(id);
                return Ok(user);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }

        [HttpPost("[action]", Name = " GetAlleWorkers")]
        public async Task<IActionResult> GetAlleWorkers()
        {
            try
            {
                var users = await _workerService.GetAllWorkersAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }
    }
}