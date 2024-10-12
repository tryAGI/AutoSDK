//HintName: G.IAuthClient.OauthProviderAuth.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Oauth Provider Auth
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OauthProviderAuthApiV1OauthProviderGetResponse> OauthProviderAuthAsync(
            global::G.OAuthProvider provider = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}