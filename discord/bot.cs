﻿using Discord;
using Discord.WebSocket;
using System;
using System.Linq;
using System.Threading.Tasks;
using penodiscordbot.config;
namespace penodiscordbot.discord
{
    internal class bot
    {
        private readonly DiscordSocketClient _client;

        public bot()
        {
            var config = new DiscordSocketConfig()
            {
                GatewayIntents = GatewayIntents.All
            };
            _client = new DiscordSocketClient(config);

            _client.Log += Log;
            _client.Ready += Ready;
            _client.MessageReceived += new botMessage(_client).MessageReceivedAsync;
        }

        public async Task MainAsync()
        {
            await _client.LoginAsync(TokenType.Bot, new token().discordtoken);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage log)
        {
            Console.WriteLine(log.ToString());

            return Task.CompletedTask;
        }

        private Task Ready()
        {
            Console.WriteLine($"{_client.CurrentUser} 연결됨!");
            return Task.CompletedTask;
        }


    }
}
