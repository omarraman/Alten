using System.Collections.Generic;
using Alten.DbContexts;
using Alten.Models;

namespace Alten.Repositories
{
    public   class CustomerRepository : ICustomerRepository
    {
        private readonly MyDbContext _context;


        public CustomerRepository(MyDbContext context)
        {
            _context = context;

        }
        public IEnumerable<Customer> Get()
        {
            return _context.Customers;
        }
    }
}