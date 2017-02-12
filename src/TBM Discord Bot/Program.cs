using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using TBM_Discord_Bot.Interfaces;

namespace TBM_Discord_Bot
{
    public class Program
    {
        public static void Main(string[] args) => new Program().Start().GetAwaiter().GetResult();

        public async Task Start()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDiscordBot, DiscordBot>()
                .BuildServiceProvider();

            var bot = serviceProvider.GetService<IDiscordBot>();
           
            await bot.Start();

            await Task.Delay(-1);
        }
    }
}
