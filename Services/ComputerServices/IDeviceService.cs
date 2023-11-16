using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Services.DeviceServices
{
    public interface IDeviceService
    {
        Task<List<Device>> GetAllDevices();
        
        Task<Device?> GetSingleDeviceByName(string Devicename);

        Task<List<Device>> AddDevice(Device Device);

        Task<List<Device>?> UpdateDevice(int DeviceId, Device request);

        Task<List<Device>?> DeleteDevice(string Devicename);

    }
}