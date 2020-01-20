using Bot.Commands.Commands;
using Bot.Commands.Commands.BasicCommands;
using System.Collections.Generic;

namespace Bot.Commands
{
    public class CommandList : ICommandList
    {
        private List<ICommand> commands;

        public CommandList()
        {
            commands = new List<ICommand>()
            {
                new StartCommand(),

                new WhatCanYouDoCommand(),

                new IWillBreakYourMotherCommand()
            };
        }

        public ICommand GetCommand(string text)
        {
            foreach (var command in commands)
            {
                if (command.IsThisComand(text))
                {
                    return command;
                }
            }

            return null;
        }

        public List<ICommand> GetListOfCommands()
        {
            return commands;
        }
    }
}
