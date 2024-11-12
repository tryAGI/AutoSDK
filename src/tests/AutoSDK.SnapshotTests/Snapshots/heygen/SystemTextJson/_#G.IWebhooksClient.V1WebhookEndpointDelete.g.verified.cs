//HintName: G.IWebhooksClient.V1WebhookEndpointDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// v1/webhook/endpoint.delete<br/>
        /// v1/webhook/endpoint.delete
        /// </summary>
        /// <param name="endpointId">
        /// Example: &lt;endpoint_id&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1WebhookEndpointDeleteAsync(
            string? endpointId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}