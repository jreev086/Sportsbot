using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class DateType
    {
        [JsonPropertyName("date")]
        public string? Date;

        [JsonPropertyName("totalItems")]
        public int? TotalItems;

        [JsonPropertyName("totalEvents")]
        public int? TotalEvents;

        [JsonPropertyName("totalGames")]
        public int? TotalGames;

        [JsonPropertyName("totalGamesInProgress")]
        public int? TotalGamesInProgress;

        [JsonPropertyName("games")]
        public List<Game>? Games;

        [JsonPropertyName("events")]
        public List<object>? Events;
    }

}
