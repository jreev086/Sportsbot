using Discord;
using Sportsbot.Models.API_Models.MLB;
using Sportsbot.Models.Base_Models;
using System.Text;

namespace Sportsbot.Handlers
{
    public class BaseballMessageHandler
    {
        private readonly GameRoot gameResults;
        private readonly TeamRoot teams;

        /// <summary>
        /// 
        /// </summary>
        public BaseballMessageHandler()
        {
            gameResults = GetGameDataAsync("http://statsapi.mlb.com/api/v1/schedule/games/?sportId=1")
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

            teams = GetTeamDataAsync("https://statsapi.mlb.com/api/v1/teams?sportId=1")
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public EmbedBuilder EmbedStandings()
        {
            throw new NotImplementedException("Not functional yet");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public EmbedBuilder EmbedGamesInProgress()
        {
            throw new NotImplementedException("Not functional yet");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public EmbedBuilder EmbedBaseballFinalScore()
        {
            var games = new List<GameData>();

            if (gameResults is not null && gameResults.Dates is not null)
            {
                foreach (var gameDate in gameResults.Dates)
                {
                    if (gameDate is not null && gameDate.Games is not null)
                    {
                        foreach (var game in gameDate.Games)
                        {
                            if (game.Status is not null && game.Status.DetailedState is not null && game.Status.DetailedState.Equals("final", StringComparison.InvariantCultureIgnoreCase))
                            {
                                games.Add(new GameData
                                {
                                    AwayTeamId = game?.Teams?.Away?.Team?.Id ?? 0,
                                    HomeTeamId = game?.Teams?.Home?.Team?.Id ?? 0,
                                    AwayTeam = teams?.Teams?.FirstOrDefault(x => x.Id == game?.Teams?.Away?.Team?.Id)?.Abbreviation ?? string.Empty,
                                    HomeTeam = teams?.Teams?.FirstOrDefault(x => x.Id == game?.Teams?.Home?.Team?.Id)?.Abbreviation ?? string.Empty,
                                    AwayScore = game?.Teams?.Away?.Score ?? 0,
                                    HomeScore = game?.Teams?.Home?.Score ?? 0
                                });
                            }
                        }
                    }
                }
            }

            if (games is null || games.Count <= 0)
            {
                return new EmbedBuilder
                {
                    // Embed property can be set within object initializer
                    Title = "MLB scores",
                    Description = "There are no games to display.",
                    Color = Color.Blue,
                    Timestamp = DateTime.Now
                };
            }

            var embed = new EmbedBuilder
            {
                // Embed property can be set within object initializer
                Title = "MLB scores",
                Description = "These are the final scores of todays games.",
                Color = Color.Blue,
                Timestamp = DateTime.Now
            };

            var builder = new StringBuilder();

            builder.AppendLine("-------------------------");

            foreach (var game in games)
            {
                if (game != null)
                {
                    builder.Append($"{(game.AwayTeam.Length < 3 ? string.Format("{0} ", game.AwayTeam) : game.AwayTeam)} : ").AppendLine($"{game.AwayScore}");
                    builder.Append($"{(game.HomeTeam.Length < 3 ? string.Format("{0} ", game.HomeTeam) : game.HomeTeam)} : ").AppendLine($"{game.HomeScore}");
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
        private static async Task<GameRoot> GetGameDataAsync(string uri)
        {
            try
            {
                var client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsAsync<GameRoot>();

                    return responseContent;
                }
            }
            catch (Exception ex)
            {
                await Logger.Log(LogSeverity.Error, "GetGameDataAsync()", "Unhandled Exception", ex);
            }

            return new GameRoot();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        private static async Task<TeamRoot> GetTeamDataAsync(string uri)
        {
            try
            {
                var client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsAsync<TeamRoot>();

                    return responseContent;
                }
            }
            catch (Exception ex)
            {
                await Logger.Log(LogSeverity.Error, "GetTeamDataAsync()", "Unhandled Exception", ex);
            }

            return new TeamRoot();
        }
    }
}
