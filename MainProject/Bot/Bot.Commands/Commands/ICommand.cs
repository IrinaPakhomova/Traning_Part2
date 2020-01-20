using Common;

namespace Bot.Commands.Commands
{
    public interface ICommand
    {
        string Name { get; }

        bool IsThisComand(string text);

        Answer OnMessage();
    }
}
