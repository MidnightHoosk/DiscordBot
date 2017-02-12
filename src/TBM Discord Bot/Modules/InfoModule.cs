using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            StringBuilder help = new StringBuilder();

            EmbedBuilder builder = new EmbedBuilder();
            builder.Title = "Commands";
            builder.WithColor(new Color(51, 153, 255));

            foreach(var command in _map.Get<CommandService>().Commands)
            {
                if (command.Name != "test")
                    help.Append($"!{command.Name} -- Summary: {command.Summary}\n");
            }
            builder.WithDescription(help.ToString());
            await ReplyAsync("", embed: builder);
        }
    }
}
