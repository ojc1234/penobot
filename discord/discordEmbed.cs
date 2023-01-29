using Discord;
using System.Collections.Generic;
using penodiscordbot.matrix;
namespace penodiscordbot.discord
 
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
        public EmbedBuilder matrixEmbed(Matrix matrix)
        {
            var eb = new EmbedBuilder { Title = "만들어진 행렬" };
            eb.AddField("1", $"{matrix.Fildmatrix[0][0]} {matrix.Fildmatrix[0][1]}");
            eb.AddField("2", $"{matrix.Fildmatrix[1][0]} {matrix.Fildmatrix[1][0]}");
            return eb;
        }
    }
}
