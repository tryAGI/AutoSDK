//HintName: G.IWebhooksClient.GetProjectWebhooks.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get Project Webhooks<br/>
        /// Retrieve all webhooks for a specific project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GetProjectWebhooksResponseItem>> GetProjectWebhooksAsync(
            string projectId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}