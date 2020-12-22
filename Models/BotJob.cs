using Microsoft.Bot.Schema;

namespace EchoBot.Models
{
    public struct BotJob
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}