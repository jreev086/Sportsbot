using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class TeamsType
    {
        [JsonPropertyName("away")]
        public AwayTeam? Away;

        [JsonPropertyName("home")]
        public HomeTeam? Home;
    }
}
