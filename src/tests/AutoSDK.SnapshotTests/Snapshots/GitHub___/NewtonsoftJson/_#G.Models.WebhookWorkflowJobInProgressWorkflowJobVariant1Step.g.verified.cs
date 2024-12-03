//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobVariant1Step.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowJobInProgressWorkflowJobVariant1Step
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CompletedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion? Conclusion { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? StartedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobInProgressWorkflowJobVariant1Step" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        public WebhookWorkflowJobInProgressWorkflowJobVariant1Step(
            string? completedAt,
            global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion? conclusion,
            string name,
            int number,
            string? startedAt,
            global::G.WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus status)
        {
            this.CompletedAt = completedAt ?? throw new global::System.ArgumentNullException(nameof(completedAt));
            this.Conclusion = conclusion;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Number = number;
            this.StartedAt = startedAt ?? throw new global::System.ArgumentNullException(nameof(startedAt));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobInProgressWorkflowJobVariant1Step" /> class.
        /// </summary>
        public WebhookWorkflowJobInProgressWorkflowJobVariant1Step()
        {
        }
    }
}