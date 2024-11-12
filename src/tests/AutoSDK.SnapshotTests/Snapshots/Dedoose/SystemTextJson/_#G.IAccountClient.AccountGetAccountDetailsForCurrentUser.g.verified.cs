//HintName: G.IAccountClient.AccountGetAccountDetailsForCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// GetAccountDetailsForCurrentUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AccountServiceGetAccountDetailsForCurrentUserControllerOutput> AccountGetAccountDetailsForCurrentUserAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}