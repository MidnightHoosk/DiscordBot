using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;
using TBM_Discord_Bot.Interfaces;

namespace TBM_Discord_Bot
{
    public class DiscordBot : IDiscordBot
    {
        private DiscordSocketClient client;
        private DependencyMap map;

        public async Task Start()
        {
            client = new DiscordSocketClient();
            map = new DependencyMap();

            map.Add(client);
            map.Add<ICommands>(new Commands(map));

            string token = Environment.GetEnvironmentVariable("token");

            await map.Get<ICommands>().Install();

            await client.LoginAsync(TokenType.Bot, token);
            await client.ConnectAsync();
            
        }
    }
}
