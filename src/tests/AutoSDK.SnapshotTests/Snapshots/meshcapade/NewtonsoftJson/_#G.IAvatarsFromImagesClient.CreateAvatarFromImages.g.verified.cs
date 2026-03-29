//HintName: G.IAvatarsFromImagesClient.CreateAvatarFromImages.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsFromImagesClient
    {
        /// <summary>
        /// Initiate avatar creation from images
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> CreateAvatarFromImagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}