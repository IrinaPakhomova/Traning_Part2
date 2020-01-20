using Bot.Commands;
using System;


namespace UI
{
    class ConsoleBotEx
    {
        private CustomBot customBot = new CustomBot();
        public void Start()
        {
            Console.WriteLine("Bot start work");
        }

        public void End()
        {
            Console.WriteLine("Bot stop work");
        }

        public void GetListOfCommands()
        {
           /* foreach (var item in customBot.GetListOfCommands())
            {
                Console.WriteLine(item.Name);
            }*/
        }
    }
}
