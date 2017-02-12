using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace TBM_Discord_Bot.Interfaces
{
    public interface ICommands
    {
        Task Install();
        Task HandleCommand(SocketMessage messageParam);
    }
}
