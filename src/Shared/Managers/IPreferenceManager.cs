using marketboard.Shared.Settings;
using System.Threading.Tasks;
using marketboard.Shared.Wrapper;

namespace marketboard.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}