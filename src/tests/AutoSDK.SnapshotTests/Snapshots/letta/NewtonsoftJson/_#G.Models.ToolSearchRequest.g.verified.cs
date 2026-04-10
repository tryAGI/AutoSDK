//HintName: G.Models.ToolSearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for searching tools using semantic search.
    /// </summary>
    public sealed partial class ToolSearchRequest
    {
        /// <summary>
        /// Text query for semantic search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Search mode: vector, fts, or hybrid.<br/>
        /// Default Value: hybrid
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolSearchRequestSearchModeJsonConverter))]
        public global::G.ToolSearchRequestSearchMode? SearchMode { get; set; }

        /// <summary>
        /// Filter by tool types (e.g., 'custom', 'letta_core').
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_types")]
        public global::System.Collections.Generic.IList<string>? ToolTypes { get; set; }

        /// <summary>
        /// Filter by tags (match any).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Maximum number of results to return.<br/>
        /// Default Value: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Text query for semantic search.
        /// </param>
        /// <param name="searchMode">
        /// Search mode: vector, fts, or hybrid.<br/>
        /// Default Value: hybrid
        /// </param>
        /// <param name="toolTypes">
        /// Filter by tool types (e.g., 'custom', 'letta_core').
        /// </param>
        /// <param name="tags">
        /// Filter by tags (match any).
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return.<br/>
        /// Default Value: 50
        /// </param>
        public ToolSearchRequest(
            string? query,
            global::G.ToolSearchRequestSearchMode? searchMode,
            global::System.Collections.Generic.IList<string>? toolTypes,
            global::System.Collections.Generic.IList<string>? tags,
            int? limit)
        {
            this.Query = query;
            this.SearchMode = searchMode;
            this.ToolTypes = toolTypes;
            this.Tags = tags;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchRequest" /> class.
        /// </summary>
        public ToolSearchRequest()
        {
        }
    }
}