using Microsoft.AspNetCore.Mvc;
using Alten.Models;
using Alten.Repositories;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace Alten.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {

        private readonly IDashboardRepository _dashboardRepository;

        public DashboardController(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }
        // GET: api/Product
        [HttpGet]
        public IActionResult Get()
        {
            var states = _dashboardRepository.GetCustomerVehicleStates();
            return new OkObjectResult(states);
        }

    }
}