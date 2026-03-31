//HintName: G.IClientKeysClient.ListResourceClientKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IClientKeysClient
    {
        /// <summary>
        /// List Agent Client Keys<br/>
        /// List all client keys scoped to a specific agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ListResourceClientKeysResponseItem>> ListResourceClientKeysAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}