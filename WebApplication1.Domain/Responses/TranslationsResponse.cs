namespace GlobalInformation.Domain.Responses;

public class TranslationsResponse
{
    public Translate ara { get; set; }
    public Translate bre { get; set; }
    public Translate ces { get; set; }
    public Translate cym { get; set; }
    public Translate deu { get; set; }
    public Translate est { get; set; }
    public Translate fin { get; set; }
    public Translate fra { get; set; }
    public Translate hrv { get; set; }
    public Translate hun { get; set; }
    public Translate ita { get; set; }
    public Translate jpn { get; set; }
    public Translate kor { get; set; }
    public Translate nld { get; set; }
    public Translate per { get; set; }
    public Translate pol { get; set; }
    public Translate por { get; set; }
    public Translate rus { get; set; }
    public Translate slk { get; set; }
    public Translate spa { get; set; }
    public Translate srp { get; set; }
    public Translate swe { get; set; }
    public Translate tur { get; set; }
    public Translate urd { get; set; }
    public Translate zho { get; set; }
}

public class Translate
{
    public string official { get; set; }
    public string common { get; set; }
    public string f { get; set; }
    public string m { get; set; }
}
