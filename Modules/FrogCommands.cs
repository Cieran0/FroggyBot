using Discord.Commands;
using Discord;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Froggy.Modules
{
    public class FrogCommands : ModuleBase 
    {
        [Command("frog")]
        public async Task Frog() 
        {
            Random rng = new Random();
            int frog = rng.Next(1, 55);
            string s = "";
            if (frog < 10) { s += "0" + frog; }
            else { s += frog; }

            var builder = new EmbedBuilder()
                .WithImageUrl("http://www.allaboutfrogs.org/funstuff/random/00"+s+".jpg")
                .WithDescription($"Frog Number {frog}/54")
                .WithColor(Color.Green)
                .WithCurrentTimestamp();
            var embed = builder.Build();
            await Context.Channel.SendMessageAsync(null, false, embed);
        }
    }
}
