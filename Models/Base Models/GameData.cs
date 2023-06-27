namespace Sportsbot.Models.Base_Models
{
    internal class GameData
    {
        internal GameData()
        {
            Id = Guid.NewGuid();
            AwayTeam = string.Empty;
            HomeTeam = string.Empty;
        }

        public Guid Id { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeam { get; set; }
        public int AwayScore { get; set; }
        public int HomeScore { get; set; }
        public int AwayTeamId { get; set; }
        public int HomeTeamId { get; set; }
    }
}
