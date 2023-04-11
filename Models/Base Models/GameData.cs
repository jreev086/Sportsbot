namespace Sportsbot.Base_Models
{
    public class GameData
    {
        public GameData()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string? AwayTeam { get; set; }
        public string? HomeTeam { get; set; }
        public int? AwayScore { get; set; }
        public int? HomeScore { get; set; }
        public int? AwayTeamId { get; internal set; }
        public int? HomeTeamId { get; internal set; }
    }
}
