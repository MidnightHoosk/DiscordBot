using Discord.WebSocket;
using System.Threading.Tasks;

namespace TBM_Discord_Bot
{
    public interface IDiscordBot
    {
        Task Start();
    }
}
