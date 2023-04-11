using System.Text.Json.Serialization;

namespace Sportsbot.API_Models
{
    public class Venue
    {
        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("link")]
        public string Link;
    }

    public class Team
    {
        [JsonPropertyName("springLeague")]
        public SpringLeague SpringLeague;

        [JsonPropertyName("allStarStatus")]
        public string AllStarStatus;

        [JsonPropertyName("id")]
        public int? Id;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("link")]
        public string Link;

        [JsonPropertyName("season")]
        public int? Season;

        [JsonPropertyName("venue")]
        public Venue Venue;

        [JsonPropertyName("springVenue")]
        public SpringVenue SpringVenue;

        [JsonPropertyName("teamCode")]
        public string TeamCode;

        [JsonPropertyName("fileCode")]
        public string FileCode;

        [JsonPropertyName("abbreviation")]
        public string Abbreviation;

        [JsonPropertyName("teamName")]
        public string TeamName;

        [JsonPropertyName("locationName")]
        public string LocationName;

        [JsonPropertyName("firstYearOfPlay")]
        public string FirstYearOfPlay;

        [JsonPropertyName("league")]
        public League League;

        [JsonPropertyName("division")]
        public Division Division;

        [JsonPropertyName("sport")]
        public Sport Sport;

        [JsonPropertyName("shortName")]
        public string ShortName;

        [JsonPropertyName("franchiseName")]
        public string FranchiseName;

        [JsonPropertyName("clubName")]
        public string ClubName;

        [JsonPropertyName("active")]
        public bool? Active;
    }

}
