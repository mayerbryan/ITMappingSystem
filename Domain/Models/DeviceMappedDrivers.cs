namespace Domain.Models
{
    public class DeviceMappedDrivers
    {
        public DeviceMappedDrivers(string driverPath) 
        {
            DriverPath = driverPath;
   
        }
        public string DriverPath { get; set; }
    }
}