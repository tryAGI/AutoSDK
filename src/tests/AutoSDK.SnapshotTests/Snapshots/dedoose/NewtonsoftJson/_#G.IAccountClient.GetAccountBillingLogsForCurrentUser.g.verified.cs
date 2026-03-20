//HintName: G.IAccountClient.GetAccountBillingLogsForCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// GetAccountBillingLogsForCurrentUser<br/>
        /// GetAccountBillingLogsForCurrentUser
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AccountWithLogs> GetAccountBillingLogsForCurrentUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}