namespace CiscoMerakiCMX.REST.Models
{
    public class Root
    {
        public string version { get; set; }
        public string secret { get; set; }
        public string type { get; set; }
        public Data data { get; set; }
    }
}