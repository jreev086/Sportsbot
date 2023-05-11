using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class Sport
    {
        public Sport()
        {
            Id = 0;
            Link = string.Empty;
            Name = string.Empty;
        }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
