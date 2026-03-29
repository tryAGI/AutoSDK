//HintName: G.Models.ThreadsQueryReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query threads with aggregated statistics based on turn calls only.<br/>
    /// Turn calls are the immediate children of thread contexts (where call.id == turn_id).<br/>
    /// This provides meaningful conversation-level statistics rather than including all<br/>
    /// nested implementation details.
    /// </summary>
    public sealed partial class ThreadsQueryReq
    {
        /// <summary>
        /// The ID of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Filter criteria for the threads query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.ThreadsQueryFilter? Filter { get; set; }

        /// <summary>
        /// Maximum number of threads to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Number of threads to skip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Sorting criteria for the threads. Supported fields: 'thread_id', 'turn_count', 'start_time', 'last_updated', 'p50_turn_duration_ms', 'p99_turn_duration_ms'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public global::System.Collections.Generic.IList<global::G.SortBy>? SortBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryReq" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="filter">
        /// Filter criteria for the threads query
        /// </param>
        /// <param name="limit">
        /// Maximum number of threads to return
        /// </param>
        /// <param name="offset">
        /// Number of threads to skip
        /// </param>
        /// <param name="sortBy">
        /// Sorting criteria for the threads. Supported fields: 'thread_id', 'turn_count', 'start_time', 'last_updated', 'p50_turn_duration_ms', 'p99_turn_duration_ms'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsQueryReq(
            string projectId,
            global::G.ThreadsQueryFilter? filter,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Filter = filter;
            this.Limit = limit;
            this.Offset = offset;
            this.SortBy = sortBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryReq" /> class.
        /// </summary>
        public ThreadsQueryReq()
        {
        }
    }
}