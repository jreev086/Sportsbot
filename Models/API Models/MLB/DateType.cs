using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class DateType
    {
        public DateType()
        {
            Date = string.Empty;
            TotalItems = 0;
            TotalEvents = 0;
            TotalGames = 0;
            TotalGamesInProgress = 0;
            Games = new List<Game>();
            Events = new List<object> { };
        }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("totalItems")]
        public int TotalItems { get; set; }

        [JsonPropertyName("totalEvents")]
        public int TotalEvents { get; set; }

        [JsonPropertyName("totalGames")]
        public int TotalGames { get; set; }

        [JsonPropertyName("totalGamesInProgress")]
        public int TotalGamesInProgress { get; set; }

        [JsonPropertyName("games")]
        public List<Game> Games { get; set; }

        [JsonPropertyName("events")]
        public List<object> Events { get; set; }
    }

}
