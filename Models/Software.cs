using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Models
{
    public class Software
    {
        public Software(string name, int version, string path, Vendor vendor)
        {
            Name = name;
            Version = version;
            Path = path;
            Vendor = vendor;
        }

        public string Name { get; set; }
        public int Version { get; set; }
        public string Path { get; set; }
        public Vendor Vendor { get; set; }
    }
}