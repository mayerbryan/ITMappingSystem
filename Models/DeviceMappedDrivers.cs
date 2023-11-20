using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Models
{
    public class DeviceMappedDrivers
    {
        public DeviceMappedDrivers(string driverPath) 
        {
            DriverPath = driverPath;
   
        }
        public string DriverPath { get; set; }
    }
}