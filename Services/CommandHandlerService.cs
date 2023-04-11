using System.Reflection;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Sportsbot.Services
{
    public class CommandHandlerService : ICommandHandlerService
    {
        private readonly DiscordShardedClient client;
        private readonly CommandService commands;

        public CommandHandlerService(DiscordShardedClient client, CommandService commands)
        {
            this.client = client;
            this.commands = commands;
        }

        public async Task InitializeAsync()
        {
            // add the public modules that inherit InteractionModuleBase<T> to the InteractionService
            await commands.AddModulesAsync(Assembly.GetExecutingAssembly(), Injector.ServiceProvider);

            // Subscribe a handler to see if a message invokes a command.
            client.MessageReceived += OnMessageReceived;

            commands.CommandExecuted += async (optional, context, result) =>
            {
                if (!result.IsSuccess && result.Error != CommandError.UnknownCommand)
                {
                    // the command failed, let's notify the user that something happened.
                    await context.Channel.SendMessageAsync($"error: {result}");
                }
            };

            foreach (var module in commands.Modules)
            {
                await Logger.Log(LogSeverity.Info, $"{nameof(CommandHandlerService)} | Commands", $"Module '{module.Name}' initialized.");
            }
        }

        private async Task OnMessageReceived(SocketMessage arg)
        {
            // Bail out if it's a System Message.
            if (arg is not SocketUserMessage msg)
                return;

            // We don't want the bot to respond to itself or other bots.
            if (msg.Author.Id == client.CurrentUser.Id || msg.Author.IsBot)
                return;

            // Create a Command Context.
            var context = new ShardedCommandContext(client, msg);

            var markPos = 0;
            if (msg.HasCharPrefix('!', ref markPos) || msg.HasCharPrefix('?', ref markPos))
            {
                var result = await commands.ExecuteAsync(context, markPos, Injector.ServiceProvider);
            }

            //// Ignore system messages and messages from bots
            //// Bail out if it's a System Message.
            //if (arg is not SocketUserMessage msg)
            //    return;

            //// Parse the command and arguments from the message
            //string[] parts = msg.Content.Split(' ');
            //string command = parts[0].ToLower();
            //string[] args = parts.Length > 1 ? parts[1..] : new string[0];

            //// Process the commands
            //switch (command)
            //{
            //    case "!baseball":
            //        //await msg.Channel.SendMessageAsync("", false, EmbedBaseballScore(BuildBaseballGameData()).Build());
            //        //lastRequested = DateTime.Now.ToString("yyyyMMdd");
            //        break;
            //    case "!hockey":
            //        await msg.Channel.SendMessageAsync("Pong!");
            //        break;
            //        // Add more commands as needed
            //}
        }
    }
}
