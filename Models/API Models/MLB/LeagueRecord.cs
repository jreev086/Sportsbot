using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class LeagueRecord
    {
        [JsonPropertyName("wins")]
        public int? Wins;

        [JsonPropertyName("losses")]
        public int? Losses;

        [JsonPropertyName("pct")]
        public string? Pct;
    }
}
