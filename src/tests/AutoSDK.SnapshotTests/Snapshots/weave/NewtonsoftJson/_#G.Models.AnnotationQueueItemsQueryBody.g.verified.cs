//HintName: G.Models.AnnotationQueueItemsQueryBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for querying items in an annotation queue (queue_id comes from path).
    /// </summary>
    public sealed partial class AnnotationQueueItemsQueryBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Filter queue items by call metadata and annotation state
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.AnnotationQueueItemsFilter? Filter { get; set; }

        /// <summary>
        /// Sort by multiple fields (e.g., created_at, updated_at)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort_by")]
        public global::System.Collections.Generic.IList<global::G.SortBy>? SortBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Include position_in_queue field (1-based index in full queue)<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_position")]
        public bool? IncludePosition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemsQueryBody" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filter">
        /// Filter queue items by call metadata and annotation state
        /// </param>
        /// <param name="sortBy">
        /// Sort by multiple fields (e.g., created_at, updated_at)
        /// </param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="includePosition">
        /// Include position_in_queue field (1-based index in full queue)<br/>
        /// Default Value: false
        /// </param>
        public AnnotationQueueItemsQueryBody(
            string projectId,
            global::G.AnnotationQueueItemsFilter? filter,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy,
            int? limit,
            int? offset,
            bool? includePosition)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Filter = filter;
            this.SortBy = sortBy;
            this.Limit = limit;
            this.Offset = offset;
            this.IncludePosition = includePosition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemsQueryBody" /> class.
        /// </summary>
        public AnnotationQueueItemsQueryBody()
        {
        }
    }
}