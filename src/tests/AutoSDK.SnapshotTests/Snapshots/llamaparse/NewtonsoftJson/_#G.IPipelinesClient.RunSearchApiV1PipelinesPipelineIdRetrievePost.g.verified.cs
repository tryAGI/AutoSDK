//HintName: G.IPipelinesClient.RunSearchApiV1PipelinesPipelineIdRetrievePost.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Run Search<br/>
        /// Run a retrieval query against a managed pipeline.<br/>
        /// Searches the pipeline's vector store using the provided query<br/>
        /// and retrieval parameters. Supports dense, sparse, and hybrid<br/>
        /// search modes with configurable top-k and reranking.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetrieveResults> RunSearchApiV1PipelinesPipelineIdRetrievePostAsync(
            global::System.Guid pipelineId,

            global::G.RetrievalParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Search<br/>
        /// Run a retrieval query against a managed pipeline.<br/>
        /// Searches the pipeline's vector store using the provided query<br/>
        /// and retrieval parameters. Supports dense, sparse, and hybrid<br/>
        /// search modes with configurable top-k and reranking.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="denseSimilarityTopK">
        /// Number of nodes for dense retrieval.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="denseSimilarityCutoff">
        /// Minimum similarity score wrt query for retrieval<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="sparseSimilarityTopK">
        /// Number of nodes for sparse retrieval.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="enableReranking">
        /// Enable reranking for retrieval
        /// </param>
        /// <param name="rerankTopN">
        /// Number of reranked nodes for returning.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="alpha">
        /// Alpha value for hybrid retrieval to determine the weights between dense and sparse retrieval. 0 is sparse retrieval and 1 is dense retrieval.
        /// </param>
        /// <param name="searchFilters">
        /// Search filters for retrieval.
        /// </param>
        /// <param name="searchFiltersInferenceSchema">
        /// JSON Schema that will be used to infer search_filters. Omit or leave as null to skip inference.
        /// </param>
        /// <param name="filesTopK">
        /// Number of files to retrieve (only for retrieval mode files_via_metadata and files_via_content).<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="retrievalMode">
        /// The retrieval mode for the query.<br/>
        /// Default Value: chunks
        /// </param>
        /// <param name="retrievePageScreenshotNodes">
        /// Whether to retrieve page screenshot nodes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="retrievePageFigureNodes">
        /// Whether to retrieve page figure nodes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="query">
        /// The query to retrieve against.
        /// </param>
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetrieveResults> RunSearchApiV1PipelinesPipelineIdRetrievePostAsync(
            global::System.Guid pipelineId,
            string query,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            int? denseSimilarityTopK = default,
            double? denseSimilarityCutoff = default,
            int? sparseSimilarityTopK = default,
            bool? enableReranking = default,
            int? rerankTopN = default,
            double? alpha = default,
            global::G.MetadataFilters? searchFilters = default,
            object? searchFiltersInferenceSchema = default,
            int? filesTopK = default,
            global::G.RetrievalMode? retrievalMode = default,
            bool? retrievePageScreenshotNodes = default,
            bool? retrievePageFigureNodes = default,
            string? className = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}