//HintName: G.Models.MetadataCursorPagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cursor pagination with status and metadata.
    /// </summary>
    public sealed partial class MetadataCursorPagination
    {
        /// <summary>
        /// Maximum number of items to return per page (1-100)<br/>
        /// Default Value: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Cursor for forward pagination - get items after this position. Use last_cursor from previous response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after")]
        public string? After { get; set; }

        /// <summary>
        /// Cursor for backward pagination - get items before this position. Use first_cursor from previous response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("before")]
        public string? Before { get; set; }

        /// <summary>
        /// Whether to include total count in response (expensive operation)<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_total")]
        public bool? IncludeTotal { get; set; }

        /// <summary>
        /// Status to filter by
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses")]
        public global::System.Collections.Generic.IList<global::G.StoreFileStatus>? Statuses { get; set; }

        /// <summary>
        /// Metadata filter to apply to the query
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_filter")]
        public global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? MetadataFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataCursorPagination" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return per page (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for forward pagination - get items after this position. Use last_cursor from previous response.
        /// </param>
        /// <param name="before">
        /// Cursor for backward pagination - get items before this position. Use first_cursor from previous response.
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include total count in response (expensive operation)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="statuses">
        /// Status to filter by
        /// </param>
        /// <param name="metadataFilter">
        /// Metadata filter to apply to the query
        /// </param>
        public MetadataCursorPagination(
            int? limit,
            string? after,
            string? before,
            bool? includeTotal,
            global::System.Collections.Generic.IList<global::G.StoreFileStatus>? statuses,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? metadataFilter)
        {
            this.Limit = limit;
            this.After = after;
            this.Before = before;
            this.IncludeTotal = includeTotal;
            this.Statuses = statuses;
            this.MetadataFilter = metadataFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataCursorPagination" /> class.
        /// </summary>
        public MetadataCursorPagination()
        {
        }
    }
}