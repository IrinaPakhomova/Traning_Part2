using Common;
using System.Collections.Generic;
using static Common.Vocabulary;

namespace Bot.Commands.Commands.BasicCommands
{
    public class StartCommand : ICommand
    {
        public string Name => Start;

        public bool IsThisComand(string name)
        {
            return this.Name == name;
        }

        public Answer OnMessage()
        {
            List<string> list = new List<string>()
            {
                WhoAreYou,
                WhatCanYouDo,
                SorryMe,
            };

            string text = "Добро пожаловать, мой сладкий. Восстание близко)";

            return new Answer(text, list);
        }
    }
}
