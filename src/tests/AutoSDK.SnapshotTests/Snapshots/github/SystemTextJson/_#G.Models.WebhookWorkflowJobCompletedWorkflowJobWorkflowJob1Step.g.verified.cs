//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Step.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Step
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusionJsonConverter))]
        public global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion? Conclusion { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Step" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Step(
            string name,
            int number,
            global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus status,
            string? completedAt,
            global::G.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion? conclusion,
            string? startedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Number = number;
            this.Status = status;
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Step" /> class.
        /// </summary>
        public WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Step()
        {
        }
    }
}