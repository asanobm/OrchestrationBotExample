using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

namespace OrchestrationBotExample.Middleware
{
    public class SetLocaleMiddleware: IMiddleware
    {
        private readonly string DefaultLocale;

        public SetLocaleMiddleware(string defaultLocale)
        {
            DefaultLocale = defaultLocale;
        }

        public async Task OnTurnAsync(
            ITurnContext turnContext,
            NextDelegate next,
            CancellationToken cancellationToken = new CancellationToken())
        {
            var cultureInfo = string.IsNullOrEmpty(turnContext.Activity.Locale) ?
                new CultureInfo(DefaultLocale) :
                new CultureInfo(turnContext.Activity.Locale);
            
            CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture = cultureInfo;

            
            await next(cancellationToken).ConfigureAwait(false); 
        }
    }
}