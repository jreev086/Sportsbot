using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class Game
    {
        [JsonPropertyName("gamePk")]
        public int? GamePk;

        [JsonPropertyName("link")]
        public string? Link;

        [JsonPropertyName("gameType")]
        public string? GameType;

        [JsonPropertyName("season")]
        public string? Season;

        [JsonPropertyName("gameDate")]
        public DateTime? GameDate;

        [JsonPropertyName("officialDate")]
        public string? OfficialDate;

        [JsonPropertyName("status")]
        public GameStatus? Status;

        [JsonPropertyName("teams")]
        public TeamsType? Teams;

        [JsonPropertyName("venue")]
        public Venue? Venue;

        [JsonPropertyName("content")]
        public Content? Content;

        [JsonPropertyName("isTie")]
        public bool? IsTie;

        [JsonPropertyName("gameNumber")]
        public int? GameNumber;

        [JsonPropertyName("publicFacing")]
        public bool? PublicFacing;

        [JsonPropertyName("doubleHeader")]
        public string? DoubleHeader;

        [JsonPropertyName("gamedayType")]
        public string? GamedayType;

        [JsonPropertyName("tiebreaker")]
        public string? Tiebreaker;

        [JsonPropertyName("calendarEventID")]
        public string? CalendarEventID;

        [JsonPropertyName("seasonDisplay")]
        public string? SeasonDisplay;

        [JsonPropertyName("dayNight")]
        public string? DayNight;

        [JsonPropertyName("scheduledInnings")]
        public int? ScheduledInnings;

        [JsonPropertyName("reverseHomeAwayStatus")]
        public bool? ReverseHomeAwayStatus;

        [JsonPropertyName("inningBreakLength")]
        public int? InningBreakLength;

        [JsonPropertyName("gamesInSeries")]
        public int? GamesInSeries;

        [JsonPropertyName("seriesGameNumber")]
        public int? SeriesGameNumber;

        [JsonPropertyName("seriesDescription")]
        public string? SeriesDescription;

        [JsonPropertyName("recordSource")]
        public string? RecordSource;

        [JsonPropertyName("ifNecessary")]
        public string? IfNecessary;

        [JsonPropertyName("ifNecessaryDescription")]
        public string? IfNecessaryDescription;
    }

}
