//HintName: G.Models.AnnotationReview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AnnotationReview Serializer with FSM state support.<br/>
    /// Note: The 'state' field will be populated from the queryset annotation<br/>
    /// if present, preventing N+1 queries. Use .with_state() on your queryset.<br/>
    /// The state field display is controlled by both:<br/>
    /// - fflag_feat_fit_568_finite_state_management (FSM background calculations)<br/>
    /// - fflag_feat_fit_710_fsm_state_fields (state field display in APIs)
    /// </summary>
    public sealed partial class AnnotationReview
    {
        /// <summary>
        /// Accepted or rejected (if false) flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        public bool? Accepted { get; set; }

        /// <summary>
        /// Corresponding annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Annotation { get; set; }

        /// <summary>
        /// Creation time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// User who made this review<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public int CreatedBy { get; set; } = default!;

        /// <summary>
        /// Fixed annotation history item by the reviewer<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed_annotation_history")]
        public int? FixedAnnotationHistory { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_annotation_history")]
        public int? LastAnnotationHistory { get; set; }

        /// <summary>
        /// Previous annotation history item by the annotator<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_annotation_history")]
        public int? PreviousAnnotationHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_from_queue")]
        public bool? RemoveFromQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationReview" /> class.
        /// </summary>
        /// <param name="annotation">
        /// Corresponding annotation
        /// </param>
        /// <param name="accepted">
        /// Accepted or rejected (if false) flag
        /// </param>
        /// <param name="fixedAnnotationHistory">
        /// Fixed annotation history item by the reviewer<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastAnnotationHistory"></param>
        /// <param name="previousAnnotationHistory">
        /// Previous annotation history item by the annotator<br/>
        /// Included only in responses
        /// </param>
        /// <param name="removeFromQueue"></param>
        /// <param name="result"></param>
        /// <param name="startedAt"></param>
        /// <param name="createdAt">
        /// Creation time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// User who made this review<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationReview(
            int annotation,
            bool? accepted,
            int? fixedAnnotationHistory,
            int? lastAnnotationHistory,
            int? previousAnnotationHistory,
            bool? removeFromQueue,
            object? result,
            global::System.DateTime? startedAt,
            global::System.DateTime createdAt = default!,
            int createdBy = default!,
            int id = default!,
            string state = default!)
        {
            this.Accepted = accepted;
            this.Annotation = annotation;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.FixedAnnotationHistory = fixedAnnotationHistory;
            this.Id = id;
            this.LastAnnotationHistory = lastAnnotationHistory;
            this.PreviousAnnotationHistory = previousAnnotationHistory;
            this.RemoveFromQueue = removeFromQueue;
            this.Result = result;
            this.StartedAt = startedAt;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationReview" /> class.
        /// </summary>
        public AnnotationReview()
        {
        }
    }
}