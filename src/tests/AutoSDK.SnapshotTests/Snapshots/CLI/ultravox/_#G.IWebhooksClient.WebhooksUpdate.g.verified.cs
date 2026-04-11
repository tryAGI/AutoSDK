//HintName: G.IWebhooksClient.WebhooksUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Webhook> WebhooksUpdateAsync(
            global::System.Guid webhookId,

            global::G.Webhook request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="url"></param>
        /// <param name="secrets"></param>
        /// <param name="events"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Webhook> WebhooksUpdateAsync(
            global::System.Guid webhookId,
            string url,
            global::System.Collections.Generic.IList<global::G.EventsEnum> events,
            global::System.Collections.Generic.IList<string>? secrets = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}