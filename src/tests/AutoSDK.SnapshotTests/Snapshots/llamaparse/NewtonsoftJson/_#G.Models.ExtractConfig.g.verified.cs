//HintName: G.Models.ExtractConfig.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration parameters for the extraction agent.
    /// </summary>
    public sealed partial class ExtractConfig
    {
        /// <summary>
        /// The priority for the request. This field may be ignored or overwritten depending on the organization tier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority")]
        public global::G.ExtractConfigPriority2? Priority { get; set; }

        /// <summary>
        /// The extraction target specified.<br/>
        /// Default Value: PER_DOC
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_target")]
        public global::G.ExtractTarget? ExtractionTarget { get; set; }

        /// <summary>
        /// The extraction mode specified (FAST, BALANCED, MULTIMODAL, PREMIUM).<br/>
        /// Default Value: PREMIUM
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_mode")]
        public global::G.ExtractMode? ExtractionMode { get; set; }

        /// <summary>
        /// The parse model to use for document parsing. If not provided, uses the default for the extraction mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parse_model")]
        public global::G.PublicModelName? ParseModel { get; set; }

        /// <summary>
        /// The extract model to use for data extraction. If not provided, uses the default for the extraction mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extract_model")]
        public global::G.AnyOf<global::G.ExtractModels?, string, object>? ExtractModel { get; set; }

        /// <summary>
        /// DEPRECATED: Whether to use fast mode for multimodal extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multimodal_fast_mode")]
        public bool? MultimodalFastMode { get; set; }

        /// <summary>
        /// The system prompt to use for the extraction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Whether to use reasoning for the extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_reasoning")]
        public bool? UseReasoning { get; set; }

        /// <summary>
        /// Whether to cite sources for the extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cite_sources")]
        public bool? CiteSources { get; set; }

        /// <summary>
        /// Whether to fetch citation bounding boxes for the extraction. Only available in PREMIUM mode. Deprecated: this is now synonymous with cite_sources.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citation_bbox")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? CitationBbox { get; set; }

        /// <summary>
        /// Whether to fetch confidence scores for the extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence_scores")]
        public bool? ConfidenceScores { get; set; }

        /// <summary>
        /// The mode to use for chunking the document.<br/>
        /// Default Value: PAGE
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_mode")]
        public global::G.DocumentChunkMode? ChunkMode { get; set; }

        /// <summary>
        /// Whether to use high resolution mode for the extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("high_resolution_mode")]
        public bool? HighResolutionMode { get; set; }

        /// <summary>
        /// Whether to invalidate the cache for the extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invalidate_cache")]
        public bool? InvalidateCache { get; set; }

        /// <summary>
        /// Number of pages to pass as context on long document extraction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_pages_context")]
        public int? NumPagesContext { get; set; }

        /// <summary>
        /// Comma-separated list of page numbers or ranges to extract from (1-based, e.g., '1,3,5-7,9' or '1-3,8-10').
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_range")]
        public string? PageRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractConfig" /> class.
        /// </summary>
        /// <param name="priority">
        /// The priority for the request. This field may be ignored or overwritten depending on the organization tier.
        /// </param>
        /// <param name="extractionTarget">
        /// The extraction target specified.<br/>
        /// Default Value: PER_DOC
        /// </param>
        /// <param name="extractionMode">
        /// The extraction mode specified (FAST, BALANCED, MULTIMODAL, PREMIUM).<br/>
        /// Default Value: PREMIUM
        /// </param>
        /// <param name="parseModel">
        /// The parse model to use for document parsing. If not provided, uses the default for the extraction mode.
        /// </param>
        /// <param name="extractModel">
        /// The extract model to use for data extraction. If not provided, uses the default for the extraction mode.
        /// </param>
        /// <param name="multimodalFastMode">
        /// DEPRECATED: Whether to use fast mode for multimodal extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="systemPrompt">
        /// The system prompt to use for the extraction.
        /// </param>
        /// <param name="useReasoning">
        /// Whether to use reasoning for the extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="citeSources">
        /// Whether to cite sources for the extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="confidenceScores">
        /// Whether to fetch confidence scores for the extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="chunkMode">
        /// The mode to use for chunking the document.<br/>
        /// Default Value: PAGE
        /// </param>
        /// <param name="highResolutionMode">
        /// Whether to use high resolution mode for the extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="invalidateCache">
        /// Whether to invalidate the cache for the extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="numPagesContext">
        /// Number of pages to pass as context on long document extraction.
        /// </param>
        /// <param name="pageRange">
        /// Comma-separated list of page numbers or ranges to extract from (1-based, e.g., '1,3,5-7,9' or '1-3,8-10').
        /// </param>
        public ExtractConfig(
            global::G.ExtractConfigPriority2? priority,
            global::G.ExtractTarget? extractionTarget,
            global::G.ExtractMode? extractionMode,
            global::G.PublicModelName? parseModel,
            global::G.AnyOf<global::G.ExtractModels?, string, object>? extractModel,
            bool? multimodalFastMode,
            string? systemPrompt,
            bool? useReasoning,
            bool? citeSources,
            bool? confidenceScores,
            global::G.DocumentChunkMode? chunkMode,
            bool? highResolutionMode,
            bool? invalidateCache,
            int? numPagesContext,
            string? pageRange)
        {
            this.Priority = priority;
            this.ExtractionTarget = extractionTarget;
            this.ExtractionMode = extractionMode;
            this.ParseModel = parseModel;
            this.ExtractModel = extractModel;
            this.MultimodalFastMode = multimodalFastMode;
            this.SystemPrompt = systemPrompt;
            this.UseReasoning = useReasoning;
            this.CiteSources = citeSources;
            this.ConfidenceScores = confidenceScores;
            this.ChunkMode = chunkMode;
            this.HighResolutionMode = highResolutionMode;
            this.InvalidateCache = invalidateCache;
            this.NumPagesContext = numPagesContext;
            this.PageRange = pageRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractConfig" /> class.
        /// </summary>
        public ExtractConfig()
        {
        }
    }
}