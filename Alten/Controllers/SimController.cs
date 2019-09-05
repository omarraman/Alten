using Alten.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Alten.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimController : ControllerBase
    {

        private readonly IDashboardRepository _dashboardRepository;

        public SimController(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }
        // GET: api/Product
        [HttpPost]
        public IActionResult Post()
        {
            var newVehicleState = _dashboardRepository.SetRandomCarToRandomState();
            return new OkObjectResult(newVehicleState);
        }

    }
}