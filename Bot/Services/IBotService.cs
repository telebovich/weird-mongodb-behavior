using Telegram.Bot;

namespace Telebovich.Bot.Services
{
    public interface IBotService
    {
        TelegramBotClient Client { get; }
    }
}