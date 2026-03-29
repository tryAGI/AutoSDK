//HintName: G.Models.OpenAPIStreamResumeFlowRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIStreamResumeFlowRequest
    {
        /// <summary>
        /// 工作流执行中断事件 ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// 中断类型
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interrupt_type", Required = global::Newtonsoft.Json.Required.Always)]
        public int InterruptType { get; set; } = default!;

        /// <summary>
        /// 恢复执行时，用户对智能体指定问题的回复
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resume_data", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResumeData { get; set; } = default!;

        /// <summary>
        /// 待执行的 Workflow ID，此工作流应已发布
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkflowId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIStreamResumeFlowRequest" /> class.
        /// </summary>
        /// <param name="eventId">
        /// 工作流执行中断事件 ID
        /// </param>
        /// <param name="interruptType">
        /// 中断类型
        /// </param>
        /// <param name="resumeData">
        /// 恢复执行时，用户对智能体指定问题的回复
        /// </param>
        /// <param name="workflowId">
        /// 待执行的 Workflow ID，此工作流应已发布
        /// </param>
        public OpenAPIStreamResumeFlowRequest(
            string eventId,
            int interruptType,
            string resumeData,
            string workflowId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.InterruptType = interruptType;
            this.ResumeData = resumeData ?? throw new global::System.ArgumentNullException(nameof(resumeData));
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIStreamResumeFlowRequest" /> class.
        /// </summary>
        public OpenAPIStreamResumeFlowRequest()
        {
        }
    }
}