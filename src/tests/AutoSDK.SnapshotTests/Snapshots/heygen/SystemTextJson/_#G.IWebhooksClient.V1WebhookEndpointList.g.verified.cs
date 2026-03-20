//HintName: G.IWebhooksClient.V1WebhookEndpointList.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// v1/webhook/endpoint.list<br/>
        /// v1/webhook/endpoint.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1WebhookEndpointListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}