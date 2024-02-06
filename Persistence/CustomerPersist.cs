using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Contract;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class CustomerPersist : ICustomerPersist
    {
        private readonly DataContext _context;
        public CustomerPersist(DataContext context)
        {
            _context = context;
        }
        public List<Customer> getAllCustomer()
        {
            IQueryable<Customer> query = _context.Customers.Include(c => c.ListPhones).Include(c => c.ListAdress);
            query = query.AsNoTracking().OrderBy(c => c.Name);
            return query.ToList();
        }

        public List<Customer> getByNameLikeCustomer(string customerName)
        {
            IQueryable<Customer> query = _context.Customers.Include(c => c.ListPhones).Include(c => c.ListAdress);
            query = query.AsNoTracking().OrderBy(c => c.Name).Where(c => c.Name.Contains(customerName));
            return query.ToList();
        }

        public async Task<Customer> getCustomerByCpfAsync(string cpfCustomer)
        {
            IQueryable<Customer> query = _context.Customers.Include(c => c.ListPhones).Include(c => c.ListAdress);
            query = query.AsNoTracking().Where(c => c.Cpf == cpfCustomer);
            return await query.FirstOrDefaultAsync() ?? new Customer();
        }


        public async Task<Customer> getCustomerById(int Id)
        {
            IQueryable<Customer> query = _context.Customers.Include(c => c.ListPhones).Include(c => c.ListAdress);
            query = query.AsNoTracking().Where(c => c.Id == Id);
            return await query.FirstOrDefaultAsync() ?? new Customer();
        }
    }
}
