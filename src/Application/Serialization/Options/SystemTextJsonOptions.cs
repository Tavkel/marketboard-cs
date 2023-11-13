using System.Text.Json;
using marketboard.Application.Interfaces.Serialization.Options;

namespace marketboard.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}