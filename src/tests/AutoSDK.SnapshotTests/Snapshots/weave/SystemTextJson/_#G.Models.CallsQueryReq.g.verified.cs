//HintName: G.Models.CallsQueryReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallsQueryReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.CallsFilter? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public global::System.Collections.Generic.IList<global::G.SortBy>? SortBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::G.Query? Query { get; set; }

        /// <summary>
        /// Beta, subject to change. If true, the response will include any model costs for each call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_costs")]
        public bool? IncludeCosts { get; set; }

        /// <summary>
        /// Beta, subject to change. If true, the response will include feedback for each call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_feedback")]
        public bool? IncludeFeedback { get; set; }

        /// <summary>
        /// Beta, subject to change. If true, the response will include the storage size for a call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_storage_size")]
        public bool? IncludeStorageSize { get; set; }

        /// <summary>
        /// Beta, subject to change. If true, the response will include the total storage size for a trace.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_total_storage_size")]
        public bool? IncludeTotalStorageSize { get; set; }

        /// <summary>
        /// If true, the response will attempt to resolve each call's wb_user_id to a username for the duration of this request.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_usernames")]
        public bool? IncludeUsernames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<string>? Columns { get; set; }

        /// <summary>
        /// Columns to expand, i.e. refs to other objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_columns")]
        public global::System.Collections.Generic.IList<string>? ExpandColumns { get; set; }

        /// <summary>
        /// If true, the response will include raw values for expanded columns. If false, the response expand_columns will only be used for filtering and ordering. This is useful for clients that want to resolve refs themselves, e.g. for performance reasons.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_expanded_column_values")]
        public bool? ReturnExpandedColumnValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsQueryReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filter"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="sortBy"></param>
        /// <param name="query"></param>
        /// <param name="includeCosts">
        /// Beta, subject to change. If true, the response will include any model costs for each call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeFeedback">
        /// Beta, subject to change. If true, the response will include feedback for each call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeStorageSize">
        /// Beta, subject to change. If true, the response will include the storage size for a call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTotalStorageSize">
        /// Beta, subject to change. If true, the response will include the total storage size for a trace.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeUsernames">
        /// If true, the response will attempt to resolve each call's wb_user_id to a username for the duration of this request.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="columns"></param>
        /// <param name="expandColumns">
        /// Columns to expand, i.e. refs to other objects
        /// </param>
        /// <param name="returnExpandedColumnValues">
        /// If true, the response will include raw values for expanded columns. If false, the response expand_columns will only be used for filtering and ordering. This is useful for clients that want to resolve refs themselves, e.g. for performance reasons.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallsQueryReq(
            string projectId,
            global::G.CallsFilter? filter,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy,
            global::G.Query? query,
            bool? includeCosts,
            bool? includeFeedback,
            bool? includeStorageSize,
            bool? includeTotalStorageSize,
            bool? includeUsernames,
            global::System.Collections.Generic.IList<string>? columns,
            global::System.Collections.Generic.IList<string>? expandColumns,
            bool? returnExpandedColumnValues)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Filter = filter;
            this.Limit = limit;
            this.Offset = offset;
            this.SortBy = sortBy;
            this.Query = query;
            this.IncludeCosts = includeCosts;
            this.IncludeFeedback = includeFeedback;
            this.IncludeStorageSize = includeStorageSize;
            this.IncludeTotalStorageSize = includeTotalStorageSize;
            this.IncludeUsernames = includeUsernames;
            this.Columns = columns;
            this.ExpandColumns = expandColumns;
            this.ReturnExpandedColumnValues = returnExpandedColumnValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsQueryReq" /> class.
        /// </summary>
        public CallsQueryReq()
        {
        }
    }
}