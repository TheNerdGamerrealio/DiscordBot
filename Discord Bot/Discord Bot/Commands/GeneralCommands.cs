using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace Discord_Bot.Commands
{
    class GeneralCommands : BaseCommandModule
    {
        [Command("helloWorld")]
        public async Task HelloWorld(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Hello there!");
        }
    }
}
