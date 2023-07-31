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

        Countries.AddRange(regionDetailsResponse.Select(x => x.name.official).Distinct());

        Subregions.AddRange(regionDetailsResponse.Select(x => x.subregion).Distinct());
    }
}
