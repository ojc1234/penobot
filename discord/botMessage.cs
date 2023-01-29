using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penodiscordbot.discord
{
    internal class botMessage
    {
        private DiscordSocketClient _client;
        public botMessage(DiscordSocketClient client) 
        {
            _client= client;
        }
        public async Task MessageReceivedAsync(SocketMessage message)
        {
            if (message.Author.Id == _client.CurrentUser.Id)
                return;

            if (message.Content.FirstOrDefault().ToString() == "!")
            {
                var diction = request.Diction(message.Content.Substring(1));

                if (diction.phenomenon?.discordString() == null)
                {
                    await message.Channel.SendMessageAsync("Not found");
                }
                else
                {
                    await message.Channel.SendMessageAsync(embed: new discordEmbed()?.dictEmbed(diction)?.Build());
                }
            }
        }
    }
}
