//HintName: G.IAvatarsClient.MeasureAvatar.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Measure avatar body measurements
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> MeasureAvatarAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}