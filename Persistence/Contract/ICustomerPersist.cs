using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contract
{
    public interface ICustomerPersist
    {
       Task<Customer> getCustomerByCpfAsync(string cpfCustomer);
       Task<Customer> getCustomerById(int Id);
       List<Customer> getAllCustomer();
       List<Customer> getByNameLikeCustomer(string customerName);
    }
}
