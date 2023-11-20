using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Models
{
    public class DeviceAdditionalInformation
    {
        public DeviceAdditionalInformation(string location, string picture) 
        {
            Location = location;
            Picture = picture;
   
        }
        public string Location { get; private set; }
        public string Picture { get; private set; }
        
    }
}