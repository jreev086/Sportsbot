using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using Sportsbot.Services;

namespace Sportsbot
{
    public class ScoreDiscordBot
    {
        private readonly DiscordShardedClient client;
        private readonly string token;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        public ScoreDiscordBot(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                throw new ArgumentNullException(nameof(token));
            }

            this.token = token;

            var commands = new CommandService(new CommandServiceConfig
            {
                // Again, log level:
                LogLevel = LogSeverity.Info,

                // There's a few more properties you can set,
                // for example, case-insensitive commands.
                CaseSensitiveCommands = false,

                SeparatorChar = ' '
            });

            client = new DiscordShardedClient(new DiscordSocketConfig
            {
                GatewayIntents = GatewayIntents.All
            });

            Injector.Init();
            Injector.RegisterInstance(client);
            Injector.RegisterInstance(commands);
            Injector.RegisterType<ICommandHandlerService, CommandHandlerService>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task MainAsync()
        {
            await Injector.ServiceProvider.GetRequiredService<ICommandHandlerService>().InitializeAsync();

            client.ShardReady += async shard =>
            {
                await Logger.Log(LogSeverity.Info, "ShardReady", $"Shard Number {shard.ShardId} is connected and ready!");
            };   

            if (string.IsNullOrWhiteSpace(token))
            {
                await Logger.Log(LogSeverity.Error, $"{nameof(ScoreDiscordBot)} | {nameof(MainAsync)}", "Token is null or empty.");
                return;
            }

            // Replace 'YOUR_BOT_TOKEN' with your actual bot token
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            // Wait indefinitely, or use a CancellationToken to gracefully exit
            await Task.Delay(-1);
        }
    }
}
