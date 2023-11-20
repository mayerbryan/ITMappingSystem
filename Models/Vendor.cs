using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Models
{
    public class Vendor
    {
        public Vendor(string company, string representative, string email, int phone)
        {
            Company = company;
            Representative = representative;
            Email = email;
            Phone = phone;
        }

        public string Company { get; set; }
        public string Representative { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}