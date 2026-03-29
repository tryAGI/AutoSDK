//HintName: G.IBillingClient.GetStoreCostHistogram.g.cs
#nullable enable

namespace G
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get store cost histogram
        /// </summary>
        /// <param name="storeId">
        /// The ID of the store
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CostHistogramResponse> GetStoreCostHistogramAsync(
            global::System.Guid storeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}