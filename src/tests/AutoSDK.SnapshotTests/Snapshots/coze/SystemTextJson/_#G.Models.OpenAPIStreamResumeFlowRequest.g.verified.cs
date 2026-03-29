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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// 中断类型
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InterruptType { get; set; }

        /// <summary>
        /// 恢复执行时，用户对智能体指定问题的回复
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resume_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResumeData { get; set; }

        /// <summary>
        /// 待执行的 Workflow ID，此工作流应已发布
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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