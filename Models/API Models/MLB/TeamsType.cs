using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class TeamsType
    {
        public TeamsType()
        {
            Away = new AwayTeam();
            Home = new HomeTeam();
        }

        [JsonPropertyName("away")]
        public AwayTeam Away { get; set; }

        [JsonPropertyName("home")]
        public HomeTeam Home { get; set; }
    }
}
