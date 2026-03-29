//HintName: G.IAuthenticationClient.GetUserIdentity.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Get user identity<br/>
        /// Returns the current user's identity, tenant, and databases.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUserIdentityResponse> GetUserIdentityAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}