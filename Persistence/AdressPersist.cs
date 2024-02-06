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
    public class AdressPersist : IAdressPersiste
    {
        private readonly DataContext _context;
        public AdressPersist(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Adress>> FeatchByIdCustomer(int IdCustomer)
        {
            IQueryable<Adress> query = _context.Adresses;
            query = query.AsNoTracking().Where(p => p.IdCustomer == IdCustomer);
            return await query.ToListAsync();
        }
    }
}
