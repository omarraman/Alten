using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alten.Models;

namespace Alten.Repositories
{
    public interface IVehicleRepository
    {
        IEnumerable<Customer> Get();
    }
}
