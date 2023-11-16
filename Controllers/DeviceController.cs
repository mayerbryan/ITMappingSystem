using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ITMappingSystem.Services.DeviceServices;

namespace ITMappingSystem.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _DeviceService;
        public DeviceController(IDeviceService DeviceService)
        {
            _DeviceService = DeviceService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Device>>> AddDevice(Device Device)
        {
            var result = await _DeviceService.AddDevice(Device);
            return Ok(result);
        }

        [HttpDelete("{DeviceName}")]
        public async Task<ActionResult<List<Device>>> DeleteDevice(string Devicename)
        {
            var result = await _DeviceService.DeleteDevice(Devicename);
            if (result is null)
                return NotFound("this Device can't be found in the records");
            return Ok(result);
        }


        [HttpGet]
        public async Task<ActionResult<List<Device>>> GetAllDevices()
        {
            return await _DeviceService.GetAllDevices();
        }

        [HttpGet("{DeviceName}")]
        public async Task<ActionResult<DeviceController>> GetSingleDeviceByName(string Devicename)
        {
            Console.WriteLine("entered a request");
            var result = await _DeviceService.GetSingleDeviceByName(Devicename);
            if (result is null)
                return NotFound("this Device can't be found in the records");
            return Ok(result);
        }

        
        [HttpPut("{DeviceId}")]
        public async Task<ActionResult<List<Device>>> UpdateDevice(int DeviceId, Device request)
        {
            var result = await _DeviceService.UpdateDevice(DeviceId, request);
            if (result is null)
                return NotFound("this Device can't be found in the records");
            return Ok(result);
        }
    }
}