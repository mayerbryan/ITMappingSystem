using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Models
{
    public class Network
    {
        public Network(string networkPort, string networkSwitch)
        {
            NetworkPort = networkPort;
            NetworkSwitch = networkSwitch;
        }

        public string NetworkPort { get; private set; }
        public string NetworkSwitch { get; private set; }
    }
}