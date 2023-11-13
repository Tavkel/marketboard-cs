using System.Linq;
using marketboard.Shared.Constants.Localization;
using marketboard.Shared.Settings;

namespace marketboard.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}