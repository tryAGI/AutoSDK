//HintName: G.IClientSideAccessTokensClient.ClientSideAccessTokensListClientSideAccessTokens.g.cs
#nullable enable

namespace G
{
    public partial interface IClientSideAccessTokensClient
    {
        /// <summary>
        /// List tokens  (Cloud-only)<br/>
        /// List all client side access tokens for the current account. This is only available for cloud users.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClientSideAccessTokensListClientSideAccessTokensResponse> ClientSideAccessTokensListClientSideAccessTokensAsync(
            string? agentId = default,
            double? offset = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}