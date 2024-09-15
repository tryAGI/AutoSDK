//HintName: G.IAccountClient.AccountGetAccountForCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// GetAccountForCurrentUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AccountGetAccountForCurrentUserResponse> AccountGetAccountForCurrentUserAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}