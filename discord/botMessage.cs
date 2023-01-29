using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using penodiscordbot.matrix;
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
            if (message.Content.FirstOrDefault().ToString() == ".")
            {
                string realMessage = message.Content.Remove(0,1);
                List<int> inputs = realMessage.Split(' ').ToList().ConvertAll((i)=>int.Parse(i));
                if (inputs.Count == 4) Console.WriteLine("List size ok");
                var mat = new Matrix(new List<int> { inputs[0], inputs[1] }, new List<int> { inputs[2], inputs[3] });
                await message.Channel.SendMessageAsync(embed: new discordEmbed()?.matrixEmbed(mat)?.Build());
            }
        }
    }
}
