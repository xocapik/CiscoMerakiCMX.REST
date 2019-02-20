namespace CiscoMerakiCMX.REST.Models
{
    public class Data
    {
        public string apMac { get; set; }
        public string[] apTags { get; set; }
        public string[] apFloors { get; set; }
        public Observation[] observations { get; set; }
    }
}

