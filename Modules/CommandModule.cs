using Discord;
using Discord.Commands;
using Sportsbot.Handlers;

namespace Sportsbot.Modules
{
    public class CommandModule : ModuleBase<ShardedCommandContext>
    {
        public CommandService? CommandService { get; set; }

        [Command("mlb", RunMode = RunMode.Async)]
        public async Task MLBCommand(string arguments)
        {
            await Logger.Log(LogSeverity.Info, $"{nameof(CommandModule)}", $"Detected <mlb> command....running {nameof(MLBCommand)}");
            var messageHandler = new BaseballMessageHandler();

            EmbedBuilder result = new();

            switch(arguments)
            {
                case "final":
                case "end":
                    result = messageHandler.EmbedBaseballFinalScore();
                    break;
                case "InProgress":
                case "IP":
                case "progress":
                    result = messageHandler.EmbedGamesInProgress();
                    break;
                case "standing":
                    result = messageHandler.EmbedStandings();
                    break;
                default:
                    result = messageHandler.EmbedBaseballFinalScore();
                    break;
            }

            await Context.Channel.SendMessageAsync("", false, result.Build());
            await Context.Channel.DeleteMessageAsync(Context.Message.Id);
        }

        [Command("mlb", RunMode = RunMode.Async)]
        public async Task MLBCommand()
        {
            await Logger.Log(LogSeverity.Info, $"{nameof(CommandModule)}", $"Detected <mlb> command....running {nameof(MLBCommand)}");
            var messageHandler = new BaseballMessageHandler();

            var result = messageHandler.EmbedBaseballFinalScore();

            await Context.Channel.SendMessageAsync("", false, result.Build());
            await Context.Channel.DeleteMessageAsync(Context.Message.Id);
        }
    }
}
