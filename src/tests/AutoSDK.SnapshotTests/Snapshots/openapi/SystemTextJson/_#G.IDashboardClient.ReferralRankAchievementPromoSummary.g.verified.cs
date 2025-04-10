//HintName: G.IDashboardClient.ReferralRankAchievementPromoSummary.g.cs
#nullable enable

namespace G
{
    public partial interface IDashboardClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requiredRankId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReferralRankAchievementPromoSummaryResponseDto> ReferralRankAchievementPromoSummaryAsync(
            long? userId = default,
            int? requiredRankId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}