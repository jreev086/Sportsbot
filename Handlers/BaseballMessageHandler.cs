using Discord;
using Sportsbot.Models.Base_Models;
using System.Text;
using Sportsbot.Models.API_Models.MLB;

namespace Sportsbot.Handlers
{
    public class BaseballMessageHandler
    {
        public EmbedBuilder GetEmbedMessage()
        {
            var data = BuildBaseballGameData();

            return EmbedBaseballScore(data);
        }

        private List<GameData> BuildBaseballGameData()
        {
            var gameResults = GetGameDataAsync("http://statsapi.mlb.com/api/v1/schedule/games/?sportId=1")
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

            var games = new List<GameData>();

            if (gameResults is not null && gameResults.Dates is not null)
            {
                foreach (var gameDate in gameResults.Dates)
                {
                    if (gameDate is not null && gameDate.Games is not null)
                    {
                        foreach (var game in gameDate.Games.Where(x => x.Status.DetailedState.Equals("Final", StringComparison.InvariantCultureIgnoreCase)))
                        {
                            var awayTeamResult = GetTeamDataAsync(string.Format("https://statsapi.mlb.com/api/v1/teams/{0}", game.Teams.Away.Team.Id))
                                .ConfigureAwait(false)
                                .GetAwaiter()
                                .GetResult();

                            var homeTeamResult = GetTeamDataAsync(string.Format("https://statsapi.mlb.com/api/v1/teams/{0}", game.Teams.Home.Team.Id))
                                .ConfigureAwait(false)
                                .GetAwaiter()
                                .GetResult();

                            games.Add(new GameData
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
                }
            }

            return games;
        }

        private EmbedBuilder EmbedBaseballScore(List<GameData> games)
        {
            var embed = new EmbedBuilder
            {
                // Embed property can be set within object initializer
                Title = "MLB scores",
                Description = "These are the final scores of todays games.",
                Color = Color.Blue,
                Timestamp = DateTime.Now
            };

            if (games is null || games.Count <= 0)
            {
                embed.AddField("There are no games to display.", string.Empty);

                return embed;
            }

            var builder = new StringBuilder();

            builder.AppendLine("-------------------------");

            foreach (var game in games)
            {
                if (game != null)
                {
                    builder.Append($"{(game.AwayTeam.Length < 3 ? game.AwayTeam.Append(' ') : game.AwayTeam)} : ").AppendLine($"{game.AwayScore}");
                    builder.Append($"{(game.HomeTeam.Length < 3 ? game.HomeTeam.Append(' ') : game.HomeTeam)} : ").AppendLine($"{game.HomeScore}");
                    builder.AppendLine("-------------------------");
                }
            }

            embed.AddField("<Team> : <Runs>", builder.ToString());

            return embed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        private async Task<GameRoot?> GetGameDataAsync(string uri)
        {
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsAsync<GameRoot>();

                return responseContent;
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        private async Task<TeamRoot?> GetTeamDataAsync(string uri)
        {
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsAsync<TeamRoot>();

                return responseContent;
            }

            return null;
        }
    }
}
