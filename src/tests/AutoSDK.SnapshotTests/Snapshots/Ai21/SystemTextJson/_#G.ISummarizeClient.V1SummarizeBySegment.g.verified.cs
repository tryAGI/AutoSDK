//HintName: G.ISummarizeClient.V1SummarizeBySegment.g.cs
#nullable enable

namespace G
{
    public partial interface ISummarizeClient
    {
        /// <summary>
        /// Segmented Summarize
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SummarizeBySegmentResponse> V1SummarizeBySegmentAsync(
            global::G.SegmentedSummaryBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Segmented Summarize
        /// </summary>
        /// <param name="source"></param>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="focus"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SummarizeBySegmentResponse> V1SummarizeBySegmentAsync(
            string source,
            global::G.DocumentType sourceType,
            string? focus = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}