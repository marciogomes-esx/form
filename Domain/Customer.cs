using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public List<Phone> ListPhones { get; set; }

        public string City { get; set; }

        public List<Adress> ListAdress { get; set; }

    }
}
