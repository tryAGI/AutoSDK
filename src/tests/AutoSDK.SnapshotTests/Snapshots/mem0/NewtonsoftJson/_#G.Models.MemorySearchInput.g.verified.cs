//HintName: G.Models.MemorySearchInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemorySearchInput
    {
        /// <summary>
        /// The query to search for in the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// The agent ID associated with the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The user ID associated with the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The app ID associated with the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// The run ID associated with the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Additional metadata associated with the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The number of top results to return.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// A list of field names to include in the response. If not provided, all fields will be returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fields")]
        public global::System.Collections.Generic.IList<string>? Fields { get; set; }

        /// <summary>
        /// Whether to rerank the memories.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rerank")]
        public bool? Rerank { get; set; }

        /// <summary>
        /// Whether to search for memories based on keywords.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keyword_search")]
        public bool? KeywordSearch { get; set; }

        /// <summary>
        /// The search method supports two output formats: `v1.0` (default) and `v1.1`. We recommend using `v1.1` as `v1.0` will be deprecated soon.<br/>
        /// Default Value: v1.1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// The unique identifier of the organization associated with the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// The unique identifier of the project associated with the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Whether to properly filter the memories according to the input.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_memories")]
        public bool? FilterMemories { get; set; }

        /// <summary>
        /// A list of categories to filter the memories by.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// Whether to only search for memories based on metadata.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("only_metadata_based_search")]
        public bool? OnlyMetadataBasedSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemorySearchInput" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to search for in the memory.
        /// </param>
        /// <param name="agentId">
        /// The agent ID associated with the memory.
        /// </param>
        /// <param name="userId">
        /// The user ID associated with the memory.
        /// </param>
        /// <param name="appId">
        /// The app ID associated with the memory.
        /// </param>
        /// <param name="runId">
        /// The run ID associated with the memory.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory.
        /// </param>
        /// <param name="topK">
        /// The number of top results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="fields">
        /// A list of field names to include in the response. If not provided, all fields will be returned.
        /// </param>
        /// <param name="rerank">
        /// Whether to rerank the memories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keywordSearch">
        /// Whether to search for memories based on keywords.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputFormat">
        /// The search method supports two output formats: `v1.0` (default) and `v1.1`. We recommend using `v1.1` as `v1.0` will be deprecated soon.<br/>
        /// Default Value: v1.1
        /// </param>
        /// <param name="orgId">
        /// The unique identifier of the organization associated with the memory.
        /// </param>
        /// <param name="projectId">
        /// The unique identifier of the project associated with the memory.
        /// </param>
        /// <param name="filterMemories">
        /// Whether to properly filter the memories according to the input.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="categories">
        /// A list of categories to filter the memories by.
        /// </param>
        /// <param name="onlyMetadataBasedSearch">
        /// Whether to only search for memories based on metadata.<br/>
        /// Default Value: false
        /// </param>
        public MemorySearchInput(
            string query,
            string? agentId,
            string? userId,
            string? appId,
            string? runId,
            object? metadata,
            int? topK,
            global::System.Collections.Generic.IList<string>? fields,
            bool? rerank,
            bool? keywordSearch,
            string? outputFormat,
            string? orgId,
            string? projectId,
            bool? filterMemories,
            global::System.Collections.Generic.IList<string>? categories,
            bool? onlyMetadataBasedSearch)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.AgentId = agentId;
            this.UserId = userId;
            this.AppId = appId;
            this.RunId = runId;
            this.Metadata = metadata;
            this.TopK = topK;
            this.Fields = fields;
            this.Rerank = rerank;
            this.KeywordSearch = keywordSearch;
            this.OutputFormat = outputFormat;
            this.OrgId = orgId;
            this.ProjectId = projectId;
            this.FilterMemories = filterMemories;
            this.Categories = categories;
            this.OnlyMetadataBasedSearch = onlyMetadataBasedSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemorySearchInput" /> class.
        /// </summary>
        public MemorySearchInput()
        {
        }
    }
}