//HintName: G.IAuthClient.OauthProviderLogout.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Oauth Provider Logout
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OauthProviderLogoutAsync(
            global::G.OAuthProvider provider,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}