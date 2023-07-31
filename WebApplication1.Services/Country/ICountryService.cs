using GlobalInformation.Domain;

namespace GlobalInformation.Services.Country;

public interface ICountryService
{
    Task<CountryDetails> GetCountryDetailsAsync(string countryName);
    Task<IEnumerable<Domain.Country>> GetAllCountriesAsync();
    Task<RegionDetails> GetRegionDetailsAsync(string regionName);
    Task<SubRegionDetails> GetSubRegionDetailsAsync(string subregionName);
}