using Persistence.Contract;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class GenericPersist : IGenericPersiste
    {
        private readonly DataContext _context;
        public GenericPersist(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
           _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }


        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}
