using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Models
{
    public class Device
    {
        public Device(int iD, string type, string name, string operatingSystem, int iP, string networkPort, string networkSwitch, string owner, DeviceType deviceType, DeviceAdditionalInformation deviceAdditionalInformation, DeviceMappedDrivers deviceMappedDrivers, KnowledgeBaseArticle knowledgeBaseArticle, LifeCycle lifeCycle, Server server, Software software, Vendor vendor)
        {
            ID = iD;
            Type = type;
            Name = name;
            OperatingSystem = operatingSystem;
            IP = iP;
            NetworkPort = networkPort;
            NetworkSwitch = networkSwitch;
            Owner = owner;
            DeviceType = deviceType;
            DeviceAdditionalInformation = deviceAdditionalInformation;
            DeviceMappedDrivers = deviceMappedDrivers;
            KnowledgeBaseArticle = knowledgeBaseArticle;
            LifeCycle = lifeCycle;
            Server = server;
            Software = software;
            Vendor = vendor;
        }

        public int ID { get; private set; }
        public string Type { get; private set; }
        public string Name { get; private set; }
        public string OperatingSystem { get; private set; }
        public int IP { get; private set; }
        public string NetworkPort { get; private set; }
        public string NetworkSwitch { get; private set; }
        public string Owner { get; private set; }

        public DeviceType DeviceType { get; private set; }
        public DeviceAdditionalInformation DeviceAdditionalInformation { get; private set; }
        public DeviceMappedDrivers DeviceMappedDrivers { get; private set; }
        public KnowledgeBaseArticle KnowledgeBaseArticle { get; private set; }
        public LifeCycle LifeCycle { get; private set; }
        public Server Server { get; private set; }
        public Software Software { get; private set; }
        public Vendor Vendor { get; private set; }

       
      
    }
}