using GlobalInformation.Domain.Responses;

namespace GlobalInformation.Domain.Helpers;

public static class LanguageHelper
{
    public static List<string> GetLanguages(LanguagesResponse languages)
    {
        if (languages == null)
        {
            return new List<string>() { "There are no official languages" };
        }

        var languageList = new List<string>();

        foreach (var property in typeof(LanguagesResponse).GetProperties())
        {
            var language = property.GetValue(languages) as string;
            if (language != null)
            {
                languageList.Add(language);
            }
        }

        return languageList;
    }
}
