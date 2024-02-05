using Domain;
using Persistence.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class CustomerPersist : ICustomerPersist
    {
        public List<Customer> getAllCustomer()
        {
            throw new NotImplementedException();
        }

        public List<Customer> getByNameLikeCustomer(string customerName)
        {
            throw new NotImplementedException();
        }

        public Customer getCustomerByCpf(string cpfCustomer)
        {
            throw new NotImplementedException();
        }

        public Customer getCustomerById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
