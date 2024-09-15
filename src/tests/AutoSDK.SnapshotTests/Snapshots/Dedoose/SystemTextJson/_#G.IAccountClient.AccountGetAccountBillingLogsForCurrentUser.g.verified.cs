//HintName: G.IAccountClient.AccountGetAccountBillingLogsForCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// GetAccountBillingLogsForCurrentUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AccountWithLogs> AccountGetAccountBillingLogsForCurrentUserAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}