//HintName: G.IApi.GetBalance.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// get user balance
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetBalanceResponse> GetBalanceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}