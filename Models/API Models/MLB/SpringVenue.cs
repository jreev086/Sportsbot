using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class SpringVenue
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("link")]
        public string? Link;
    }
}
