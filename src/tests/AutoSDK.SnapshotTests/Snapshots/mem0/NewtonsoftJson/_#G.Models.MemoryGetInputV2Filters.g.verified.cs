//HintName: G.Models.MemoryGetInputV2Filters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dictionary of filters to apply to retrieve memories. Available fields are: user_id, agent_id, app_id, run_id, created_at, updated_at, categories, keywords. Supports logical operators (AND, OR) and comparison operators (in, gte, lte, gt, lt, ne, contains, icontains, *). For categories field, use 'contains' for partial matching (e.g., {"categories": {"contains": "finance"}}) or 'in' for exact matching (e.g., {"categories": {"in": ["personal_information"]}}).
    /// </summary>
    public sealed partial class MemoryGetInputV2Filters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keywords")]
        public global::G.MemoryGetInputV2FiltersKeywords? Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories")]
        public global::G.MemoryGetInputV2FiltersCategories? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryGetInputV2Filters" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="agentId"></param>
        /// <param name="appId"></param>
        /// <param name="runId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="keywords"></param>
        /// <param name="categories"></param>
        /// <param name="metadata"></param>
        public MemoryGetInputV2Filters(
            string? userId,
            string? agentId,
            string? appId,
            string? runId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::G.MemoryGetInputV2FiltersKeywords? keywords,
            global::G.MemoryGetInputV2FiltersCategories? categories,
            object? metadata)
        {
            this.UserId = userId;
            this.AgentId = agentId;
            this.AppId = appId;
            this.RunId = runId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Keywords = keywords;
            this.Categories = categories;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryGetInputV2Filters" /> class.
        /// </summary>
        public MemoryGetInputV2Filters()
        {
        }
    }
}