//HintName: G.IClientKeysClient.UpdateResourceClientKey.g.cs
#nullable enable

namespace G
{
    public partial interface IClientKeysClient
    {
        /// <summary>
        /// Update Agent Client Key<br/>
        /// Update a client key scoped to a specific agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="clientKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateResourceClientKeyAsync(
            string agentId,
            string clientKey,

            global::G.UpdateResourceClientKeyRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Client Key<br/>
        /// Update a client key scoped to a specific agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="clientKey"></param>
        /// <param name="allowedDomains"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateResourceClientKeyAsync(
            string agentId,
            string clientKey,
            global::System.Collections.Generic.IList<string>? allowedDomains = default,
            string? name = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}