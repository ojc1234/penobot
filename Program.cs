using System;

namespace penodiscordbot
{
    class Program
    {
        static void Main(string[] args)
        {
            int setting = 0;
            if (setting == 0)
            {
                var disbot = new bot();
                new bot().MainAsync().GetAwaiter().GetResult();
            }
            if (setting == 1)
            {
                request.htmlParser(request.ahaUrl("hello"));
            }
            if (setting == 2)
            {
                Console.WriteLine((new token()).discordtoken);
            }
        }
    }

}