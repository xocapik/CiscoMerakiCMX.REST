namespace CiscoMerakiCMX.REST.Models
{
    public class Location
    {
        public float lat { get; set; }
        public float lng { get; set; }
        public float unc { get; set; }
        public float[] x { get; set; }
        public float[] y { get; set; }
    }
}