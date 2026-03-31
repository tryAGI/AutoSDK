//HintName: G.ITalksStreamsClient.CreateTalkStream.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface ITalksStreamsClient
    {
        /// <summary>
        /// Create a talk stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="cookie"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.CreateTalkStreamResponse> CreateTalkStreamAsync(
            string id,

            global::G.CreateTalkStreamRequest2 request,
            string? xApiKeyExternal = default,
            string? cookie = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a talk stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="cookie"></param>
        /// <param name="sessionId"></param>
        /// <param name="script"></param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the talk response and webhook.
        /// </param>
        /// <param name="name">
        /// The name of the talk video
        /// </param>
        /// <param name="audioOptimization">
        /// The optimization level of the audio<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="metadata">
        /// Metadata passed to the talks worker
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.CreateTalkStreamResponse> CreateTalkStreamAsync(
            string id,
            global::G.AnyOf<global::G.CreateTalkStreamRequestScriptVariant12, global::G.CreateTalkStreamRequestScriptVariant22> script,
            string? xApiKeyExternal = default,
            string? cookie = default,
            string? sessionId = default,
            global::G.AllOf<global::G.CreateTalkStreamRequestConfigVariant12, global::G.CreateTalkStreamRequestConfigVariant22>? config = default,
            string? userData = default,
            string? name = default,
            double? audioOptimization = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}