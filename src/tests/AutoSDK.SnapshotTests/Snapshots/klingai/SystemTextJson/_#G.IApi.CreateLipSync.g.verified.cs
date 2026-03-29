//HintName: G.IApi.CreateLipSync.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create lip-sync task<br/>
        /// Create a lip-sync video by syncing audio to a video. Provide either audio_url or tts_text/tts_voice.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateLipSyncAsync(

            global::G.CreateLipSyncRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create lip-sync task<br/>
        /// Create a lip-sync video by syncing audio to a video. Provide either audio_url or tts_text/tts_voice.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="modelName">
        /// Model to use for lip-sync.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateLipSyncAsync(
            global::G.LipSyncInput input,
            string? modelName = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}