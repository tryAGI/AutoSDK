//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobVariant2Step.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowJobInProgressWorkflowJobVariant2Step
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
        public string? Conclusion { get; set; }

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatusJsonConverter))]
        public global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobInProgressWorkflowJobVariant2Step" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="status"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="startedAt"></param>
        public WebhookWorkflowJobInProgressWorkflowJobVariant2Step(
            string name,
            int number,
            global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus status,
            string? completedAt,
            string? conclusion,
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
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobInProgressWorkflowJobVariant2Step" /> class.
        /// </summary>
        public WebhookWorkflowJobInProgressWorkflowJobVariant2Step()
        {
        }
    }
}