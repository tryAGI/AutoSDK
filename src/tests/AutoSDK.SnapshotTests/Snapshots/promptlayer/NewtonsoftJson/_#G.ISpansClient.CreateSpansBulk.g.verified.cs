//HintName: G.ISpansClient.CreateSpansBulk.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Create Spans Bulk
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSpansBulkResponse> CreateSpansBulkAsync(

            global::G.CreateSpansBulk request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Spans Bulk
        /// </summary>
        /// <param name="spans"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSpansBulkResponse> CreateSpansBulkAsync(
            global::System.Collections.Generic.IList<global::G.Span> spans,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}