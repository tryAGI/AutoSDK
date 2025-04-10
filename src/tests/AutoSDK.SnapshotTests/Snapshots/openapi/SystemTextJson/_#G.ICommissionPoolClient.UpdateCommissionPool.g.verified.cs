//HintName: G.ICommissionPoolClient.UpdateCommissionPool.g.cs
#nullable enable

namespace G
{
    public partial interface ICommissionPoolClient
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
        global::System.Threading.Tasks.Task<string> UpdateCommissionPoolAsync(
            global::G.CommissionPoolForUpdateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="id"></param>
        /// <param name="poolName"></param>
        /// <param name="volumeRequired"></param>
        /// <param name="activePackageValueRequired"></param>
        /// <param name="percentageRevenueShare"></param>
        /// <param name="currentAchievers"></param>
        /// <param name="currentEstimatedRevenue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCommissionPoolAsync(
            string? currentCulture = default,
            long? id = default,
            string? poolName = default,
            int? volumeRequired = default,
            int? activePackageValueRequired = default,
            double? percentageRevenueShare = default,
            int? currentAchievers = default,
            double? currentEstimatedRevenue = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}