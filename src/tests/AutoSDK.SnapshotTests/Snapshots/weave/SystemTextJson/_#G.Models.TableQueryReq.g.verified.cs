//HintName: G.Models.TableQueryReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableQueryReq
    {
        /// <summary>
        /// The ID of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The digest of the table to query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// Optional filter to apply to the query. See `TableRowFilter` for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.TableRowFilter? Filter { get; set; }

        /// <summary>
        /// Maximum number of rows to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Number of rows to skip before starting to return rows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// List of fields to sort by. Fields can be dot-separated to access dictionary values. No sorting uses the default table order (insertion order).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public global::System.Collections.Generic.IList<global::G.SortBy>? SortBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableQueryReq" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="digest">
        /// The digest of the table to query
        /// </param>
        /// <param name="filter">
        /// Optional filter to apply to the query. See `TableRowFilter` for more details.
        /// </param>
        /// <param name="limit">
        /// Maximum number of rows to return
        /// </param>
        /// <param name="offset">
        /// Number of rows to skip before starting to return rows
        /// </param>
        /// <param name="sortBy">
        /// List of fields to sort by. Fields can be dot-separated to access dictionary values. No sorting uses the default table order (insertion order).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableQueryReq(
            string projectId,
            string digest,
            global::G.TableRowFilter? filter,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Filter = filter;
            this.Limit = limit;
            this.Offset = offset;
            this.SortBy = sortBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableQueryReq" /> class.
        /// </summary>
        public TableQueryReq()
        {
        }
    }
}