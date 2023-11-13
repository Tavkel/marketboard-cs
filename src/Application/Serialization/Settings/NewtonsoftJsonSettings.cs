
using marketboard.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace marketboard.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}