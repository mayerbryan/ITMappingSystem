using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ITMappingSystem.Services.ComputerServices;

namespace ITMappingSystem.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerController : ControllerBase
    {
        private readonly IComputerService _ComputerService;
        public ComputerController(IComputerService computerService)
        {
            _ComputerService = computerService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Computer>>> AddComputer(Computer computer)
        {
            var result = await _ComputerService.AddComputer(computer);
            return Ok(result);
        }

        [HttpDelete("{computerName}")]
        public async Task<ActionResult<List<Computer>>> DeleteComputer(string computername)
        {
            var result = await _ComputerService.DeleteComputer(computername);
            if (result is null)
                return NotFound("this computer can't be found in the records");
            return Ok(result);
        }


        [HttpGet]
        public async Task<ActionResult<List<Computer>>> GetAllComputers()
        {
            return await _ComputerService.GetAllComputers();
        }

        [HttpGet("{computerName}")]
        public async Task<ActionResult<ComputerController>> GetSingleComputerByName(string computername)
        {
            Console.WriteLine("entered a request");
            var result = await _ComputerService.GetSingleComputerByName(computername);
            if (result is null)
                return NotFound("this computer can't be found in the records");
            return Ok(result);
        }

        
        [HttpPut("{computerId}")]
        public async Task<ActionResult<List<Computer>>> UpdateComputer(int computerId, Computer request)
        {
            var result = await _ComputerService.UpdateComputer(computerId, request);
            if (result is null)
                return NotFound("this computer can't be found in the records");
            return Ok(result);
        }
    }
}