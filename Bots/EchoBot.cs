// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with EchoBot .NET Template version v4.11.1

using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Microsoft.Extensions.Localization;

namespace OrchestrationBotExample.Bots
{
    public partial class EchoBot : ActivityHandler
    {
        private IStringLocalizer<EchoBot> Localizer;
        public EchoBot(
            IStringLocalizer<EchoBot> localizer)
        {
            Localizer = localizer;
        }
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(turnContext.Activity.Locale);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(turnContext.Activity.Locale);
         
            var replyText = $"Echo: {turnContext.Activity.Text}, {Localizer.GetString("Welcome")}, {turnContext.Activity.Locale}";
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }
    }
}
