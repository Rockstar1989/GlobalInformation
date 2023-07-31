using Newtonsoft.Json;

namespace GlobalInformation.Domain.Responses;

public class Gini
{
    [JsonProperty("2010")]
    public double _2010 { get; set; }

    [JsonProperty("2015")]
    public double? _2015 { get; set; }

    [JsonProperty("2012")]
    public double? _2012 { get; set; }

    [JsonProperty("2006")]
    public double? _2006 { get; set; }

    [JsonProperty("2013")]
    public double? _2013 { get; set; }

    [JsonProperty("2009")]
    public double? _2009 { get; set; }

    [JsonProperty("2014")]
    public double? _2014 { get; set; }
}

public class RegionDetailsResponse<T> : BaseResponse
{
    public Name name { get; set; }
    public List<string> tld { get; set; }
    public string cca2 { get; set; }
    public string ccn3 { get; set; }
    public string cca3 { get; set; }
    public string cioc { get; set; }
    public bool independent { get; set; }
    public string status { get; set; }
    public bool unMember { get; set; }
    public CurrenciesResponse<T> currencies { get; set; }
    public Idd idd { get; set; }
    public List<string> capital { get; set; }
    public List<string> altSpellings { get; set; }
    public string region { get; set; }
    public string subregion { get; set; }
    public LanguagesResponse languages { get; set; }
    public TranslationsResponse translations { get; set; }
    public List<double> latlng { get; set; }
    public bool landlocked { get; set; }
    public double area { get; set; }
    public Demonyms demonyms { get; set; }
    public string flag { get; set; }
    public Maps maps { get; set; }
    public int population { get; set; }
    public Gini gini { get; set; }
    public string fifa { get; set; }
    public Car car { get; set; }
    public List<string> timezones { get; set; }
    public List<string> continents { get; set; }
    public Flags flags { get; set; }
    public CoatOfArms coatOfArms { get; set; }
    public string startOfWeek { get; set; }
    public CapitalInfo capitalInfo { get; set; }
    public PostalCode postalCode { get; set; }
    public List<string> borders { get; set; }
}