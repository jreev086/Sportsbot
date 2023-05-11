using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class GameStatus
    {
        public GameStatus()
        {
            AbstractGameState = string.Empty;
            CodedGameState = string.Empty;
            DetailedState = string.Empty;
            StatusCode = string.Empty;
            StartTimeTBD = false;
            AbstractGameCode = string.Empty;
        }

        [JsonPropertyName("abstractGameState")]
        public string AbstractGameState { get; set; }

        [JsonPropertyName("codedGameState")]
        public string CodedGameState { get; set; }

        [JsonPropertyName("detailedState")]
        public string DetailedState { get; set; }

        [JsonPropertyName("statusCode")]
        public string StatusCode { get; set; }

        [JsonPropertyName("startTimeTBD")]
        public bool StartTimeTBD { get; set; }

        [JsonPropertyName("abstractGameCode")]
        public string AbstractGameCode { get; set; }
    }
}
