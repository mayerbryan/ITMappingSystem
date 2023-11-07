using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Services.ComputerServices
{
    public interface IComputerService
    {
        Task<List<Computer>> GetAllComputers();
        
        Computer? GetSingleComputerByName(string name);

        List<Computer> AddComputer(Computer computer);

        List<Computer>? UpdateComputer(string computername, Computer request);

        List<Computer>? DeleteComputer(string computername);

    }
}