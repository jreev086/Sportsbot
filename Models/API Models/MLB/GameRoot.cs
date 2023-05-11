using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class GameRoot
    {
        public GameRoot()
        {
            Copyright =  string.Empty;
            TotalItems = 0;
            TotalEvents = 0;
            TotalGames = 0;
            TotalGamesInProgress = 0;
            Dates = new List<DateType>();
        }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("totalItems")]
        public int TotalItems { get; set; }

        [JsonPropertyName("totalEvents")]
        public int TotalEvents { get; set; }

        [JsonPropertyName("totalGames")]
        public int TotalGames { get; set; }

        [JsonPropertyName("totalGamesInProgress")]
        public int TotalGamesInProgress { get; set; }

        [JsonPropertyName("dates")]
        public List<DateType> Dates { get; set; }
    }
}
