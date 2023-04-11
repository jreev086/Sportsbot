using System.Text.Json.Serialization;

namespace Sportsbot.API_Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Division
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("link")]
        public string Link;
    }

    public class League
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("link")]
        public string Link;
    }

    public class TeamRoot
    {
        [JsonPropertyName("copyright")]
        public string Copyright;

        [JsonPropertyName("teams")]
        public List<Team> Teams;
    }

    public class Sport
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("link")]
        public string Link;

        [JsonPropertyName("name")]
        public string Name;
    }

    public class SpringLeague
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("link")]
        public string Link;

        [JsonPropertyName("abbreviation")]
        public string Abbreviation;
    }

    public class SpringVenue
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("link")]
        public string Link;
    }
}
