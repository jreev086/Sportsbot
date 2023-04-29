using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class TeamRoot
    {
        [JsonPropertyName("copyright")]
        public string? Copyright;

        [JsonPropertyName("teams")]
        public List<Team>? Teams;
    }
}