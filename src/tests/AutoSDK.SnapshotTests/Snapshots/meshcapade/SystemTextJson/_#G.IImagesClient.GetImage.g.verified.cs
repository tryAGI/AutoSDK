//HintName: G.IImagesClient.GetImage.g.cs
#nullable enable

namespace G
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Get one image
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> GetImageAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}