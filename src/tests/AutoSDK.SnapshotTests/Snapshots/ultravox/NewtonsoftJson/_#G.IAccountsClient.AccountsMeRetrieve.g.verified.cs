//HintName: G.IAccountsClient.AccountsMeRetrieve.g.cs
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
        global::System.Threading.Tasks.Task<global::G.Account> AccountsMeRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}