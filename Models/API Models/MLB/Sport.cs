using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class Sport
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("link")]
        public string? Link;

        [JsonPropertyName("name")]
        public string? Name;
    }
}
