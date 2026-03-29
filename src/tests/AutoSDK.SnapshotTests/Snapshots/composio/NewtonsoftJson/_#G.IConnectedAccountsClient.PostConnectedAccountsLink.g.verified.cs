//HintName: G.IConnectedAccountsClient.PostConnectedAccountsLink.g.cs
#nullable enable

namespace G
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Create a new auth link session<br/>
        /// Creates a new authentication link session that users can use to connect their accounts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostConnectedAccountsLinkResponse> PostConnectedAccountsLinkAsync(

            global::G.PostConnectedAccountsLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new auth link session<br/>
        /// Creates a new authentication link session that users can use to connect their accounts
        /// </summary>
        /// <param name="authConfigId">
        /// The auth config id to create a link for
        /// </param>
        /// <param name="userId">
        /// The user id to create a link for
        /// </param>
        /// <param name="callbackUrl">
        /// The callback url to create a link for
        /// </param>
        /// <param name="connectionData">
        /// Connection data for the linked account (provider-specific key-value pairs)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostConnectedAccountsLinkResponse> PostConnectedAccountsLinkAsync(
            string authConfigId,
            string userId,
            string? callbackUrl = default,
            object? connectionData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}