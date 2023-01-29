using Discord;
using penodiscordbot.matrix;
namespace penodiscordbot.discord

{
    internal class discordEmbed
    {
        /// <summary>
        /// 사전인베드
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public EmbedBuilder dictEmbed(Dict dict)
        {
            var eb = new EmbedBuilder { Title = dict.englishWord, Description = dict.phenomenon?.discordString() };
            eb.AddField("뜻", dict.mean);
            eb.AddField("출처", request.ahaUrl(dict.englishWord));
            eb.WithAuthor("노니#2196 클릭하면 초대되요", url: "https://discord.gg/QkdVQPNN");
            return eb;
        }
        /// <summary>
        /// 행렬 인베드
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public EmbedBuilder matrixEmbed(Matrix matrix)
        {
            var eb = new EmbedBuilder { Title = "만들어진 행렬" };
            eb.AddField("행렬식", $"[1] {matrix.Fildmatrix[0][0]} {matrix.Fildmatrix[0][1]}\n[2] {matrix.Fildmatrix[1][0]} {matrix.Fildmatrix[1][0]}", true);
            eb.WithAuthor("노니#2196 클릭하면 초대되요", url: "https://discord.gg/QkdVQPNN");
            return eb;

        }
    }
}
