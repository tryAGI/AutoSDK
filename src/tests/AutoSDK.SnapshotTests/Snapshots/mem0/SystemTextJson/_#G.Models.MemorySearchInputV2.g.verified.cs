//HintName: G.Models.MemorySearchInputV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemorySearchInputV2
    {
        /// <summary>
        /// The query to search for in the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The version of the memory to use. This should always be v2.<br/>
        /// Default Value: v2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// A dictionary of filters to apply to the search. Available fields are: user_id, agent_id, app_id, run_id, created_at, updated_at, categories, keywords. Supports logical operators (AND, OR) and comparison operators (in, gte, lte, gt, lt, ne, contains, icontains). For categories field, use 'contains' for partial matching (e.g., {"categories": {"contains": "finance"}}) or 'in' for exact matching (e.g., {"categories": {"in": ["personal_information"]}}).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MemorySearchInputV2Filters Filters { get; set; }

        /// <summary>
        /// The number of top results to return.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// A list of field names to include in the response. If not provided, all fields will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<string>? Fields { get; set; }

        /// <summary>
        /// Whether to rerank the memories.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank")]
        public bool? Rerank { get; set; }

        /// <summary>
        /// Whether to search for memories based on keywords.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyword_search")]
        public bool? KeywordSearch { get; set; }

        /// <summary>
        /// Whether to filter the memories.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_memories")]
        public bool? FilterMemories { get; set; }

        /// <summary>
        /// The minimum similarity threshold for returned results.<br/>
        /// Default Value: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// The unique identifier of the organization associated with the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// The unique identifier of the project associated with the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemorySearchInputV2" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to search for in the memory.
        /// </param>
        /// <param name="filters">
        /// A dictionary of filters to apply to the search. Available fields are: user_id, agent_id, app_id, run_id, created_at, updated_at, categories, keywords. Supports logical operators (AND, OR) and comparison operators (in, gte, lte, gt, lt, ne, contains, icontains). For categories field, use 'contains' for partial matching (e.g., {"categories": {"contains": "finance"}}) or 'in' for exact matching (e.g., {"categories": {"in": ["personal_information"]}}).
        /// </param>
        /// <param name="version">
        /// The version of the memory to use. This should always be v2.<br/>
        /// Default Value: v2
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
        /// <param name="filterMemories">
        /// Whether to filter the memories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="threshold">
        /// The minimum similarity threshold for returned results.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="orgId">
        /// The unique identifier of the organization associated with the memory.
        /// </param>
        /// <param name="projectId">
        /// The unique identifier of the project associated with the memory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemorySearchInputV2(
            string query,
            global::G.MemorySearchInputV2Filters filters,
            string? version,
            int? topK,
            global::System.Collections.Generic.IList<string>? fields,
            bool? rerank,
            bool? keywordSearch,
            bool? filterMemories,
            double? threshold,
            string? orgId,
            string? projectId)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Version = version;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.TopK = topK;
            this.Fields = fields;
            this.Rerank = rerank;
            this.KeywordSearch = keywordSearch;
            this.FilterMemories = filterMemories;
            this.Threshold = threshold;
            this.OrgId = orgId;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemorySearchInputV2" /> class.
        /// </summary>
        public MemorySearchInputV2()
        {
        }
    }
}