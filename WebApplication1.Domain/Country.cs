using GlobalInformation.Domain.Responses;

namespace GlobalInformation.Domain;

public class Country
{
    public string Name { get; set; }
    public string Region { get; set; }
    public string Subregion { get; set; }

    public Country(CountryResponse<Currency> countryResponse)
    {
        Name = countryResponse.name.official;
        Region = countryResponse.region;
        Subregion = countryResponse.subregion;
    }

    public static IEnumerable<Country> ToCountryList(List<CountryResponse<Currency>>? countryResponses) =>
        countryResponses.Select(x => new Country(x));
}
