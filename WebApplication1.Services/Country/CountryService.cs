using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using GlobalInformation.Common.Configuration;
using GlobalInformation.Domain;
using GlobalInformation.Domain.Responses;

namespace GlobalInformation.Services.Country;

public class CountryService : ICountryService
{
    private readonly HttpClient _httpClient;
    private readonly IOptions<EndpointSettings> _settings;

    public CountryService(IOptions<EndpointSettings> settings)
    {
        _settings = settings;
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(_settings.Value.BaseUrl)
        };
    }

    public async Task<IEnumerable<Domain.Country>> GetAllCountriesAsync()
    {
        var response = await _httpClient.GetAsync("all");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var countries = JsonConvert.DeserializeObject<List<CountryResponse<Currency>>>(content);

        return Domain.Country.ToCountryList(countries);
    }

    public async Task<CountryDetails> GetCountryDetailsAsync(string countryName)
    {
        var response = await _httpClient.GetAsync($"name/{countryName}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var countryDetails = JsonConvert.DeserializeObject<List<CountryDetailsResponse<Currency>>>(content);

        return new CountryDetails(countryDetails[0]);
    }

    public async Task<RegionDetails> GetRegionDetailsAsync(string regionName)
    {
        var response = await _httpClient.GetAsync($"region/{regionName}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var regionDetails = JsonConvert.DeserializeObject<List<RegionDetailsResponse<Currency>>>(content);

        return new RegionDetails(regionDetails);
    }

    public async Task<SubRegionDetails> GetSubRegionDetailsAsync(string subregionName)
    {
        var response = await _httpClient.GetAsync($"subregion/{subregionName}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var subRegionDetails = JsonConvert.DeserializeObject<List<SubRegionDetailsResponse<Currency>>>(content);

        return new SubRegionDetails(subRegionDetails);
    }
}