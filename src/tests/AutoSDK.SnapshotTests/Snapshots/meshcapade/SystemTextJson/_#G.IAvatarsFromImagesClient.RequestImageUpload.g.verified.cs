//HintName: G.IAvatarsFromImagesClient.RequestImageUpload.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsFromImagesClient
    {
        /// <summary>
        /// Request image upload URL for AFI avatar
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> RequestImageUploadAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}