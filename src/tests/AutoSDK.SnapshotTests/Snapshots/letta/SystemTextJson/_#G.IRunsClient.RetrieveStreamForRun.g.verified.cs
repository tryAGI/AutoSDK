//HintName: G.IRunsClient.RetrieveStreamForRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Retrieve Stream For Run
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveStreamForRunAsync(
            string runId,

            global::G.RetrieveStreamRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Stream For Run
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="agentId">
        /// Agent ID for agent-direct mode with 'default' conversation. Use with conversation_id='default' in the URL path.
        /// </param>
        /// <param name="startingAfter">
        /// Sequence id to use as a cursor for pagination. Response will start streaming after this chunk sequence id<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="includePings">
        /// Whether to include periodic keepalive ping messages in the stream to prevent connection timeouts.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="pollInterval">
        /// Seconds to wait between polls when no new data.<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="batchSize">
        /// Number of entries to read per batch.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveStreamForRunAsync(
            string runId,
            string? agentId = default,
            int? startingAfter = default,
            bool? includePings = default,
            double? pollInterval = default,
            int? batchSize = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}