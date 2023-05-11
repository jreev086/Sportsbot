using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class TeamRoot
    {
        public TeamRoot()
        {
            Copyright = string.Empty;
            Teams = new List<Team>();
        }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("teams")]
        public List<Team> Teams { get; set; }
    }
}