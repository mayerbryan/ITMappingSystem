using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;


namespace ITMappingSystem.Presentation.Models
{
    public class Device
    {
        public Device(int iD, string type, string name, string operatingSystem, int iP, string owner, Network network, DeviceType deviceType, DeviceAdditionalInformation deviceAdditionalInformation, DeviceMappedDrivers deviceMappedDrivers, Backup backup, KnowledgeBaseArticle knowledgeBaseArticle, LifeCycle lifeCycle, Server server, Software software, Vendor vendor)
        {
            ID = iD;
            Type = type;
            Name = name;
            OperatingSystem = operatingSystem;
            IP = iP;
            Owner = owner;
            Network = network;
            DeviceType = deviceType;
            DeviceAdditionalInformation = deviceAdditionalInformation;
            DeviceMappedDrivers = deviceMappedDrivers;
            Backup = backup;
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
        public string Owner { get; private set; }

        public Network Network {get; private set;}
        public DeviceType DeviceType { get; private set; }
        public DeviceAdditionalInformation DeviceAdditionalInformation { get; private set; }
        public DeviceMappedDrivers DeviceMappedDrivers { get; private set; }
        public Backup Backup { get; private set; }
        public KnowledgeBaseArticle KnowledgeBaseArticle { get; private set; }
        public LifeCycle LifeCycle { get; private set; }
        public Server Server { get; private set; }
        public Software Software { get; private set; }
        public Vendor Vendor { get; private set; }

        

        public void UpdateFrom(Device updatedDevice)
        {
            if (updatedDevice == null)
            {
                throw new ArgumentNullException(nameof(updatedDevice));
            }
            
            ID = updatedDevice.ID;
            Name = updatedDevice.Name;
            Type = updatedDevice.Type;
            OperatingSystem = updatedDevice.OperatingSystem;
            IP = updatedDevice.IP;
            Network = updatedDevice.Network;
            Owner = updatedDevice.Owner;
            DeviceType = updatedDevice.DeviceType;
            DeviceAdditionalInformation = updatedDevice.DeviceAdditionalInformation;
            DeviceMappedDrivers = updatedDevice.DeviceMappedDrivers;
            Backup = updatedDevice.Backup;
            KnowledgeBaseArticle = updatedDevice.KnowledgeBaseArticle;
            LifeCycle = updatedDevice.LifeCycle;
            Server = updatedDevice.Server;
            Software = updatedDevice.Software;
            Vendor = updatedDevice.Vendor;
        }

       
      
    }
}