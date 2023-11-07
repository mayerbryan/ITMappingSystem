using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ITMappingSystem.Services.ComputerServices;

namespace ITMappingSystem.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

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
            var result = _ComputerService.AddComputer(computer);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<Computer>>> GetAllComputers()
        {
            return await _ComputerService.GetAllComputers();
        }



        // [HttpGet("{name}")]
        // public async Task<ActionResult<ComputerController>> GetSingleComputerByName(string computername)
        // {
        //     var result = _ComputerService.GetSingleComputerByName(computername);
        //     if (result is null)
        //         return NotFound("this computer can't be found in the records");
        //     return Ok(result);
        // }

        // [HttpDelete("id")]
        // public async Task<ActionResult<List<Computer>>> DeleteComputer(string computername)
        // {
        //     var result = _ComputerService.DeleteComputer(computername);
        //     if (result is null)
        //         return NotFound("this computer can't be found in the records");
        //     return Ok(result);
        // }

        // [HttpPut("{id}")]
        // public async Task<ActionResult<List<Computer>>> UpdateComputer(string computername, Computer request)
        // {
        //     var result = _ComputerService.UpdateComputer(computername, request);
        //     if (result is null)
        //         return NotFound("this computer can't be found in the records");
        //     return Ok(result);
        // }
    }
}