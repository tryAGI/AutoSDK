//HintName: G.IAccessTokensClient.CreateAccessTokens.g.cs
#nullable enable

namespace G
{
    public partial interface IAccessTokensClient
    {
        /// <summary>
        /// Create a new access token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatedAccessToken> CreateAccessTokensAsync(

            global::G.NewAccessToken request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new access token
        /// </summary>
        /// <param name="name">
        /// Name of the access token
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatedAccessToken> CreateAccessTokensAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}