using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class GameRoot
    {
        [JsonPropertyName("copyright")]
        public string? Copyright;

        [JsonPropertyName("totalItems")]
        public int? TotalItems;

        [JsonPropertyName("totalEvents")]
        public int? TotalEvents;

        [JsonPropertyName("totalGames")]
        public int? TotalGames;

        [JsonPropertyName("totalGamesInProgress")]
        public int? TotalGamesInProgress;

        [JsonPropertyName("dates")]
        public List<DateType>? Dates;
    }
}
