//HintName: G.Models.PostToolkitsMultiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Body parameters for filtering and sorting toolkits
    /// </summary>
    public sealed partial class PostToolkitsMultiRequest
    {
        /// <summary>
        /// Array of toolkit slug identifiers to retrieve<br/>
        /// Example: [github, slack, gmail]
        /// </summary>
        /// <example>[github, slack, gmail]</example>
        [global::Newtonsoft.Json.JsonProperty("toolkits")]
        public global::System.Collections.Generic.IList<string>? Toolkits { get; set; }

        /// <summary>
        /// Category ID or name to filter toolkits by<br/>
        /// Example: productivity
        /// </summary>
        /// <example>productivity</example>
        [global::Newtonsoft.Json.JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Entity responsible for managing the toolkits
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("managed_by")]
        public global::G.PostToolkitsMultiRequestManagedBy? ManagedBy { get; set; }

        /// <summary>
        /// Determines how toolkits should be sorted in the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort_by")]
        public global::G.PostToolkitsMultiRequestSortBy? SortBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolkitsMultiRequest" /> class.
        /// </summary>
        /// <param name="toolkits">
        /// Array of toolkit slug identifiers to retrieve<br/>
        /// Example: [github, slack, gmail]
        /// </param>
        /// <param name="category">
        /// Category ID or name to filter toolkits by<br/>
        /// Example: productivity
        /// </param>
        /// <param name="managedBy">
        /// Entity responsible for managing the toolkits
        /// </param>
        /// <param name="sortBy">
        /// Determines how toolkits should be sorted in the response
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        public PostToolkitsMultiRequest(
            global::System.Collections.Generic.IList<string>? toolkits,
            string? category,
            global::G.PostToolkitsMultiRequestManagedBy? managedBy,
            global::G.PostToolkitsMultiRequestSortBy? sortBy,
            double? limit,
            string? cursor)
        {
            this.Toolkits = toolkits;
            this.Category = category;
            this.ManagedBy = managedBy;
            this.SortBy = sortBy;
            this.Limit = limit;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolkitsMultiRequest" /> class.
        /// </summary>
        public PostToolkitsMultiRequest()
        {
        }
    }
}