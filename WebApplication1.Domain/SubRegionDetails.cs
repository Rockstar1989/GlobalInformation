using GlobalInformation.Domain.Responses;

namespace GlobalInformation.Domain;

public class SubRegionDetails
{
    public string Name { get; set; }
    public long Population { get; set; }
    public string Region { get; set; }
    public List<string> Countries { get; set; }

    public SubRegionDetails()
    {
        Countries = new List<string>();
    }

    public SubRegionDetails(List<SubRegionDetailsResponse<Currency>> subRegionDetailsResponse) : this()
    {
        Name = subRegionDetailsResponse[0].subregion;
        Population = subRegionDetailsResponse.Sum(x => x.population);
        Region = subRegionDetailsResponse[0].region;

        Countries.AddRange(subRegionDetailsResponse.Select(x => x.name.official).Distinct());
    }
}
