using System;
using System.Collections.Generic;
using Alten.DbContexts;
using Alten.Models;

namespace Alten.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly MyDbContext _context;

        public VehicleRepository(MyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Vehicle> Get()
        {
            throw new NotImplementedException();
        }
    }
}