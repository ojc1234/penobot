using Discord;
using System.Collections.Generic;

namespace penodiscordbot
{
    internal class discordEmbed
    {
        public EmbedBuilder dictEmbed(Dict dict)
        {
            var eb = new EmbedBuilder { Title = dict.englishWord, Description = dict.phenomenon?.discordString() };
            eb.AddField("뜻",dict.mean);
            eb.AddField("출처", request.ahaUrl(dict.englishWord));
            return eb;
        }
    }
}
