using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Services.ComputerServices
{
    public interface IComputerService
    {
        Task<List<Computer>> GetAllComputers();
        
        Task<Computer?> GetSingleComputerByName(string computername);

        Task<List<Computer>> AddComputer(Computer computer);

        Task<List<Computer>?> UpdateComputer(int computerId, Computer request);

        Task<List<Computer>?> DeleteComputer(string computername);

    }
}