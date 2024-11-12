//HintName: G.IOrgsClient.GetCurrentUserLoginMethods.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Current User Login Methods<br/>
        /// Get login methods for the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ProviderUserSlim>> GetCurrentUserLoginMethodsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}