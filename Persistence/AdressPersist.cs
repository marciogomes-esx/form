using Domain;
using Persistence.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class AdressPersist : IAdressPersiste
    {
        public List<Adress> FeatchByIdCustomer(int IdCustomer)
        {
            //IQueryable<Adress> query = _context.adress;
            //query = query.AsNoTracking().where(x => x.IdCustomer == IdCustomer);

            //return query.ToList();
        }
    }
}
