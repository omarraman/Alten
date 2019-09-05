using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alten.Dtos
{
    public class CustomerVehicleState
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int VehicleId { get; set; }
        public string VehicleRegistrationNo { get; set; }
        public bool Connected { get; set; }
    }
}
