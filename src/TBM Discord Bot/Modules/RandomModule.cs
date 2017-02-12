using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TBM_Discord_Bot.Modules
{
    public class RandomModule : ModuleBase
    {
        [Command("random"), Summary("Displays a random number between 1 and 100.")]
        async Task Random()
        {
            Random rng = new Random();
            int random = rng.Next(0, 101);
            await ReplyAsync($"Random number between 1 and 100: {random}");
        }
    }
}
