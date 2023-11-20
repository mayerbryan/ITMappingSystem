using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Models
{
    public class Server
    {
        public Server(string name, int iP, string owner, string location)
        {
            Name = name;
            IP = iP;
            Owner = owner;
            Location = location;
        }

        public string Name { get; set; }
        public int IP { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }
    }
}