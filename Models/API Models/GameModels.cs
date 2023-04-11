namespace Sportsbot.API_Models
{
    using System.Text.Json.Serialization;

    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Away
    {
        [JsonPropertyName("leagueRecord")]
        public LeagueRecord? LeagueRecord;

        [JsonPropertyName("score")]
        public int? Score;

        [JsonPropertyName("team")]
        public Team Team;

        [JsonPropertyName("isWinner")]
        public bool? IsWinner;

        [JsonPropertyName("splitSquad")]
        public bool? SplitSquad;

        [JsonPropertyName("seriesNumber")]
        public int? SeriesNumber;
    }

    public class Content
    {
        [JsonPropertyName("link")]
        public string? Link;
    }

    public class DateType
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
        public List<Game> Games;

        [JsonPropertyName("events")]
        public List<object> Events;
    }

    public class Game
    {
        [JsonPropertyName("gamePk")]
        public int? GamePk;

        [JsonPropertyName("link")]
        public string Link;

        [JsonPropertyName("gameType")]
        public string GameType;

        [JsonPropertyName("season")]
        public string Season;

        [JsonPropertyName("gameDate")]
        public DateTime? GameDate;

        [JsonPropertyName("officialDate")]
        public string OfficialDate;

        [JsonPropertyName("status")]
        public Status Status;

        [JsonPropertyName("teams")]
        public Teams Teams;

        [JsonPropertyName("venue")]
        public Venue Venue;

        [JsonPropertyName("content")]
        public Content Content;

        [JsonPropertyName("isTie")]
        public bool? IsTie;

        [JsonPropertyName("gameNumber")]
        public int? GameNumber;

        [JsonPropertyName("publicFacing")]
        public bool? PublicFacing;

        [JsonPropertyName("doubleHeader")]
        public string DoubleHeader;

        [JsonPropertyName("gamedayType")]
        public string GamedayType;

        [JsonPropertyName("tiebreaker")]
        public string Tiebreaker;

        [JsonPropertyName("calendarEventID")]
        public string CalendarEventID;

        [JsonPropertyName("seasonDisplay")]
        public string SeasonDisplay;

        [JsonPropertyName("dayNight")]
        public string DayNight;

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
        public string SeriesDescription;

        [JsonPropertyName("recordSource")]
        public string RecordSource;

        [JsonPropertyName("ifNecessary")]
        public string IfNecessary;

        [JsonPropertyName("ifNecessaryDescription")]
        public string IfNecessaryDescription;
    }

    public class Home
    {
        [JsonPropertyName("leagueRecord")]
        public LeagueRecord LeagueRecord;

        [JsonPropertyName("score")]
        public int? Score;

        [JsonPropertyName("team")]
        public Team Team;

        [JsonPropertyName("isWinner")]
        public bool? IsWinner;

        [JsonPropertyName("splitSquad")]
        public bool? SplitSquad;

        [JsonPropertyName("seriesNumber")]
        public int? SeriesNumber;
    }

    public class LeagueRecord
    {
        [JsonPropertyName("wins")]
        public int? Wins;

        [JsonPropertyName("losses")]
        public int? Losses;

        [JsonPropertyName("pct")]
        public string Pct;
    }

    public class GameRoot
    {
        [JsonPropertyName("copyright")]
        public string Copyright;

        [JsonPropertyName("totalItems")]
        public int? TotalItems;

        [JsonPropertyName("totalEvents")]
        public int? TotalEvents;

        [JsonPropertyName("totalGames")]
        public int? TotalGames;

        [JsonPropertyName("totalGamesInProgress")]
        public int? TotalGamesInProgress;

        [JsonPropertyName("dates")]
        public List<DateType> Dates;
    }

    public class Status
    {
        [JsonPropertyName("abstractGameState")]
        public string AbstractGameState;

        [JsonPropertyName("codedGameState")]
        public string CodedGameState;

        [JsonPropertyName("detailedState")]
        public string DetailedState;

        [JsonPropertyName("statusCode")]
        public string StatusCode;

        [JsonPropertyName("startTimeTBD")]
        public bool? StartTimeTBD;

        [JsonPropertyName("abstractGameCode")]
        public string AbstractGameCode;
    }

    public class Teams
    {
        [JsonPropertyName("away")]
        public Away Away;

        [JsonPropertyName("home")]
        public Home Home;
    }
}