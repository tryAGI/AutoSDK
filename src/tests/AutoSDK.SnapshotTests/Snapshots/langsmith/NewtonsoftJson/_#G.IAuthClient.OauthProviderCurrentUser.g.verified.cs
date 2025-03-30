//HintName: G.IAuthClient.OauthProviderCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Oauth Provider Current User
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OauthProviderCurrentUserAsync(
            global::G.OAuthProvider provider,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}