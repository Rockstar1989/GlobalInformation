using GlobalInformation.Domain.Helpers;
using GlobalInformation.Domain.Responses;

namespace GlobalInformation.Domain;

public class CountryDetails
{
    public string Name { get; set; }
    public string Capital { get; set; }
    public long Population { get; set; }
    public List<string> Currencies { get; set; }
    public List<string> Languages { get; set; }
    public List<string> Borders { get; set; }

    public CountryDetails()
    {
        Currencies = new List<string>();
        Languages = new List<string>();
        Borders = new List<string>();
    }

    public CountryDetails(CountryDetailsResponse<Currency> countryDetailsResponse) : this()
    {
        Name = countryDetailsResponse.name.official;
        Capital = countryDetailsResponse.capital != null ? string.Join(",", countryDetailsResponse.capital) : "";
        Population = countryDetailsResponse.population;
        Currencies = CurrencyHelper.GetCurrencies(countryDetailsResponse.currencies);
        Languages = LanguageHelper.GetLanguages(countryDetailsResponse.languages);
        Borders = countryDetailsResponse.borders ?? new List<string>() { "There are no neighbouring countries/borders"};
    }
}
