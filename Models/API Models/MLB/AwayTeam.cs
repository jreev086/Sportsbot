using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class AwayTeam
    {
        [JsonPropertyName("leagueRecord")]
        public LeagueRecord? LeagueRecord;

        [JsonPropertyName("score")]
        public int Score;

        [JsonPropertyName("team")]
        public Team? Team;

        [JsonPropertyName("isWinner")]
        public bool IsWinner;

        [JsonPropertyName("splitSquad")]
        public bool SplitSquad;

        [JsonPropertyName("seriesNumber")]
        public int SeriesNumber;
    }

}
