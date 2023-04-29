using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class SpringLeague
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("name")]
        public string? Name;

        [JsonPropertyName("link")]
        public string? Link;

        [JsonPropertyName("abbreviation")]
        public string? Abbreviation;
    }
}
