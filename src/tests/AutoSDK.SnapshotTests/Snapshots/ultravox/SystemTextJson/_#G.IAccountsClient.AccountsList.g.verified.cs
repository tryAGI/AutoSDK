//HintName: G.IAccountsClient.AccountsList.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Account>> AccountsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}