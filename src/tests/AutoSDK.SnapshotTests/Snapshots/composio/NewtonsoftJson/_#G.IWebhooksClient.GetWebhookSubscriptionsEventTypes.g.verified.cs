//HintName: G.IWebhooksClient.GetWebhookSubscriptionsEventTypes.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// List available event types<br/>
        /// Returns all event types that can be subscribed to, along with their supported webhook versions.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetWebhookSubscriptionsEventTypesResponse> GetWebhookSubscriptionsEventTypesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}