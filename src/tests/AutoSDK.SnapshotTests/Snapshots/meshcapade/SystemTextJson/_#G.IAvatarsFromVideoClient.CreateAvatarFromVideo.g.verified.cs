//HintName: G.IAvatarsFromVideoClient.CreateAvatarFromVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsFromVideoClient
    {
        /// <summary>
        /// Initiate avatar creation from video
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> CreateAvatarFromVideoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}