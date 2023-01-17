namespace penodiscordbot
{
    class Program
    {
        static void Main(string[] args)
        {
            var disbot = new bot();
            new bot().MainAsync().GetAwaiter().GetResult();
            //request.htmlParser(request.ahaUrl("hello"));
        }
    }

}