//HintName: G.IAvatarsFromImagesClient.FitToImages.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsFromImagesClient
    {
        /// <summary>
        /// Start fitting avatar to uploaded images
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> FitToImagesAsync(
            global::System.Guid assetID,

            global::G.FitToImagesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start fitting avatar to uploaded images
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="imageMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> FitToImagesAsync(
            global::System.Guid assetID,
            string? imageMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}