//HintName: G.IWebhooksClient.V1WebhookEndpointAdd.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// v1/webhook/endpoint.add<br/>
        /// v1/webhook/endpoint.add
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1WebhookEndpointAddAsync(

            global::G.V1WebhookEndpointAddRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// v1/webhook/endpoint.add<br/>
        /// v1/webhook/endpoint.add
        /// </summary>
        /// <param name="events">
        /// Example: []
        /// </param>
        /// <param name="url">
        /// Example: &lt;url&gt;
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1WebhookEndpointAddAsync(
            global::System.Collections.Generic.IList<object>? events = default,
            string? url = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}