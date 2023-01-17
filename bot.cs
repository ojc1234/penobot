using Discord.WebSocket;
using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;

namespace penodiscordbot
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
			_client.MessageReceived += MessageReceivedAsync;
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

		private async Task MessageReceivedAsync(SocketMessage message)
		{
			if (message.Author.Id == _client.CurrentUser.Id)
				return;

			if (message.Content.FirstOrDefault().ToString() == "!")
				await message.Channel.SendMessageAsync(request.htmlParserBoldString($@"http://aha-dic.com/View.asp?word={message.Content.Substring(1)}")?.discordString()??"Not found");
		}
	}
}
