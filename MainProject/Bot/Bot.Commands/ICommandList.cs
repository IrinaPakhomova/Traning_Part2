using Bot.Commands.Commands;
using System.Collections.Generic;

namespace Bot.Commands
{
    public interface ICommandList
    {
        ICommand GetCommand(string text);

        List<ICommand> GetListOfCommands();
    }
}
