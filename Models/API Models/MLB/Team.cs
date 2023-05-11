using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class Team
    {
        public Team()
        {
            SpringLeague = new SpringLeague();
            AllStarStatus = string.Empty;
            Id = 0;
            Name = string.Empty;
            Link = string.Empty;
            Season = 0;
            Venue = new Venue();
            SpringVenue = new SpringVenue();
            TeamCode = string.Empty;
            FileCode = string.Empty;
            Abbreviation = string.Empty;
            TeamName = string.Empty;
            LocationName = string.Empty;
            FirstYearOfPlay = string.Empty;
            League = new League();
            Division = new Division();
            Sport = new Sport();
            ShortName = string.Empty;
            FranchiseName = string.Empty;
            ClubName = string.Empty;
            Active = false;
        }

        [JsonPropertyName("springLeague")]
        public SpringLeague SpringLeague { get; set; }

        [JsonPropertyName("allStarStatus")]
        public string AllStarStatus { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }   

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("season")]
        public int Season { get; set; }

        [JsonPropertyName("venue")]
        public Venue Venue { get; set; }

        [JsonPropertyName("springVenue")]
        public SpringVenue SpringVenue { get; set; }

        [JsonPropertyName("teamCode")]
        public string TeamCode { get; set; }

        [JsonPropertyName("fileCode")]
        public string FileCode { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("teamName")]
        public string TeamName { get; set; }

        [JsonPropertyName("locationName")]
        public string LocationName { get; set; }

        [JsonPropertyName("firstYearOfPlay")]
        public string FirstYearOfPlay { get; set; }

        [JsonPropertyName("league")]
        public League League { get; set; }

        [JsonPropertyName("division")]
        public Division Division { get; set; }

        [JsonPropertyName("sport")]
        public Sport Sport { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("franchiseName")]
        public string FranchiseName { get; set; }

        [JsonPropertyName("clubName")]
        public string ClubName { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }
    }
}
