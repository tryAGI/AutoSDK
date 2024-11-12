//HintName: G.ISummarizeClient.V1SummarizeBySegment.g.cs
#nullable enable

namespace G
{
    public partial interface ISummarizeClient
    {
        /// <summary>
        /// Segmented Summarize
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SummarizeBySegmentResponse> V1SummarizeBySegmentAsync(
            global::G.SegmentedSummaryBody request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Segmented Summarize
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
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
            int? requestStartTime = default,
            string? focus = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}