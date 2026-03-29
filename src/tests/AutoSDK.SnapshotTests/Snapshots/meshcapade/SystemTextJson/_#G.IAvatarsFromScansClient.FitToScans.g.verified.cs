//HintName: G.IAvatarsFromScansClient.FitToScans.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsFromScansClient
    {
        /// <summary>
        /// Start fitting avatar to uploaded scans
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> FitToScansAsync(
            global::System.Guid assetID,

            global::G.FitToScansRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start fitting avatar to uploaded scans
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="initPose"></param>
        /// <param name="inputUnits"></param>
        /// <param name="lookAxis"></param>
        /// <param name="upAxis"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> FitToScansAsync(
            global::System.Guid assetID,
            string? initPose = default,
            string? inputUnits = default,
            string? lookAxis = default,
            string? upAxis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}