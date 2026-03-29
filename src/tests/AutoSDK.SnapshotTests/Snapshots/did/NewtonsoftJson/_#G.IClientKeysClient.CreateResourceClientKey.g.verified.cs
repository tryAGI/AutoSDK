//HintName: G.IClientKeysClient.CreateResourceClientKey.g.cs
#nullable enable

namespace G
{
    public partial interface IClientKeysClient
    {
        /// <summary>
        /// Create Agent Client Key<br/>
        /// Create a client key scoped to a specific agent. Multiple keys per agent are allowed with different domain sets.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateResourceClientKeyResponse> CreateResourceClientKeyAsync(
            string agentId,

            global::G.CreateResourceClientKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Client Key<br/>
        /// Create a client key scoped to a specific agent. Multiple keys per agent are allowed with different domain sets.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="allowedDomains"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateResourceClientKeyResponse> CreateResourceClientKeyAsync(
            string agentId,
            global::System.Collections.Generic.IList<string> allowedDomains,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}