using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Phone
    {
        public int Id { get; set; }

        public string DDD { get; set; }

        public string PhoneNumber { get; set; }

        public Customer Customer { get; set; }

        public int IdCustomer { get; set; }
    }
}
