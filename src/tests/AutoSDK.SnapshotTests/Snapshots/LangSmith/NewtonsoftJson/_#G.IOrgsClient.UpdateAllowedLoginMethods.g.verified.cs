//HintName: G.IOrgsClient.UpdateAllowedLoginMethods.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Allowed Login Methods<br/>
        /// Update allowed login methods for the current organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAllowedLoginMethodsAsync(
            global::G.AllowedLoginMethodsUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Allowed Login Methods<br/>
        /// Update allowed login methods for the current organization.
        /// </summary>
        /// <param name="ssoOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAllowedLoginMethodsAsync(
            bool ssoOnly,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}