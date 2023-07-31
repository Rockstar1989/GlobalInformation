using GlobalInformation.Domain.Responses;

namespace GlobalInformation.Domain.Helpers;

public static class CurrencyHelper
{
    public static List<string> GetCurrencies<T>(CurrenciesResponse<T> currencies) where T : Currency
    {
        if (currencies == null)
        {
            return new List<string>();
        }

        var currencyList = new List<string>();

        foreach (var property in typeof(CurrenciesResponse<T>).GetProperties())
        {
            var currency = property.GetValue(currencies) as T;
            if (currency != null)
            {
                currencyList.Add(currency.name);
            }
        }

        return currencyList;
    }
}
