﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contract
{
    public interface IAdressPersiste
    {
        Task<List<Adress>> FeatchByIdCustomer(int IdCustomer);
      
    }
}
