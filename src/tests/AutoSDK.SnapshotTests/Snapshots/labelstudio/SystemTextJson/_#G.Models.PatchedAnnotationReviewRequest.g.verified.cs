//HintName: G.Models.PatchedAnnotationReviewRequest.g.cs

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
    public sealed partial class PatchedAnnotationReviewRequest
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
        public int? Annotation { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_annotation_history")]
        public int? LastAnnotationHistory { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAnnotationReviewRequest" /> class.
        /// </summary>
        /// <param name="accepted">
        /// Accepted or rejected (if false) flag
        /// </param>
        /// <param name="annotation">
        /// Corresponding annotation
        /// </param>
        /// <param name="comment">
        /// Included only in requests
        /// </param>
        /// <param name="lastAnnotationHistory"></param>
        /// <param name="removeFromQueue"></param>
        /// <param name="result"></param>
        /// <param name="startedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedAnnotationReviewRequest(
            bool? accepted,
            int? annotation,
            string? comment,
            int? lastAnnotationHistory,
            bool? removeFromQueue,
            object? result,
            global::System.DateTime? startedAt)
        {
            this.Accepted = accepted;
            this.Annotation = annotation;
            this.Comment = comment;
            this.LastAnnotationHistory = lastAnnotationHistory;
            this.RemoveFromQueue = removeFromQueue;
            this.Result = result;
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAnnotationReviewRequest" /> class.
        /// </summary>
        public PatchedAnnotationReviewRequest()
        {
        }
    }
}