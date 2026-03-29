//HintName: G.Models.PresetRetrievalParams.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for the search params for an retrieval execution that can be preset for a pipeline.
    /// </summary>
    public sealed partial class PresetRetrievalParams
    {
        /// <summary>
        /// Number of nodes for dense retrieval.<br/>
        /// Default Value: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dense_similarity_top_k")]
        public int? DenseSimilarityTopK { get; set; }

        /// <summary>
        /// Minimum similarity score wrt query for retrieval<br/>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dense_similarity_cutoff")]
        public double? DenseSimilarityCutoff { get; set; }

        /// <summary>
        /// Number of nodes for sparse retrieval.<br/>
        /// Default Value: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sparse_similarity_top_k")]
        public int? SparseSimilarityTopK { get; set; }

        /// <summary>
        /// Enable reranking for retrieval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_reranking")]
        public bool? EnableReranking { get; set; }

        /// <summary>
        /// Number of reranked nodes for returning.<br/>
        /// Default Value: 6
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rerank_top_n")]
        public int? RerankTopN { get; set; }

        /// <summary>
        /// Alpha value for hybrid retrieval to determine the weights between dense and sparse retrieval. 0 is sparse retrieval and 1 is dense retrieval.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alpha")]
        public double? Alpha { get; set; }

        /// <summary>
        /// Search filters for retrieval.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_filters")]
        public global::G.MetadataFilters? SearchFilters { get; set; }

        /// <summary>
        /// JSON Schema that will be used to infer search_filters. Omit or leave as null to skip inference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_filters_inference_schema")]
        public object? SearchFiltersInferenceSchema { get; set; }

        /// <summary>
        /// Number of files to retrieve (only for retrieval mode files_via_metadata and files_via_content).<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files_top_k")]
        public int? FilesTopK { get; set; }

        /// <summary>
        /// The retrieval mode for the query.<br/>
        /// Default Value: chunks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieval_mode")]
        public global::G.RetrievalMode? RetrievalMode { get; set; }

        /// <summary>
        /// Whether to retrieve image nodes.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieve_image_nodes")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? RetrieveImageNodes { get; set; }

        /// <summary>
        /// Whether to retrieve page screenshot nodes.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieve_page_screenshot_nodes")]
        public bool? RetrievePageScreenshotNodes { get; set; }

        /// <summary>
        /// Whether to retrieve page figure nodes.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieve_page_figure_nodes")]
        public bool? RetrievePageFigureNodes { get; set; }

        /// <summary>
        /// Default Value: base_component
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetRetrievalParams" /> class.
        /// </summary>
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
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
        public PresetRetrievalParams(
            int? denseSimilarityTopK,
            double? denseSimilarityCutoff,
            int? sparseSimilarityTopK,
            bool? enableReranking,
            int? rerankTopN,
            double? alpha,
            global::G.MetadataFilters? searchFilters,
            object? searchFiltersInferenceSchema,
            int? filesTopK,
            global::G.RetrievalMode? retrievalMode,
            bool? retrievePageScreenshotNodes,
            bool? retrievePageFigureNodes,
            string? className)
        {
            this.DenseSimilarityTopK = denseSimilarityTopK;
            this.DenseSimilarityCutoff = denseSimilarityCutoff;
            this.SparseSimilarityTopK = sparseSimilarityTopK;
            this.EnableReranking = enableReranking;
            this.RerankTopN = rerankTopN;
            this.Alpha = alpha;
            this.SearchFilters = searchFilters;
            this.SearchFiltersInferenceSchema = searchFiltersInferenceSchema;
            this.FilesTopK = filesTopK;
            this.RetrievalMode = retrievalMode;
            this.RetrievePageScreenshotNodes = retrievePageScreenshotNodes;
            this.RetrievePageFigureNodes = retrievePageFigureNodes;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetRetrievalParams" /> class.
        /// </summary>
        public PresetRetrievalParams()
        {
        }
    }
}