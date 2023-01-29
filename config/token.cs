using System.IO;

namespace penodiscordbot.config
{
    internal class token
    {
        public string discordtoken;
        public token()
        {
            string FileRoute = @"C:\Users\¿ÀÁö¿ë\Desktop\token.txt";
            string FileBuffer;
            string text;
            try
            {
                FileBuffer = File.ReadAllText(FileRoute);
                text = FileBuffer == "\n" ? "01" : FileBuffer;
            }
            catch
            {
                text = "000";
            }
            this.discordtoken = text;
        }

    }
}