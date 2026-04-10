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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string QueueId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CallStartedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_ended_at")]
        public global::System.DateTime? CallEndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_op_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallOpName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_trace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallTraceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_fields", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> DisplayFields { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("added_by")]
        public string? AddedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_state", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AnnotationQueueItemSchemaAnnotationStateJsonConverter))]
        public global::G.AnnotationQueueItemSchemaAnnotationState AnnotationState { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotator_user_id")]
        public string? AnnotatorUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position_in_queue")]
        public int? PositionInQueue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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