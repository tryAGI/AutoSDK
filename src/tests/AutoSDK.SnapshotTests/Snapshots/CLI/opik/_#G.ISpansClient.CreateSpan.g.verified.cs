//HintName: G.ISpansClient.CreateSpan.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Create span<br/>
        /// Create span
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSpanAsync(

            global::G.SpanWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create span<br/>
        /// Create span
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="traceId"></param>
        /// <param name="parentSpanId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="tags"></param>
        /// <param name="usage"></param>
        /// <param name="errorInfo"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="totalEstimatedCost"></param>
        /// <param name="totalEstimatedCostVersion"></param>
        /// <param name="ttft">
        /// Time to first token in milliseconds
        /// </param>
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateSpanAsync(
            global::System.DateTime startTime,
            global::System.Guid? id = default,
            string? projectName = default,
            global::System.Guid? traceId = default,
            global::System.Guid? parentSpanId = default,
            string? name = default,
            global::G.SpanWriteType? type = default,
            global::System.DateTime? endTime = default,
            global::G.JsonListStringWrite? input = default,
            global::G.JsonListStringWrite? output = default,
            global::G.JsonListStringWrite? metadata = default,
            string? model = default,
            string? provider = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.Dictionary<string, int>? usage = default,
            global::G.ErrorInfoWrite? errorInfo = default,
            global::System.DateTime? lastUpdatedAt = default,
            double? totalEstimatedCost = default,
            string? totalEstimatedCostVersion = default,
            double? ttft = default,
            global::G.SpanWriteSource? source = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}