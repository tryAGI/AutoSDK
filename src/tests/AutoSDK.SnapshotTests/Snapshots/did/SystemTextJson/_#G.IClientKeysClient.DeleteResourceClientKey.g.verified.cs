//HintName: G.IClientKeysClient.DeleteResourceClientKey.g.cs
#nullable enable

namespace G
{
    public partial interface IClientKeysClient
    {
        /// <summary>
        /// Delete Agent Client Key<br/>
        /// Delete a client key scoped to a specific agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="clientKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteResourceClientKeyAsync(
            string agentId,
            string clientKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}