//HintName: G.IVideosClient.GenerateVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Generate Video<br/>
        /// Generates a new video using a Replica and either a script or an audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Video> GenerateVideoAsync(

            global::G.GenerateVideoRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Video<br/>
        /// Generates a new video using a Replica and either a script or an audio file.
        /// </summary>
        /// <param name="replicaId">
        /// The replica to use for the video.
        /// </param>
        /// <param name="script">
        /// Text for the replica to speak.
        /// </param>
        /// <param name="audioUrl">
        /// Audio file URL (.wav or .mp3) for lip-sync.
        /// </param>
        /// <param name="videoName"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="backgroundUrl">
        /// Website URL for background.
        /// </param>
        /// <param name="backgroundSourceUrl">
        /// Direct download link for video background.
        /// </param>
        /// <param name="transparentBackground"></param>
        /// <param name="properties"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Video> GenerateVideoAsync(
            string replicaId,
            string? script = default,
            string? audioUrl = default,
            string? videoName = default,
            string? callbackUrl = default,
            string? backgroundUrl = default,
            string? backgroundSourceUrl = default,
            bool? transparentBackground = default,
            global::G.VideoProperties? properties = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}