//HintName: G.IBillingClient.GetBillingSummary.g.cs
#nullable enable

namespace G
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get billing summary
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BillingPeriodSummary> GetBillingSummaryAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}