namespace GlobalInformation.Domain.Responses;

public class CurrenciesResponse<T>
{
    public T VUV { get; set; }
    public T USD { get; set; }
    public T NZD { get; set; }
    public T TOP { get; set; }
    public T XPF { get; set; }
    public T AUD { get; set; }
    public T KID { get; set; }
    public T WST { get; set; }
    public T PGK { get; set; }
    public T SBD { get; set; }
    public T TVD { get; set; }
    public T CKD { get; set; }
    public T FJD { get; set; }
}

public class Currency
{
    public string name { get; set; }
    public string symbol { get; set; }
}
