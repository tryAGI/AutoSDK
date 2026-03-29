//HintName: G.Models.KnowledgeBaseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseResponse
    {
        /// <summary>
        /// Unique id of the knowledge base.<br/>
        /// Example: knowledge_base_a456426614174000
        /// </summary>
        /// <example>knowledge_base_a456426614174000</example>
        [global::Newtonsoft.Json.JsonProperty("knowledge_base_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KnowledgeBaseId { get; set; } = default!;

        /// <summary>
        /// Name of the knowledge base. Must be less than 40 characters.<br/>
        /// Example: Sample KB
        /// </summary>
        /// <example>Sample KB</example>
        [global::Newtonsoft.Json.JsonProperty("knowledge_base_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string KnowledgeBaseName { get; set; } = default!;

        /// <summary>
        /// Status of the knowledge base. When it's created and being processed, it's "in_progress". When the processing is done, it's "complete". When there's an error in processing, it's "error". When it is during kb updating, it's "refreshing_in_progress".<br/>
        /// Example: in_progress
        /// </summary>
        /// <example>in_progress</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.KnowledgeBaseResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// Maximum number of characters per chunk when splitting knowledge base content.<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::Newtonsoft.Json.JsonProperty("max_chunk_size")]
        public int? MaxChunkSize { get; set; }

        /// <summary>
        /// Minimum number of characters per chunk. Chunks smaller than this are merged with adjacent chunks.<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::Newtonsoft.Json.JsonProperty("min_chunk_size")]
        public int? MinChunkSize { get; set; }

        /// <summary>
        /// Sources of the knowledge base. Will be populated after the processing is done (when status is "complete").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge_base_sources")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.KnowledgeBaseSourceDocument, global::G.KnowledgeBaseSourceText, global::G.KnowledgeBaseSourceUrl>>? KnowledgeBaseSources { get; set; }

        /// <summary>
        /// Whether to enable auto refresh for the knowledge base urls. If set to true, will retrieve the data from the specified url every 12 hours.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enable_auto_refresh")]
        public bool? EnableAutoRefresh { get; set; }

        /// <summary>
        /// Last refreshed timestamp (milliseconds since epoch). Only applicable when enable_auto_refresh is true.<br/>
        /// Example: 1703413636133
        /// </summary>
        /// <example>1703413636133</example>
        [global::Newtonsoft.Json.JsonProperty("last_refreshed_timestamp")]
        public long? LastRefreshedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseResponse" /> class.
        /// </summary>
        /// <param name="knowledgeBaseId">
        /// Unique id of the knowledge base.<br/>
        /// Example: knowledge_base_a456426614174000
        /// </param>
        /// <param name="knowledgeBaseName">
        /// Name of the knowledge base. Must be less than 40 characters.<br/>
        /// Example: Sample KB
        /// </param>
        /// <param name="status">
        /// Status of the knowledge base. When it's created and being processed, it's "in_progress". When the processing is done, it's "complete". When there's an error in processing, it's "error". When it is during kb updating, it's "refreshing_in_progress".<br/>
        /// Example: in_progress
        /// </param>
        /// <param name="maxChunkSize">
        /// Maximum number of characters per chunk when splitting knowledge base content.<br/>
        /// Example: 2000
        /// </param>
        /// <param name="minChunkSize">
        /// Minimum number of characters per chunk. Chunks smaller than this are merged with adjacent chunks.<br/>
        /// Example: 400
        /// </param>
        /// <param name="knowledgeBaseSources">
        /// Sources of the knowledge base. Will be populated after the processing is done (when status is "complete").
        /// </param>
        /// <param name="enableAutoRefresh">
        /// Whether to enable auto refresh for the knowledge base urls. If set to true, will retrieve the data from the specified url every 12 hours.<br/>
        /// Example: true
        /// </param>
        /// <param name="lastRefreshedTimestamp">
        /// Last refreshed timestamp (milliseconds since epoch). Only applicable when enable_auto_refresh is true.<br/>
        /// Example: 1703413636133
        /// </param>
        public KnowledgeBaseResponse(
            string knowledgeBaseId,
            string knowledgeBaseName,
            global::G.KnowledgeBaseResponseStatus status,
            int? maxChunkSize,
            int? minChunkSize,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.KnowledgeBaseSourceDocument, global::G.KnowledgeBaseSourceText, global::G.KnowledgeBaseSourceUrl>>? knowledgeBaseSources,
            bool? enableAutoRefresh,
            long? lastRefreshedTimestamp)
        {
            this.KnowledgeBaseId = knowledgeBaseId ?? throw new global::System.ArgumentNullException(nameof(knowledgeBaseId));
            this.KnowledgeBaseName = knowledgeBaseName ?? throw new global::System.ArgumentNullException(nameof(knowledgeBaseName));
            this.Status = status;
            this.MaxChunkSize = maxChunkSize;
            this.MinChunkSize = minChunkSize;
            this.KnowledgeBaseSources = knowledgeBaseSources;
            this.EnableAutoRefresh = enableAutoRefresh;
            this.LastRefreshedTimestamp = lastRefreshedTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseResponse" /> class.
        /// </summary>
        public KnowledgeBaseResponse()
        {
        }
    }
}