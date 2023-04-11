using Discord;
using Discord.Commands;
using System.Text;

namespace Sportsbot.Modules
{
    public class CommandModule : ModuleBase<ShardedCommandContext>
    {
        public CommandService? CommandService { get; set; }

        [Command("baseball", RunMode = RunMode.Async)]
        public async Task BaseballScores()
        {
            var result = BuildBaseballGameData();

            await Context.Message.ReplyAsync("", false, EmbedBaseballScore(result).Build());
        }

        private List<Base_Models.GameData> BuildBaseballGameData()
        {
            var requestor = new APIRequestor();

            var gameResults = requestor.GetGameDataAsync("http://statsapi.mlb.com/api/v1/schedule/games/?sportId=1")
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

            var games = new List<Base_Models.GameData>();

            foreach (var gameDate in gameResults.Dates)
            {
                foreach (var game in gameDate.Games.Where(x => x.Status.DetailedState.Equals("Final", StringComparison.InvariantCultureIgnoreCase)))
                {
                    var awayTeamResult = requestor.GetTeamDataAsync(string.Format("https://statsapi.mlb.com/api/v1/teams/{0}", game.Teams.Away.Team.Id))
                        .ConfigureAwait(false)
                        .GetAwaiter()
                        .GetResult();

                    var homeTeamResult = requestor.GetTeamDataAsync(string.Format("https://statsapi.mlb.com/api/v1/teams/{0}", game.Teams.Home.Team.Id))
                        .ConfigureAwait(false)
                        .GetAwaiter()
                        .GetResult();

                    games.Add(new Base_Models.GameData
                    {
                        AwayTeamId = game.Teams.Away.Team.Id,
                        HomeTeamId = game.Teams.Home.Team.Id,
                        AwayTeam = awayTeamResult.Teams[0].Abbreviation,
                        HomeTeam = homeTeamResult.Teams[0].Abbreviation,
                        AwayScore = game.Teams.Away.Score,
                        HomeScore = game.Teams.Home.Score
                    });
                }
            }

            return games;
        }

        private EmbedBuilder EmbedBaseballScore(List<Base_Models.GameData> games)
        {
            var embed = new EmbedBuilder
            {
                // Embed property can be set within object initializer
                Title = "Baseball scores",
                Description = "These are the final scores of todays games.",
                Color = Color.Blue,
                Timestamp = DateTime.Now
            };

            var builder = new StringBuilder();

            builder.AppendLine("-------------------------");

            foreach (var game in games)
            {
                builder.Append($"{game.AwayTeam} : ").AppendLine($"{game.AwayScore}");
                builder.Append($"{game.HomeTeam} : ").AppendLine($"{game.HomeScore}");
                builder.AppendLine("-------------------------");
            }

            embed.AddField("<Team> : <Runs>", builder.ToString());

            return embed;
        }
    }
}
