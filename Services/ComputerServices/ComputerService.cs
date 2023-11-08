using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITMappingSystem.Data;
using ITMappingSystem.Models;

namespace ITMappingSystem.Services.ComputerServices
{
    public class ComputerService : IComputerService
    {
        private static List<Computer> Computers = new List<Computer>
        {

        };

        private readonly DataBaseContext _dataBaseContext;

        public ComputerService(DataBaseContext context) {
            _dataBaseContext = context;
        }

        public async Task<List<Computer>> AddComputer(Computer computer)
        {
            _dataBaseContext.Computers.Add(computer);
            await _dataBaseContext.SaveChangesAsync();
            return Computers;
        }

        

        public async Task<List<Computer>?> DeleteComputer(string computername)
        {
            var deletedComputer = await _dataBaseContext.Computers.FirstOrDefaultAsync();
            if (deletedComputer is null)
                return null;

            _dataBaseContext.Computers.Remove(deletedComputer);
            await _dataBaseContext.SaveChangesAsync();

            return await _dataBaseContext.Computers.ToListAsync();
        }

        public async Task<List<Computer>> GetAllComputers()
        {
            var computers = await _dataBaseContext.Computers.ToListAsync();
            return computers;
        }

        public async Task<Computer?> GetSingleComputerByName(string computerName)
        {
            Console.WriteLine("requested service");
            var getSingleComputer = await _dataBaseContext.Computers
                .Where(c => c.computerName == computerName)
                .FirstOrDefaultAsync();

            if (getSingleComputer is null)
                return null;

            return getSingleComputer;
        }


        public async Task<List<Computer>?> UpdateComputer(int computerId, Computer request)
        {
            
            var updateComputer = await _dataBaseContext.Computers.Where(c=> c.computerID == computerId).FirstOrDefaultAsync();
            if (updateComputer is null)
                return null;

            updateComputer.computerName = request.computerName;

            await _dataBaseContext.SaveChangesAsync();
            return await _dataBaseContext.Computers.ToListAsync();
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
        //     var computer = await _dataBaseContext.Computer.FindAsync(computername);
        //     if (computer is null)
        //         return null;
        //     _dataBaseContext.computers.Remove(computer);
        //     await _dataBaseContext.SaveChangesAsync();
        //      return computers;
        // }        

        // public async Task<Computer>? GetSingleComputerByName(string computername)
        // {
        //     var computer = await _dataBaseContext.Computer.FindAsync(computername);
        //     if (computer is null)
        //         return null;
        //     return computer;
        // }      

        // public List<Computer>? UpdateComputer(string computername, Computer request)
        // {
        //     var computer = await _dataBaseContext.Computer.FindAsync(computername);
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
        //      await _dataBaseContext.SaveChangesAsync();

        //     return computers;

        // }
    }
}