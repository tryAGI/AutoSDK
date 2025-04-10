//HintName: G.IRankRewardClaimClient.CreateRankRewardClaim.g.cs
#nullable enable

namespace G
{
    public partial interface IRankRewardClaimClient
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
        global::System.Threading.Tasks.Task<string> CreateRankRewardClaimAsync(
            global::G.RankRewardClaimForCreateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userId"></param>
        /// <param name="submittedDate"></param>
        /// <param name="rankId"></param>
        /// <param name="remark"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateRankRewardClaimAsync(
            string? currentCulture = default,
            long? userId = default,
            global::System.DateTime? submittedDate = default,
            long? rankId = default,
            string? remark = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}