//HintName: G.IPayoutPeriodClient.GetAllPayoutPeriods.g.cs
#nullable enable

namespace G
{
    public partial interface IPayoutPeriodClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="payoutPeriodForListRequestDto"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PayoutPeriodForListResponseDto>> GetAllPayoutPeriodsAsync(
            object? payoutPeriodForListRequestDto = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}