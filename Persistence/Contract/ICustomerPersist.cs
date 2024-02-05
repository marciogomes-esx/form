﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contract
{
    public interface ICustomerPersist
    {
        Customer getCustomerByCpf(string cpfCustomer);
        Customer getCustomerById(int Id);
        List<Customer> getAllCustomer();
        List<Customer> getByNameLikeCustomer(string customerName);
    }
}
