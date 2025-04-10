//HintName: G.IProductSubscriptionClient.DebitCharityProductSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IProductSubscriptionClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DebitCharityProductSubscriptionAsync(
            global::G.ProductSubscriptionForDebitCharityRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="adminId"></param>
        /// <param name="debitAmount"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DebitCharityProductSubscriptionAsync(
            string? currentCulture = default,
            long? adminId = default,
            double? debitAmount = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}