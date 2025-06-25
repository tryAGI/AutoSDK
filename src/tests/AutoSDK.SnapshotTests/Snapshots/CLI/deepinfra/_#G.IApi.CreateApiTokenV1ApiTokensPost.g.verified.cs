//HintName: G.IApi.CreateApiTokenV1ApiTokensPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create Api Token
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiToken> CreateApiTokenV1ApiTokensPostAsync(
            global::G.ApiTokenIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Api Token
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiToken> CreateApiTokenV1ApiTokensPostAsync(
            string name,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}