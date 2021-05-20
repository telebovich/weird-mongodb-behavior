using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace Telebovich.Bot.Services
{
    public interface IUpdateService
    {
        Task EchoAsync(Update update);
    }
}