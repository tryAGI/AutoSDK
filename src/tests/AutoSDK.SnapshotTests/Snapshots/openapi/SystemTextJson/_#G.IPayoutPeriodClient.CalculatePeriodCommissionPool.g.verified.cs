//HintName: G.IPayoutPeriodClient.CalculatePeriodCommissionPool.g.cs
#nullable enable

namespace G
{
    public partial interface IPayoutPeriodClient
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
        global::System.Threading.Tasks.Task<string> CalculatePeriodCommissionPoolAsync(
            global::G.PayoutPeriodForCalculateCommissionsRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="payoutPeriodId"></param>
        /// <param name="fastWeeklyVolumes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CalculatePeriodCommissionPoolAsync(
            string? currentCulture = default,
            long? payoutPeriodId = default,
            bool? fastWeeklyVolumes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}