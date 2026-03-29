//HintName: G.Models.FeedbackReplaceReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackReplaceReq
    {
        /// <summary>
        /// If provided by the client, this ID will be used for the feedback row instead of a server-generated one.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weave_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string WeaveRef { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeedbackType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public object Payload { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_ref")]
        public string? AnnotationRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runnable_ref")]
        public string? RunnableRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_ref")]
        public string? CallRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_ref")]
        public string? TriggerRef { get; set; }

        /// <summary>
        /// The annotation queue ID this feedback was created from. References annotation_queues.id. NULL when feedback is created outside of queues.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_id")]
        public string? QueueId { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeedbackId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackReplaceReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="weaveRef"></param>
        /// <param name="feedbackType"></param>
        /// <param name="payload"></param>
        /// <param name="feedbackId"></param>
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
        public FeedbackReplaceReq(
            string projectId,
            string weaveRef,
            string feedbackType,
            object payload,
            string feedbackId,
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
            this.FeedbackId = feedbackId ?? throw new global::System.ArgumentNullException(nameof(feedbackId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackReplaceReq" /> class.
        /// </summary>
        public FeedbackReplaceReq()
        {
        }
    }
}