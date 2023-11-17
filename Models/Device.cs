using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Models
{
    public class Device
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string OperatingSystem { get; set; }
        public int IP { get; set; }
        public string NetworkPort { get; set; }
        public string NetworkSwitch { get; set; }
        public string Owner { get; set; }
        public string Vendor { get; set; }
        public string LocationDescription { get; set; }
        public byte[] LocationMapImage { get; set; }
        public byte[] Picture { get; set; }
        public string MappedDrivers { get; set; }
        public string ConnectedServers { get; set; }
        public string SoftwareList { get; set; }
        public DateTime ImplementationDate { get; set; }
        public DateTime lifeCycle { get; set; }
        public string RelatedKbs { get; set; }
      
    }
}