//HintName: G.Models.AnnotationQueueItemSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for annotation queue item responses.
    /// </summary>
    public sealed partial class AnnotationQueueItemSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CallStartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_ended_at")]
        public global::System.DateTime? CallEndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_op_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallOpName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallTraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DisplayFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_by")]
        public string? AddedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnnotationQueueItemSchemaAnnotationStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnnotationQueueItemSchemaAnnotationState AnnotationState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator_user_id")]
        public string? AnnotatorUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_in_queue")]
        public int? PositionInQueue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemSchema" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="queueId"></param>
        /// <param name="callId"></param>
        /// <param name="callStartedAt"></param>
        /// <param name="callOpName"></param>
        /// <param name="callTraceId"></param>
        /// <param name="displayFields"></param>
        /// <param name="annotationState"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="updatedAt"></param>
        /// <param name="callEndedAt"></param>
        /// <param name="addedBy"></param>
        /// <param name="annotatorUserId"></param>
        /// <param name="deletedAt"></param>
        /// <param name="positionInQueue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueItemSchema(
            string id,
            string projectId,
            string queueId,
            string callId,
            global::System.DateTime callStartedAt,
            string callOpName,
            string callTraceId,
            global::System.Collections.Generic.IList<string> displayFields,
            global::G.AnnotationQueueItemSchemaAnnotationState annotationState,
            global::System.DateTime createdAt,
            string createdBy,
            global::System.DateTime updatedAt,
            global::System.DateTime? callEndedAt,
            string? addedBy,
            string? annotatorUserId,
            global::System.DateTime? deletedAt,
            int? positionInQueue)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.QueueId = queueId ?? throw new global::System.ArgumentNullException(nameof(queueId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.CallStartedAt = callStartedAt;
            this.CallEndedAt = callEndedAt;
            this.CallOpName = callOpName ?? throw new global::System.ArgumentNullException(nameof(callOpName));
            this.CallTraceId = callTraceId ?? throw new global::System.ArgumentNullException(nameof(callTraceId));
            this.DisplayFields = displayFields ?? throw new global::System.ArgumentNullException(nameof(displayFields));
            this.AddedBy = addedBy;
            this.AnnotationState = annotationState;
            this.AnnotatorUserId = annotatorUserId;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
            this.PositionInQueue = positionInQueue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemSchema" /> class.
        /// </summary>
        public AnnotationQueueItemSchema()
        {
        }
    }
}