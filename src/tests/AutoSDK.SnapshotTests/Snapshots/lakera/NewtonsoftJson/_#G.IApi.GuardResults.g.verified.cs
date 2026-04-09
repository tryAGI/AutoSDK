//HintName: G.IApi.GuardResults.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get detailed detection results<br/>
        /// Similar to /v2/guard but returns detailed detection results with confidence scores, <br/>
        /// matched substrings, and additional metadata for each detector that triggered.<br/>
        /// Use this endpoint when you need granular information about why content was flagged,<br/>
        /// including exact text spans and detector confidence values.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardResultsResponse> GuardResultsAsync(

            global::G.GuardRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get detailed detection results<br/>
        /// Similar to /v2/guard but returns detailed detection results with confidence scores, <br/>
        /// matched substrings, and additional metadata for each detector that triggered.<br/>
        /// Use this endpoint when you need granular information about why content was flagged,<br/>
        /// including exact text spans and detector confidence values.
        /// </summary>
        /// <param name="messages">
        /// Array of chat messages to screen. Follows the OpenAI chat format.
        /// </param>
        /// <param name="policy">
        /// Inline policy configuration that specifies which detectors to run and their thresholds.
        /// </param>
        /// <param name="breakdown">
        /// If true, returns per-message breakdown in the results.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadata">
        /// Optional metadata to attach to this screening request for logging/tracking.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardResultsResponse> GuardResultsAsync(
            global::System.Collections.Generic.IList<global::G.GuardMessage> messages,
            global::G.Policy? policy = default,
            bool? breakdown = default,
            object? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}