//HintName: G.ITracesClient.CreateTrace.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Create trace<br/>
        /// Get trace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateTraceAsync(

            global::G.TraceWrite request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create trace<br/>
        /// Get trace
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="errorInfo"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="ttft">
        /// Time to first token in milliseconds
        /// </param>
        /// <param name="threadId"></param>
        /// <param name="source"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateTraceAsync(
            global::System.DateTime startTime,
            global::System.Guid? id = default,
            string? projectName = default,
            string? name = default,
            global::System.DateTime? endTime = default,
            global::G.JsonListStringWrite? input = default,
            global::G.JsonListStringWrite? output = default,
            global::G.JsonListStringWrite? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.ErrorInfoWrite? errorInfo = default,
            global::System.DateTime? lastUpdatedAt = default,
            double? ttft = default,
            string? threadId = default,
            global::G.TraceWriteSource? source = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}