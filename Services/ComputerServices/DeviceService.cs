using Microsoft.EntityFrameworkCore;
using ITMappingSystem.Data;


namespace ITMappingSystem.Services.DeviceServices
{
    public class DeviceService : IDeviceService
    {
        private static List<Device> Devices = new List<Device>
        {

        };

        private readonly DataBaseContext _dataBaseContext;

        public DeviceService(DataBaseContext context) {
            _dataBaseContext = context;
        }

        public async Task<List<Device>> AddDevice(Device Device)
        {
            _dataBaseContext.Devices.Add(Device);
            await _dataBaseContext.SaveChangesAsync();
            return Devices;
        }

        

        public async Task<List<Device>?> DeleteDevice(string Devicename)
        {
            var deletedDevice = await _dataBaseContext.Devices.FirstOrDefaultAsync();
            if (deletedDevice is null)
                return null;

            _dataBaseContext.Devices.Remove(deletedDevice);
            await _dataBaseContext.SaveChangesAsync();

            return await _dataBaseContext.Devices.ToListAsync();
        }

        public async Task<List<Device>> GetAllDevices()
        {
            var Devices = await _dataBaseContext.Devices.ToListAsync();
            return Devices;
        }

        public async Task<Device?> GetSingleDeviceByName(string name)
        {
            Console.WriteLine("requested service");
            var getSingleDevice = await _dataBaseContext.Devices
                .Where(c => c.Name == name)
                .FirstOrDefaultAsync();

            if (getSingleDevice is null)
                return null;

            return getSingleDevice;
        }


        public async Task<List<Device>?> UpdateDevice(int id, Device request)
        {
            
            var existingDevice = await _dataBaseContext.Devices.FirstOrDefaultAsync(c => c.ID == id);

            if (existingDevice == null)
            {
                // Device with the specified ID was not found
                return false;
            }

            // Update properties of the existing device with the values from the updated device
            existingDevice.UpdateFrom(updatedDevice);

            try
            {
                // Save changes asynchronously
                await _dataBaseContext.SaveChangesAsync();
                return true; // Update successful
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, etc.
                return false; // Update failed
            }
        }














        // public List<Device> AddDevice(Device Device)
        // {
        //     return await _dataBaseContext.Device.ToListAsync();
        // }

        // public async Task<List<Device>> GetAllDevices()
        // {
        //     var Devices = await _dataBaseContext.Device.ToListAsync();
        //     return Devices;
        // }

        // public List<Device>? DeleteDevice(string Devicename)
        // {
        //     var Device = await _dataBaseContext.Device.FindAsync(Devicename);
        //     if (Device is null)
        //         return null;
        //     _dataBaseContext.Devices.Remove(Device);
        //     await _dataBaseContext.SaveChangesAsync();
        //      return Devices;
        // }        

        // public async Task<Device>? GetSingleDeviceByName(string Devicename)
        // {
        //     var Device = await _dataBaseContext.Device.FindAsync(Devicename);
        //     if (Device is null)
        //         return null;
        //     return Device;
        // }      

        // public List<Device>? UpdateDevice(string Devicename, Device request)
        // {
        //     var Device = await _dataBaseContext.Device.FindAsync(Devicename);
        //     if (Device is null)
        //         return null;

        //     Device.DeviceName = request.DeviceName;
        //     Device.DeviceIP = request.DeviceIP;
        //     Device.DeviceLocationDescription = request.DeviceLocationDescription;
        //     Device.DeviceNetworkPort = request.DeviceNetworkPort;
        //     Device.DeviceOperatingSystem = request.DeviceOperatingSystem;
        //     Device.DeviceResponsibleEngineer = request.DeviceResponsibleEngineer;
        //     Device.DeviceVendors = Device.DeviceVendors;
        //     Device.DeviceImage = request.DeviceImage;
        //     Device.DeviceMapImage = request.DeviceMapImage;
        //      await _dataBaseContext.SaveChangesAsync();

        //     return Devices;

        // }
    }
}