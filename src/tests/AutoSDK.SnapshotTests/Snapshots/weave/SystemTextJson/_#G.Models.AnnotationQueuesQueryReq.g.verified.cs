//HintName: G.Models.AnnotationQueuesQueryReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to query annotation queues for a project.
    /// </summary>
    public sealed partial class AnnotationQueuesQueryReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Filter by queue name (case-insensitive partial match)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Sort by multiple fields (e.g., created_at, updated_at, name)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public global::System.Collections.Generic.IList<global::G.SortBy>? SortBy { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueuesQueryReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Filter by queue name (case-insensitive partial match)
        /// </param>
        /// <param name="sortBy">
        /// Sort by multiple fields (e.g., created_at, updated_at, name)
        /// </param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueuesQueryReq(
            string projectId,
            string? name,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy,
            int? limit,
            int? offset)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name;
            this.SortBy = sortBy;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueuesQueryReq" /> class.
        /// </summary>
        public AnnotationQueuesQueryReq()
        {
        }
    }
}