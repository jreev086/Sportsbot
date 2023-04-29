using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class GameStatus
    {
        [JsonPropertyName("abstractGameState")]
        public string? AbstractGameState;

        [JsonPropertyName("codedGameState")]
        public string? CodedGameState;

        [JsonPropertyName("detailedState")]
        public string? DetailedState;

        [JsonPropertyName("statusCode")]
        public string? StatusCode;

        [JsonPropertyName("startTimeTBD")]
        public bool? StartTimeTBD;

        [JsonPropertyName("abstractGameCode")]
        public string? AbstractGameCode;
    }
}
