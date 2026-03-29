//HintName: G.IClipsStreamsClient.CreateClipStream.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IClipsStreamsClient
    {
        /// <summary>
        /// Create a clip stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.CreateClipStreamResponse> CreateClipStreamAsync(
            string id,

            global::G.CreateClipStreamRequest2 request,
            string? xApiKeyExternal = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a clip stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="sessionId"></param>
        /// <param name="script"></param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="createdBy">
        /// The user created the clip.
        /// </param>
        /// <param name="presenterConfig">
        /// Advanced presenter configuration options.
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the clip response and webhook.
        /// </param>
        /// <param name="name">
        /// The name of the clip
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the clip video, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/
        /// </param>
        /// <param name="metadata">
        /// Metadata passed to the clips worker
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.CreateClipStreamResponse> CreateClipStreamAsync(
            string id,
            global::G.AnyOf<global::G.CreateClipStreamRequestScriptVariant12, global::G.CreateClipStreamRequestScriptVariant22> script,
            string? xApiKeyExternal = default,
            string? sessionId = default,
            global::G.CreateClipStreamRequestConfig2? config = default,
            string? createdBy = default,
            global::G.CreateClipStreamRequestPresenterConfig2? presenterConfig = default,
            string? userData = default,
            string? name = default,
            string? resultUrl = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}