using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class Content
    {
        [JsonPropertyName("link")]
        public string? Link;
    }

}
