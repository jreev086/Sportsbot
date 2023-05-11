using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class SpringLeague
    {
        public SpringLeague()
        {
            Id = 0;
            Name = string.Empty;
            Link = string.Empty;
            Abbreviation = string.Empty;
        }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }
    }
}
