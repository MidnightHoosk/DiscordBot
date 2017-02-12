using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TBM_Discord_Bot.Modules
{
    public class TestModule : ModuleBase
    {
        private readonly IDependencyMap _map;

        public TestModule(IDependencyMap map)
        {
            _map = map;
        }
        
        [Command("test"), Summary("Testing sub/unsubbing events")]
        async Task Test()
        {
            string testString = "Test String";
            _map.Get<DiscordSocketClient>().MessageReceived += TestModule_MessageReceived;
        }

        private Task TestModule_MessageReceived(SocketMessage args)
        {
            var mes = args as SocketUserMessage;
            Console.WriteLine(mes.Content);
            _map.Get<DiscordSocketClient>().MessageReceived -= TestModule_MessageReceived;
            return null;
        }
    }
}
