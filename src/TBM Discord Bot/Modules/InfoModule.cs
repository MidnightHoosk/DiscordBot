using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TBM_Discord_Bot.Modules
{
    public class InfoModule : ModuleBase
    {
        private readonly IDependencyMap _map;

        public InfoModule(IDependencyMap map)
        {
            _map = map;
        }

        [Command("help"), Summary("Shows help menu.")]
        async Task Help()
        {
            foreach(var command in _map.Get<CommandService>().Commands)
            {
                await ReplyAsync(command.Name);
            }
        }
    }
}
