//HintName: G.Models.WebhookWorkflowJobWaitingWorkflowJobStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowJobWaitingWorkflowJobStep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebhookWorkflowJobWaitingWorkflowJobStepConclusionJsonConverter))]
        public global::G.WebhookWorkflowJobWaitingWorkflowJobStepConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebhookWorkflowJobWaitingWorkflowJobStepStatusJsonConverter))]
        public global::G.WebhookWorkflowJobWaitingWorkflowJobStepStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobWaitingWorkflowJobStep" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="status"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="startedAt"></param>
        public WebhookWorkflowJobWaitingWorkflowJobStep(
            string name,
            int number,
            global::G.WebhookWorkflowJobWaitingWorkflowJobStepStatus status,
            string? completedAt,
            global::G.WebhookWorkflowJobWaitingWorkflowJobStepConclusion? conclusion,
            string? startedAt)
        {
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Number = number;
            this.StartedAt = startedAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobWaitingWorkflowJobStep" /> class.
        /// </summary>
        public WebhookWorkflowJobWaitingWorkflowJobStep()
        {
        }
    }
}