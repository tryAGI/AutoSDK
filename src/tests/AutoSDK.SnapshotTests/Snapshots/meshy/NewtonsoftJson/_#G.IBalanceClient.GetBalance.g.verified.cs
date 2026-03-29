//HintName: G.IBalanceClient.GetBalance.g.cs
#nullable enable

namespace G
{
    public partial interface IBalanceClient
    {
        /// <summary>
        /// Get credit balance
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BalanceResponse> GetBalanceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}