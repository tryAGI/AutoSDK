//HintName: G.Models.Comment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comment Serializer with FSM state support.<br/>
    /// Note: The 'state' field will be populated from the queryset annotation<br/>
    /// if present, preventing N+1 queries. Use .with_state() on your queryset.<br/>
    /// The state field display is controlled by both:<br/>
    /// - fflag_feat_fit_568_finite_state_management (FSM background calculations)<br/>
    /// - fflag_feat_fit_710_fsm_state_fields (state field display in APIs)
    /// </summary>
    public sealed partial class Comment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation")]
        public int? Annotation { get; set; }

        /// <summary>
        /// Classifications applied by a reviewer or annotator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classifications")]
        public object? Classifications { get; set; }

        /// <summary>
        /// Creation time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// User who made this comment<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public int CreatedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft")]
        public int? Draft { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// True if the comment is resolved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_resolved")]
        public bool? IsResolved { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Set if this comment is related to a specific part of the annotation. Normally contains region ID and control name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region_ref")]
        public object? RegionRef { get; set; }

        /// <summary>
        /// Resolving time<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolved_at")]
        public global::System.DateTime? ResolvedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task")]
        public int? Task { get; set; }

        /// <summary>
        /// Reviewer or annotator comment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Last updated time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        /// <param name="annotation"></param>
        /// <param name="classifications">
        /// Classifications applied by a reviewer or annotator
        /// </param>
        /// <param name="draft"></param>
        /// <param name="isResolved">
        /// True if the comment is resolved
        /// </param>
        /// <param name="project">
        /// Included only in responses
        /// </param>
        /// <param name="regionRef">
        /// Set if this comment is related to a specific part of the annotation. Normally contains region ID and control name.
        /// </param>
        /// <param name="resolvedAt">
        /// Resolving time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="task">
        /// Included only in responses
        /// </param>
        /// <param name="text">
        /// Reviewer or annotator comment
        /// </param>
        /// <param name="createdAt">
        /// Creation time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// User who made this comment<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Last updated time<br/>
        /// Included only in responses
        /// </param>
        public Comment(
            int? annotation,
            object? classifications,
            int? draft,
            bool? isResolved,
            int? project,
            object? regionRef,
            global::System.DateTime? resolvedAt,
            int? task,
            string? text,
            global::System.DateTime createdAt = default!,
            int createdBy = default!,
            int id = default!,
            string state = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Annotation = annotation;
            this.Classifications = classifications;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Draft = draft;
            this.Id = id;
            this.IsResolved = isResolved;
            this.Project = project;
            this.RegionRef = regionRef;
            this.ResolvedAt = resolvedAt;
            this.State = state;
            this.Task = task;
            this.Text = text;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        public Comment()
        {
        }
    }
}