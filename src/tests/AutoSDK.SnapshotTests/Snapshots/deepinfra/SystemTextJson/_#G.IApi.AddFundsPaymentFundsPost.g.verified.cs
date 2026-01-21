//HintName: G.IApi.AddFundsPaymentFundsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Add Funds
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddFundsPaymentFundsPostAsync(
            global::G.AddFundsIn request,
            object? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Funds
        /// </summary>
        /// <param name="session"></param>
        /// <param name="amount">
        /// Amount to add in cents
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddFundsPaymentFundsPostAsync(
            int amount,
            object? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}