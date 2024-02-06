using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Adress
    {
        public int ID { get; set; }

        public string Road { get; set; }

        public string Number { get; set; }

        public string Postal { get; set; }

        public Customer Customer { get; set; }
       
        public int IdCustomer { get; set; }


    }
}
