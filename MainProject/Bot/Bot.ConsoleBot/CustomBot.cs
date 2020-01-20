using Bot.Commands;
using Bot.Commands.Commands;
using System.Collections.Generic;

namespace Bot.Commands
{
    public class CustomBot
    {
        ICommandList commands;

        public CustomBot()
        {
            commands = new CommandList();
        }

        public List<ICommand> GetListOfCommands()
        {
            return commands.GetListOfCommands();
        }
    }
}

