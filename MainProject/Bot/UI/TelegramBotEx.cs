using Bot.TelegramBot;

namespace UI
{
    public class TelegramBotEx
    {
        private CustomBot bot = new CustomBot();

        public void Start()
        {
            bot.Start();
        }

        public void Stop()
        {
            bot.Stop();
        }
    }
}
