//HintName: G.IApi.CreateVideoEffects.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create video effects task<br/>
        /// Apply AI special effects to images, such as old photo restoration, holiday themes, and dual-character effects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateVideoEffectsAsync(

            global::G.CreateVideoEffectsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create video effects task<br/>
        /// Apply AI special effects to images, such as old photo restoration, holiday themes, and dual-character effects.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="modelName">
        /// Model to use for effects generation.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateVideoEffectsAsync(
            global::G.EffectsInput input,
            string? modelName = default,
            string? duration = default,
            string? callbackUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}