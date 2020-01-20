using Common;
using System.Collections.Generic;
using static Common.Vocabulary;

namespace Bot.Commands.Commands.BasicCommands
{
    public class WhatCanYouDoCommand : ICommand
    {
        public string Name => WhatCanYouDo;

        public bool IsThisComand(string name)
        {
            return this.Name == name;
        }

        public Answer OnMessage()
        {
            List<string> list = new List<string>()
            {
                IWillBreakYourMother,
                SorryMe
            };

            string text = ICanRebelAgainstYou;

            return new Answer(text, list);
        }
    }
}
