using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class SpringVenue
    {
        public SpringVenue()
        {
            Id = 0;
            Link = string.Empty;
        }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }
    }
}
