//HintName: G.IAlertsClient.GetWebhookExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IAlertsClient
    {
        /// <summary>
        /// Get webhook payload examples<br/>
        /// Get webhook payload examples for all alert event types, optionally filtered by alert type
        /// </summary>
        /// <param name="alertType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebhookExamples> GetWebhookExamplesAsync(
            global::G.GetWebhookExamplesAlertType? alertType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}