using Bot.Commands;
using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace Bot.TelegramBot
{
    public class CustomBot
    {
        TelegramBotClient bot;

        ICommandList commands;

        public CustomBot()
        {
            bot = new TelegramBotClient("1041441332:AAHUjAvx8q15W9yuwRyaFxhzHHsp5z3DfQY");

            commands = new CommandList();

            bot.OnMessage += OnMessage;
        }

        private async void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;

            var command = commands.GetCommand(message.Text);

            await MessageSender.SendMessage(command, message, bot);
        }

        public void Start()
        {
            bot.StartReceiving();
        }

        public void Stop()
        {
            bot.StartReceiving();
        }
    }
}
