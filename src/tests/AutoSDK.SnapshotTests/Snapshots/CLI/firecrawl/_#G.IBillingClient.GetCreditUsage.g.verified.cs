//HintName: G.IBillingClient.GetCreditUsage.g.cs
#nullable enable

namespace G
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get remaining credits for the authenticated team
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCreditUsageResponse> GetCreditUsageAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}