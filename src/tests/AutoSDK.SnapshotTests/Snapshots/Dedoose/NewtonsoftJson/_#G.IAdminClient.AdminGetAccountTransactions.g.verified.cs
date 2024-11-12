//HintName: G.IAdminClient.AdminGetAccountTransactions.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetAccountTransactions.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AdminGetAccountTransactionsAsync(
            string? token = default,
            global::System.Guid? accountId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}