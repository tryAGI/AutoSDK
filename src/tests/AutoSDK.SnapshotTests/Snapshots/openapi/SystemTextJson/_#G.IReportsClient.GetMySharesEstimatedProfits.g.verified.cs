//HintName: G.IReportsClient.GetMySharesEstimatedProfits.g.cs
#nullable enable

namespace G
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Retrieve My Shares Estimated Profits<br/>
        /// Returns estimated profits for the next n months based on historical results.
        /// </summary>
        /// <param name="initialAmount">
        /// Default Value: 1000
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="numberOfMonths">
        /// Default Value: 36
        /// </param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMySharesEstimatedProfitsResponseDto> GetMySharesEstimatedProfitsAsync(
            double? initialAmount = default,
            global::System.DateTime? startDate = default,
            int? numberOfMonths = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}