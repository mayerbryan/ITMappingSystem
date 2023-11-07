using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITMappingSystem.Data;

namespace ITMappingSystem.Services.ComputerServices
{
    public class ComputerService : IComputerService
    {
        private static List<Computer> computers = new List<Computer>
        {

        };

        private readonly DataBaseContext _dataBaseContext;

        public ComputerService(DataBaseContext context) {
            _dataBaseContext = context;
        }

        List<Computer> IComputerService.AddComputer(Computer computer)
        {
            throw new NotImplementedException();
        }

        List<Computer>? IComputerService.DeleteComputer(string computername)
        {
            throw new NotImplementedException();
        }

        Task<List<Computer>> IComputerService.GetAllComputers()
        {
            throw new NotImplementedException();
        }

        Computer? IComputerService.GetSingleComputerByName(string name)
        {
            throw new NotImplementedException();
        }

        List<Computer>? IComputerService.UpdateComputer(string computername, Computer request)
        {
            throw new NotImplementedException();
        }














        // public List<Computer> AddComputer(Computer computer)
        // {
        //     return await _dataBaseContext.Computer.ToListAsync();
        // }

        // public async Task<List<Computer>> GetAllComputers()
        // {
        //     var computers = await _dataBaseContext.Computer.ToListAsync();
        //     return computers;
        // }

        // public List<Computer>? DeleteComputer(string computername)
        // {
        //     var computer = _dataBaseContext.Computer.FindAsync(computername);
        //     if (computer is null)
        //         return null;
        //     computers.Remove(computer);
        //     return await _dataBaseContext.Computer.ToListAsync();
        // }        

        // public async Task<Computer>? GetSingleComputerByName(string name)
        // {
        //     var computer = _dataBaseContext.Computer.FindAsync(name);
        //     if (computer is null)
        //         return null;
        //     return computer;
        // }      

        // public List<Computer>? UpdateComputer(string computername, Computer request)
        // {
        //     var computer = _dataBaseContext.Computer.FindAsync(computername);
        //     if (computer is null)
        //         return null;

        //     computer.computerName = request.computerName;
        //     computer.computerIP = request.computerIP;
        //     computer.computerLocationDescription = request.computerLocationDescription;
        //     computer.computerNetworkPort = request.computerNetworkPort;
        //     computer.computerOperatingSystem = request.computerOperatingSystem;
        //     computer.computerResponsibleEngineer = request.computerResponsibleEngineer;
        //     computer.ComputerVendors = computer.ComputerVendors;
        //     computer.computerImage = request.computerImage;
        //     computer.computerMapImage = request.computerMapImage;

        //     return await _dataBaseContext.Computer.ToListAsync();

        // }
    }
}