//HintName: G.Models.Pause.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class Pause
    {
        /// <summary>
        /// Timestamp when this pause record was created<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp when this pause record was soft-deleted<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// User who soft-deleted this pause record<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_by")]
        public int? DeletedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("paused_by")]
        public global::G.UserSimple PausedBy { get; set; } = default!;

        /// <summary>
        /// Related project for which the pause is set<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Reason for pausing<br/>
        /// * `MANUAL` - Manual<br/>
        /// * `BEHAVIOR_BASED` - Behavior-based<br/>
        /// * `ANNOTATOR_EVALUATION` - Annotator evaluation<br/>
        /// * `ANNOTATION_LIMIT` - Annotation limit<br/>
        /// * `CUSTOM_SCRIPT` - Custom script
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReasonEnum Reason { get; set; } = default!;

        /// <summary>
        /// Timestamp when this pause record was last updated<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// User who is paused<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public int? User { get; set; }

        /// <summary>
        /// Detailed description of why the project is paused, will be readable by paused annotators
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verbose_reason")]
        public string? VerboseReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pause" /> class.
        /// </summary>
        /// <param name="reason">
        /// Reason for pausing<br/>
        /// * `MANUAL` - Manual<br/>
        /// * `BEHAVIOR_BASED` - Behavior-based<br/>
        /// * `ANNOTATOR_EVALUATION` - Annotator evaluation<br/>
        /// * `ANNOTATION_LIMIT` - Annotation limit<br/>
        /// * `CUSTOM_SCRIPT` - Custom script
        /// </param>
        /// <param name="deletedAt">
        /// Timestamp when this pause record was soft-deleted<br/>
        /// Included only in responses
        /// </param>
        /// <param name="deletedBy">
        /// User who soft-deleted this pause record<br/>
        /// Included only in responses
        /// </param>
        /// <param name="project">
        /// Related project for which the pause is set<br/>
        /// Included only in responses
        /// </param>
        /// <param name="user">
        /// User who is paused<br/>
        /// Included only in responses
        /// </param>
        /// <param name="verboseReason">
        /// Detailed description of why the project is paused, will be readable by paused annotators
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when this pause record was created<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="pausedBy">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when this pause record was last updated<br/>
        /// Included only in responses
        /// </param>
        public Pause(
            global::G.ReasonEnum reason,
            global::System.DateTime? deletedAt,
            int? deletedBy,
            int? project,
            int? user,
            string? verboseReason,
            global::System.DateTime createdAt = default!,
            int id = default!,
            global::G.UserSimple pausedBy = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.CreatedAt = createdAt;
            this.DeletedAt = deletedAt;
            this.DeletedBy = deletedBy;
            this.Id = id;
            this.PausedBy = pausedBy;
            this.Project = project;
            this.Reason = reason;
            this.UpdatedAt = updatedAt;
            this.User = user;
            this.VerboseReason = verboseReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pause" /> class.
        /// </summary>
        public Pause()
        {
        }
    }
}