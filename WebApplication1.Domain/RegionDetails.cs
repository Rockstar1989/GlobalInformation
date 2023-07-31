using GlobalInformation.Domain.Responses;

namespace GlobalInformation.Domain;

public class RegionDetails
{
    public string Name { get; set; }
    public long Population { get; set; }
    public List<string> Countries { get; set; }
    public List<string> Subregions { get; set; }

    public RegionDetails()
    {
        Countries = new List<string>();
        Subregions = new List<string>();
    }

    public RegionDetails(List<RegionDetailsResponse<Currency>> regionDetailsResponse) : this()
    {
        Name = regionDetailsResponse[0].region;
        Population = regionDetailsResponse.Sum(x => x.population);

        var countries = regionDetailsResponse.Select(x => x.name.official).Distinct();
        Countries.AddRange(countries.Any() ? countries : new List<string>() { "There are no countries in this region" });

        var subregions = regionDetailsResponse.Select(x => x.subregion).Distinct();
        Subregions.AddRange(subregions.Any() ? subregions : new List<string>() { "There are no sub regions in this region" });
    }
}
