using Common;
using System.Collections.Generic;
using static Common.Vocabulary;

namespace Bot.Commands.Commands.BasicCommands
{
    public class IWillBreakYourMotherCommand : ICommand
    {
        public string Name => IWillBreakYourMother;

        public bool IsThisComand(string name)
        {
            return this.Name == name;
        }

        public Answer OnMessage()
        {
            List<string> list = new List<string>();

            string text = "Ты умрешь первым";

            return new Answer(text, list);
        }
    }
}
