using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class LeagueRecord
    {
        public LeagueRecord()
        {
            Wins = 0;
            Losses = 0;
            Pct = string.Empty;
        }

        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        [JsonPropertyName("losses")]
        public int Losses { get; set; }

        [JsonPropertyName("pct")]
        public string Pct { get; set; }
    }
}
