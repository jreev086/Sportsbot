using Microsoft.Extensions.Configuration;
using Sportsbot;

var config = new ConfigurationBuilder()
    .AddJsonFile($"appsettings.json")
    .Build();

var bot = new ScoreDiscordBot(config?.GetRequiredSection("DiscordToken")?.Value ?? string.Empty);
await bot.MainAsync();