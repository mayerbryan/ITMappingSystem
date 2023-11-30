namespace Domain.Models
{
    public class Network
    {
        public Network(string networkPort, string networkSwitch)
        {
            NetworkPort = networkPort;
            NetworkSwitch = networkSwitch;
        }

        public string NetworkPort { get; private set; }
        public string NetworkSwitch { get; private set; }
    }
}