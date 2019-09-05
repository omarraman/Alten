using System.Collections.Generic;
using System.Threading.Tasks;
using Alten.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Alten.Repositories
{
    public interface IDashboardRepository
    {
        IEnumerable<CustomerVehicleState> GetCustomerVehicleStates();
        NewVehicleState SetRandomCarToRandomState();
    }
}
