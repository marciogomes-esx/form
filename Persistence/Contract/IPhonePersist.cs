﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contract
{
    public interface IPhonePersist
    {
        List<Phone> FeatchByIdCustomer(int IdCustomer);
    }
}
