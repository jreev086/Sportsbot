using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sportsbot.Services;

namespace Sportsbot
{
    public class ScoreDiscordBot
    {
        private DiscordShardedClient? client;
        private string lastRequested;
        private readonly string token;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        public ScoreDiscordBot(IConfigurationRoot config)
        {
            this.token = config.GetRequiredSection("DiscordToken").Value;
            lastRequested = string.Empty;

            var commands = new CommandService(new CommandServiceConfig
            {
                // Again, log level:
                LogLevel = LogSeverity.Info,

                // There's a few more properties you can set,
                // for example, case-insensitive commands.
                CaseSensitiveCommands = false,
            });

            client = new DiscordShardedClient(new DiscordSocketConfig
            {
                GatewayIntents = GatewayIntents.All
            });

            Injector.Init();
            Injector.RegisterInstance(client);
            Injector.RegisterInstance(commands);
            Injector.RegisterType<ICommandHandlerService, CommandHandlerService>();
            Injector.RegisterInstance(config);
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
