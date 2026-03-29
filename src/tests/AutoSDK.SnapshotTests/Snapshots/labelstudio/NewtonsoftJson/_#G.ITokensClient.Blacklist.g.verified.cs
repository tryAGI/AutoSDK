//HintName: G.ITokensClient.Blacklist.g.cs
#nullable enable

namespace G
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Blacklist a JWT refresh token<br/>
        /// Adds a JWT refresh token to the blacklist, preventing it from being used to obtain new access tokens.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> BlacklistAsync(

            global::G.LSAPITokenBlacklistRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Blacklist a JWT refresh token<br/>
        /// Adds a JWT refresh token to the blacklist, preventing it from being used to obtain new access tokens.
        /// </summary>
        /// <param name="refresh">
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> BlacklistAsync(
            string refresh,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}