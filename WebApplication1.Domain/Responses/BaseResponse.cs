namespace GlobalInformation.Domain.Responses;

public partial class BaseResponse
{
    public class PostalCode
    {
        public string format { get; set; }
        public string regex { get; set; }
    }

    public class CapitalInfo
    {
        public List<double> latlng { get; set; }
    }

    public class Car
    {
        public List<string> signs { get; set; }
        public string side { get; set; }
    }

    public class CoatOfArms
    {
    }

    public class Demonyms
    {
        public Translate eng { get; set; }
        public Translate fra { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
    }

    public class Idd
    {
        public string root { get; set; }
        public List<string> suffixes { get; set; }
    }

    public class Maps
    {
        public string googleMaps { get; set; }
        public string openStreetMaps { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public NativeName nativeName { get; set; }
    }

    public class NativeName
    {
        public Translate eng { get; set; }
        public Translate smo { get; set; }
    }
}
