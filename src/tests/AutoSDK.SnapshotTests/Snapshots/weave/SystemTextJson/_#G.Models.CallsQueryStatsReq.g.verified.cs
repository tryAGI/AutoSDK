//HintName: G.Models.CallsQueryStatsReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallsQueryStatsReq
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
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::G.Query? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_total_storage_size")]
        public bool? IncludeTotalStorageSize { get; set; }

        /// <summary>
        /// Columns with refs to objects or table rows that require expansion during filtering or ordering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_columns")]
        public global::System.Collections.Generic.IList<string>? ExpandColumns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsQueryStatsReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filter"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="includeTotalStorageSize">
        /// Default Value: false
        /// </param>
        /// <param name="expandColumns">
        /// Columns with refs to objects or table rows that require expansion during filtering or ordering.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallsQueryStatsReq(
            string projectId,
            global::G.CallsFilter? filter,
            global::G.Query? query,
            int? limit,
            bool? includeTotalStorageSize,
            global::System.Collections.Generic.IList<string>? expandColumns)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Filter = filter;
            this.Query = query;
            this.Limit = limit;
            this.IncludeTotalStorageSize = includeTotalStorageSize;
            this.ExpandColumns = expandColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsQueryStatsReq" /> class.
        /// </summary>
        public CallsQueryStatsReq()
        {
        }
    }
}