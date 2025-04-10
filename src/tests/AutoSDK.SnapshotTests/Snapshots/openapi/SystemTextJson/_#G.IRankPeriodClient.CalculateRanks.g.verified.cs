//HintName: G.IRankPeriodClient.CalculateRanks.g.cs
#nullable enable

namespace G
{
    public partial interface IRankPeriodClient
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
        global::System.Threading.Tasks.Task<string> CalculateRanksAsync(
            global::G.RankForCalculateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="rankVolumeOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CalculateRanksAsync(
            string? currentCulture = default,
            bool? rankVolumeOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}