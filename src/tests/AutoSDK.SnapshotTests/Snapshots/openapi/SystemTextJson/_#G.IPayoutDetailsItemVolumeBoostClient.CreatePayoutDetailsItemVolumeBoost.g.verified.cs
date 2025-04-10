//HintName: G.IPayoutDetailsItemVolumeBoostClient.CreatePayoutDetailsItemVolumeBoost.g.cs
#nullable enable

namespace G
{
    public partial interface IPayoutDetailsItemVolumeBoostClient
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
        global::System.Threading.Tasks.Task<global::G.PayoutDetailsItemVolumeBoostForCreateResponseDto> CreatePayoutDetailsItemVolumeBoostAsync(
            global::G.PayoutDetailsItemVolumeBoostForCreateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userId"></param>
        /// <param name="payoutPeriodId"></param>
        /// <param name="leg1Volume"></param>
        /// <param name="leg2Volume"></param>
        /// <param name="applyUpLine"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PayoutDetailsItemVolumeBoostForCreateResponseDto> CreatePayoutDetailsItemVolumeBoostAsync(
            string? currentCulture = default,
            long? userId = default,
            long? payoutPeriodId = default,
            double? leg1Volume = default,
            double? leg2Volume = default,
            bool? applyUpLine = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}