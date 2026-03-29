//HintName: G.Models.KnowledgeBaseRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseRequest
    {
        /// <summary>
        /// Name of the knowledge base. Must be less than 40 characters.<br/>
        /// Example: Sample KB
        /// </summary>
        /// <example>Sample KB</example>
        [global::Newtonsoft.Json.JsonProperty("knowledge_base_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string KnowledgeBaseName { get; set; } = default!;

        /// <summary>
        /// Texts to add to the knowledge base.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge_base_texts")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseRequestKnowledgeBaseText>? KnowledgeBaseTexts { get; set; }

        /// <summary>
        /// Files to add to the knowledge base. Limit to 25 files, where each file is limited to 50MB.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge_base_files")]
        public global::System.Collections.Generic.IList<byte[]>? KnowledgeBaseFiles { get; set; }

        /// <summary>
        /// URLs to be scraped and added to the knowledge base. Must be valid urls.<br/>
        /// Example: [https://www.example.com, https://www.retellai.com]
        /// </summary>
        /// <example>[https://www.example.com, https://www.retellai.com]</example>
        [global::Newtonsoft.Json.JsonProperty("knowledge_base_urls")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseUrls { get; set; }

        /// <summary>
        /// Whether to enable auto refresh for the knowledge base urls. If set to true, will retrieve the data from the specified url every 12 hours.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enable_auto_refresh")]
        public bool? EnableAutoRefresh { get; set; }

        /// <summary>
        /// Maximum number of characters per chunk when splitting knowledge base. Default is 2000. content. Immutable after creation.<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::Newtonsoft.Json.JsonProperty("max_chunk_size")]
        public int? MaxChunkSize { get; set; }

        /// <summary>
        /// Minimum number of characters per chunk. Chunks smaller than this will be merged with adjacent chunks. Must be less than max_chunk_size. Immutable after creation. Default is 400.<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::Newtonsoft.Json.JsonProperty("min_chunk_size")]
        public int? MinChunkSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseRequest" /> class.
        /// </summary>
        /// <param name="knowledgeBaseName">
        /// Name of the knowledge base. Must be less than 40 characters.<br/>
        /// Example: Sample KB
        /// </param>
        /// <param name="knowledgeBaseTexts">
        /// Texts to add to the knowledge base.
        /// </param>
        /// <param name="knowledgeBaseFiles">
        /// Files to add to the knowledge base. Limit to 25 files, where each file is limited to 50MB.
        /// </param>
        /// <param name="knowledgeBaseUrls">
        /// URLs to be scraped and added to the knowledge base. Must be valid urls.<br/>
        /// Example: [https://www.example.com, https://www.retellai.com]
        /// </param>
        /// <param name="enableAutoRefresh">
        /// Whether to enable auto refresh for the knowledge base urls. If set to true, will retrieve the data from the specified url every 12 hours.<br/>
        /// Example: true
        /// </param>
        /// <param name="maxChunkSize">
        /// Maximum number of characters per chunk when splitting knowledge base. Default is 2000. content. Immutable after creation.<br/>
        /// Example: 2000
        /// </param>
        /// <param name="minChunkSize">
        /// Minimum number of characters per chunk. Chunks smaller than this will be merged with adjacent chunks. Must be less than max_chunk_size. Immutable after creation. Default is 400.<br/>
        /// Example: 400
        /// </param>
        public KnowledgeBaseRequest(
            string knowledgeBaseName,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseRequestKnowledgeBaseText>? knowledgeBaseTexts,
            global::System.Collections.Generic.IList<byte[]>? knowledgeBaseFiles,
            global::System.Collections.Generic.IList<string>? knowledgeBaseUrls,
            bool? enableAutoRefresh,
            int? maxChunkSize,
            int? minChunkSize)
        {
            this.KnowledgeBaseName = knowledgeBaseName ?? throw new global::System.ArgumentNullException(nameof(knowledgeBaseName));
            this.KnowledgeBaseTexts = knowledgeBaseTexts;
            this.KnowledgeBaseFiles = knowledgeBaseFiles;
            this.KnowledgeBaseUrls = knowledgeBaseUrls;
            this.EnableAutoRefresh = enableAutoRefresh;
            this.MaxChunkSize = maxChunkSize;
            this.MinChunkSize = minChunkSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseRequest" /> class.
        /// </summary>
        public KnowledgeBaseRequest()
        {
        }
    }
}