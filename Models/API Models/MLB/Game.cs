using System.Text.Json.Serialization;

namespace Sportsbot.Models.API_Models.MLB
{
    internal class Game
    {
        public Game()
        {
            GamePk = 0;
            Link = string.Empty;
            GameType = string.Empty;
            Season = string.Empty;
            GameDate = DateTime.Now;
            OfficialDate = string.Empty;
            Status = new GameStatus();
            Teams = new TeamsType();
            Venue = new Venue();
            Content =  new Content();
            IsTie = false;
            GameNumber = 0;
            PublicFacing =  false;
            DoubleHeader = string.Empty;
            GamedayType = string.Empty;
            Tiebreaker = string.Empty;
            CalendarEventID = string.Empty;
            SeasonDisplay = string.Empty;
            DayNight = string.Empty;
            ScheduledInnings = 0;
            ReverseHomeAwayStatus = false;
            InningBreakLength = 0;
            GamesInSeries = 0;
            SeriesGameNumber = 0;
            SeriesDescription = string.Empty;
            RecordSource = string.Empty;
            IfNecessary = string.Empty;
            IfNecessaryDescription = string.Empty;
        }

        [JsonPropertyName("gamePk")]
        public int GamePk { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("gameType")]
        public string GameType { get; set; }

        [JsonPropertyName("season")]
        public string Season { get; set; }

        [JsonPropertyName("gameDate")]
        public DateTime GameDate { get; set; }

        [JsonPropertyName("officialDate")]
        public string OfficialDate { get; set; }

        [JsonPropertyName("status")]
        public GameStatus Status { get; set; }

        [JsonPropertyName("teams")]
        public TeamsType Teams { get; set; }

        [JsonPropertyName("venue")]
        public Venue Venue { get; set; }

        [JsonPropertyName("content")]
        public Content Content { get; set; }

        [JsonPropertyName("isTie")]
        public bool IsTie { get; set; }

        [JsonPropertyName("gameNumber")]
        public int GameNumber { get; set; }

        [JsonPropertyName("publicFacing")]
        public bool PublicFacing { get; set; }

        [JsonPropertyName("doubleHeader")]
        public string DoubleHeader { get; set; }

        [JsonPropertyName("gamedayType")]
        public string GamedayType { get; set; }

        [JsonPropertyName("tiebreaker")]
        public string Tiebreaker { get; set; }

        [JsonPropertyName("calendarEventID")]
        public string CalendarEventID { get; set; }

        [JsonPropertyName("seasonDisplay")]
        public string SeasonDisplay { get; set; }

        [JsonPropertyName("dayNight")]
        public string DayNight { get; set; }

        [JsonPropertyName("scheduledInnings")]
        public int ScheduledInnings { get; set; }

        [JsonPropertyName("reverseHomeAwayStatus")]
        public bool ReverseHomeAwayStatus { get; set; }

        [JsonPropertyName("inningBreakLength")]
        public int InningBreakLength { get; set; }

        [JsonPropertyName("gamesInSeries")]
        public int GamesInSeries { get; set; }

        [JsonPropertyName("seriesGameNumber")]
        public int SeriesGameNumber { get; set; }

        [JsonPropertyName("seriesDescription")]
        public string SeriesDescription { get; set; }

        [JsonPropertyName("recordSource")]
        public string RecordSource { get; set; }

        [JsonPropertyName("ifNecessary")]
        public string IfNecessary { get; set; }

        [JsonPropertyName("ifNecessaryDescription")]
        public string IfNecessaryDescription { get; set; }
    }
}
