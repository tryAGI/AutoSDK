//HintName: G.Models.WebhookWorkflowJobQueuedWorkflowJobStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowJobQueuedWorkflowJobStep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookWorkflowJobQueuedWorkflowJobStepConclusionJsonConverter))]
        public global::G.WebhookWorkflowJobQueuedWorkflowJobStepConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookWorkflowJobQueuedWorkflowJobStepStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowJobQueuedWorkflowJobStepStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobQueuedWorkflowJobStep" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="status"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="startedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookWorkflowJobQueuedWorkflowJobStep(
            string name,
            int number,
            global::G.WebhookWorkflowJobQueuedWorkflowJobStepStatus status,
            string? completedAt,
            global::G.WebhookWorkflowJobQueuedWorkflowJobStepConclusion? conclusion,
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
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobQueuedWorkflowJobStep" /> class.
        /// </summary>
        public WebhookWorkflowJobQueuedWorkflowJobStep()
        {
        }
    }
}