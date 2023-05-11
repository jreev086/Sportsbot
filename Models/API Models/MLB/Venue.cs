using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class Venue
    {
        public Venue()
        {
            Id = 0;
            Name = string.Empty;
            Link = string.Empty;
        }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("link")]
        public string? Link { get; set; }
    }
}
