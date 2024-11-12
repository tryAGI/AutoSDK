//HintName: G.IRAGEngineClient.V1LibrarySearch.g.cs
#nullable enable

namespace G
{
    public partial interface IRAGEngineClient
    {
        /// <summary>
        /// Search
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LibrarySearchResponse> V1LibrarySearchAsync(
            global::G.LibrarySearchRequest request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="query"></param>
        /// <param name="maxSegments"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="labelsFilter"></param>
        /// <param name="labelsFilterMode">
        /// Default Value: AND
        /// </param>
        /// <param name="fileIds"></param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="maxNeighbors">
        /// Default Value: 1
        /// </param>
        /// <param name="retrievalSimilarityThreshold"></param>
        /// <param name="hybridSearchAlpha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LibrarySearchResponse> V1LibrarySearchAsync(
            string query,
            int? requestStartTime = default,
            int? maxSegments = default,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::G.QueryFilter? labelsFilter = default,
            global::G.LibrarySearchRequestLabelsFilterMode? labelsFilterMode = default,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds = default,
            global::G.RetrievalStrategy? retrievalStrategy = default,
            int? maxNeighbors = default,
            double? retrievalSimilarityThreshold = default,
            double? hybridSearchAlpha = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}