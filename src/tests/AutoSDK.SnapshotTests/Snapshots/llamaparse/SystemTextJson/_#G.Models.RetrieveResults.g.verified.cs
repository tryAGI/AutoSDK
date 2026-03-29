//HintName: G.Models.RetrieveResults.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for the result of an retrieval execution.
    /// </summary>
    public sealed partial class RetrieveResults
    {
        /// <summary>
        /// The ID of the pipeline that the query was retrieved against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PipelineId { get; set; }

        /// <summary>
        /// The nodes retrieved by the pipeline for the given query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TextNodeWithScore> RetrievalNodes { get; set; }

        /// <summary>
        /// The image nodes retrieved by the pipeline for the given query. Deprecated - will soon be replaced with 'page_screenshot_nodes'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_nodes")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.PageScreenshotNodeWithScore>? ImageNodes { get; set; }

        /// <summary>
        /// The page figure nodes retrieved by the pipeline for the given query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_figure_nodes")]
        public global::System.Collections.Generic.IList<global::G.PageFigureNodeWithScore>? PageFigureNodes { get; set; }

        /// <summary>
        /// The end-to-end latency for retrieval and reranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_latency")]
        public global::System.Collections.Generic.Dictionary<string, double>? RetrievalLatency { get; set; }

        /// <summary>
        /// Metadata associated with the retrieval execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The inferred search filters for the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inferred_search_filters")]
        public global::G.MetadataFilters? InferredSearchFilters { get; set; }

        /// <summary>
        /// Default Value: RetrieveResults
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveResults" /> class.
        /// </summary>
        /// <param name="pipelineId">
        /// The ID of the pipeline that the query was retrieved against.
        /// </param>
        /// <param name="retrievalNodes">
        /// The nodes retrieved by the pipeline for the given query.
        /// </param>
        /// <param name="pageFigureNodes">
        /// The page figure nodes retrieved by the pipeline for the given query.
        /// </param>
        /// <param name="retrievalLatency">
        /// The end-to-end latency for retrieval and reranking.
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the retrieval execution
        /// </param>
        /// <param name="inferredSearchFilters">
        /// The inferred search filters for the query.
        /// </param>
        /// <param name="className">
        /// Default Value: RetrieveResults
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveResults(
            global::System.Guid pipelineId,
            global::System.Collections.Generic.IList<global::G.TextNodeWithScore> retrievalNodes,
            global::System.Collections.Generic.IList<global::G.PageFigureNodeWithScore>? pageFigureNodes,
            global::System.Collections.Generic.Dictionary<string, double>? retrievalLatency,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.MetadataFilters? inferredSearchFilters,
            string? className)
        {
            this.PipelineId = pipelineId;
            this.RetrievalNodes = retrievalNodes ?? throw new global::System.ArgumentNullException(nameof(retrievalNodes));
            this.PageFigureNodes = pageFigureNodes;
            this.RetrievalLatency = retrievalLatency;
            this.Metadata = metadata;
            this.InferredSearchFilters = inferredSearchFilters;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveResults" /> class.
        /// </summary>
        public RetrieveResults()
        {
        }
    }
}