//HintName: G.IBillingClient.ListStoreCostInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// List store cost information
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreCostListResponse> ListStoreCostInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}