using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class League
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("name")]
        public string? Name;

        [JsonPropertyName("link")]
        public string? Link;
    }
}
