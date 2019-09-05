using System;
using System.Collections.Generic;
using System.Linq;
using Alten.DbContexts;
using Alten.Dtos;

namespace Alten.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly MyDbContext _context;

        public DashboardRepository(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CustomerVehicleState> GetCustomerVehicleStates()
        {

            var query = from cust in _context.Customers
                join custVeh in _context.CustomerVehicles on cust.Id equals custVeh.CustomerId
                join veh in _context.Vehicles on custVeh.VehicleId equals veh.Id
                select new CustomerVehicleState()
                {
                    VehicleId = veh.Id, CustomerId = cust.Id, CustomerName = cust.Name,
                    VehicleRegistrationNo = veh.RegistrationNo,Connected = veh.Connected
                };

            return query;


        }

        public NewVehicleState SetRandomCarToRandomState()
        {
            var randomVehicleId = new Random().Next(1, 7);
            var randomVehicle = _context.Vehicles.Single(m => m.Id == randomVehicleId);
            randomVehicle.Connected= new Random().Next(2)==0;
            _context.SaveChanges();

            return new NewVehicleState() {Connected = randomVehicle.Connected, VehicleId = randomVehicleId};

        }
    }
}