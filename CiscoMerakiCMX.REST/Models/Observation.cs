namespace CiscoMerakiCMX.REST.Models
{
    public class Observation
    {
        public string ipv4 { get; set; }
        public Location location { get; set; }
        public string seenTime { get; set; }
        public string ssid { get; set; }
        public string os { get; set; }
        public string clientMac { get; set; }
        public int seenEpoch { get; set; }
        public int rssi { get; set; }
        public string ipv6 { get; set; }
        public string manufacturer { get; set; }
    }
}