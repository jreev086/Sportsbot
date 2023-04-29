using Discord;
using Discord.Commands;
using Sportsbot.Handlers;

namespace Sportsbot.Modules
{
    public class CommandModule : ModuleBase<ShardedCommandContext>
    {
        public CommandService? CommandService { get; set; }

        [Command("mlb", RunMode = RunMode.Async)]
        public async Task BaseballScores()
        {
            await Logger.Log(LogSeverity.Info, $"{nameof(CommandModule)}", $"Detected <mlb> command....running {nameof(BaseballScores)}");
            var messageHandler = new BaseballMessageHandler();

            var result = messageHandler.GetEmbedMessage();

            await Context.Channel.SendMessageAsync("", false, result.Build());
            await Context.Channel.DeleteMessageAsync(Context.Message.Id);
        }
    }
}
