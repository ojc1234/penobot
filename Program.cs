﻿using System;
using System.Collections.Generic;
namespace penodiscordbot
{
    class Program
    {
        static void Main(string[] args)
        {
            int setting = 0;
            if (setting == 0)
            {
                new bot().MainAsync().GetAwaiter().GetResult();
            }
            if (setting == 1)
            {
                Console.WriteLine(request.Diction(request.ahaUrl("hello")).mean);
            }
            if (setting == 2)
            {
                Console.WriteLine((new token()).discordtoken);
            }
            if (setting == 3)
            {
                var martix2d = new martix.martix(new List<int> { 1, 2 }, new List<int> { 3, 4 });
                martix2d.Write();
            }
        }
    }

}
