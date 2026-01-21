//HintName: G.ISummarizeClient.V1Summarize.g.cs
#nullable enable

namespace G
{
    public partial interface ISummarizeClient
    {
        /// <summary>
        /// Summarize
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008L
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SummarizationResponse> V1SummarizeAsync(
            global::G.SummarizeBody request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Summarize
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008L
        /// </param>
        /// <param name="source"></param>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="focus"></param>
        /// <param name="summaryMethod">
        /// An enumeration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SummarizationResponse> V1SummarizeAsync(
            string source,
            global::G.DocumentType sourceType,
            int? requestStartTime = default,
            string? focus = default,
            global::G.SummaryMethod? summaryMethod = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}