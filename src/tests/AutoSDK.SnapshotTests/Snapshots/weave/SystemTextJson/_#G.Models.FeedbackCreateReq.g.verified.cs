//HintName: G.Models.FeedbackCreateReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackCreateReq
    {
        /// <summary>
        /// If provided by the client, this ID will be used for the feedback row instead of a server-generated one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weave_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WeaveRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedbackType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_ref")]
        public string? AnnotationRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runnable_ref")]
        public string? RunnableRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_ref")]
        public string? CallRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_ref")]
        public string? TriggerRef { get; set; }

        /// <summary>
        /// The annotation queue ID this feedback was created from. References annotation_queues.id. NULL when feedback is created outside of queues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_id")]
        public string? QueueId { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="weaveRef"></param>
        /// <param name="feedbackType"></param>
        /// <param name="payload"></param>
        /// <param name="id">
        /// If provided by the client, this ID will be used for the feedback row instead of a server-generated one.
        /// </param>
        /// <param name="creator"></param>
        /// <param name="annotationRef"></param>
        /// <param name="runnableRef"></param>
        /// <param name="callRef"></param>
        /// <param name="triggerRef"></param>
        /// <param name="queueId">
        /// The annotation queue ID this feedback was created from. References annotation_queues.id. NULL when feedback is created outside of queues.
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackCreateReq(
            string projectId,
            string weaveRef,
            string feedbackType,
            object payload,
            string? id,
            string? creator,
            string? annotationRef,
            string? runnableRef,
            string? callRef,
            string? triggerRef,
            string? queueId,
            string? wbUserId)
        {
            this.Id = id;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.WeaveRef = weaveRef ?? throw new global::System.ArgumentNullException(nameof(weaveRef));
            this.Creator = creator;
            this.FeedbackType = feedbackType ?? throw new global::System.ArgumentNullException(nameof(feedbackType));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.AnnotationRef = annotationRef;
            this.RunnableRef = runnableRef;
            this.CallRef = callRef;
            this.TriggerRef = triggerRef;
            this.QueueId = queueId;
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateReq" /> class.
        /// </summary>
        public FeedbackCreateReq()
        {
        }
    }
}