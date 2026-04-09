//HintName: G.Models.AnnotationHistory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class AnnotationHistory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ActionEnumJsonConverter))]
        public global::G.ActionEnum? Action { get; set; }

        /// <summary>
        /// Corresponding annotation for this historical annotation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_id")]
        public int? AnnotationId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Comment id sent with result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment_id")]
        public int? CommentId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Created by user id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Corresponding draft for this historical annotation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft_id")]
        public int? DraftId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// How much time it took to annotate the task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lead_time")]
        public double? LeadTime { get; set; }

        /// <summary>
        /// Organization for this annotation history
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Project for this annotation history
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Labeling result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public object? Result { get; set; }

        /// <summary>
        /// AnnotationReview ID, using with review field
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_id")]
        public int? ReviewId { get; set; }

        /// <summary>
        /// The time that a user started working on this revision of the annotation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Task id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_id")]
        public int? TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationHistory" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="annotationId">
        /// Corresponding annotation for this historical annotation
        /// </param>
        /// <param name="comment">
        /// Included only in responses
        /// </param>
        /// <param name="commentId">
        /// Comment id sent with result
        /// </param>
        /// <param name="createdBy">
        /// Created by user id
        /// </param>
        /// <param name="draftId">
        /// Corresponding draft for this historical annotation
        /// </param>
        /// <param name="leadTime">
        /// How much time it took to annotate the task
        /// </param>
        /// <param name="organizationId">
        /// Organization for this annotation history
        /// </param>
        /// <param name="projectId">
        /// Project for this annotation history
        /// </param>
        /// <param name="result">
        /// Labeling result
        /// </param>
        /// <param name="reviewId">
        /// AnnotationReview ID, using with review field
        /// </param>
        /// <param name="startedAt">
        /// The time that a user started working on this revision of the annotation
        /// </param>
        /// <param name="taskId">
        /// Task id
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        public AnnotationHistory(
            global::G.ActionEnum? action,
            int? annotationId,
            string? comment,
            int? commentId,
            int? createdBy,
            int? draftId,
            double? leadTime,
            int? organizationId,
            int? projectId,
            object? result,
            int? reviewId,
            global::System.DateTime? startedAt,
            int? taskId,
            global::System.DateTime createdAt = default!,
            int id = default!)
        {
            this.Action = action;
            this.AnnotationId = annotationId;
            this.Comment = comment;
            this.CommentId = commentId;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.DraftId = draftId;
            this.Id = id;
            this.LeadTime = leadTime;
            this.OrganizationId = organizationId;
            this.ProjectId = projectId;
            this.Result = result;
            this.ReviewId = reviewId;
            this.StartedAt = startedAt;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationHistory" /> class.
        /// </summary>
        public AnnotationHistory()
        {
        }
    }
}