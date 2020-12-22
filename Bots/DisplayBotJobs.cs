using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace OrchestrationBotExample.Bots
{
    /// <summary>
    /// This EchobBot partial class.
    /// </summary>
    public partial class EchoBot
    {
        private static async Task DisplayBotJobs(
            ITurnContext turnContext,
            CancellationToken cancellationToken)
        {
            await turnContext.SendActivityAsync(
                MessageFactory.Attachment(
                    new HeroCard
                    {
                        Text = "Title",
                        Buttons = new List<CardAction>
                        {
                            new(
                                ActionTypes.ImBack,
                                "Inline Attachment",
                                value: "upload attachment"
                            ),
                            new(
                                ActionTypes.ImBack,
                                "Inline Attachment",
                                value: "upload attachment"
                            ),
                            new(
                                ActionTypes.ImBack,
                                "Inline Attachment",
                                value: "upload attachment"
                            ),
                            new(
                                ActionTypes.ImBack,
                                "Inline Attachment",
                                value: "upload attachment"
                            ),
                        }
                    }.ToAttachment()
                )
                , cancellationToken);
        }
    }
}