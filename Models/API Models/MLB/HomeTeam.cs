using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class HomeTeam
    {
        public HomeTeam()
        {
            LeagueRecord =  new LeagueRecord();
            Score = 0;
            Team =  new Team();
            IsWinner = false;
            SplitSquad = false;
            SeriesNumber = 0;
        }

        [JsonPropertyName("leagueRecord")]
        public LeagueRecord LeagueRecord { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("isWinner")]
        public bool IsWinner { get; set; }

        [JsonPropertyName("splitSquad")]
        public bool SplitSquad { get; set; }

        [JsonPropertyName("seriesNumber")]
        public int SeriesNumber { get; set; }
    }
}